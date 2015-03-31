using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Plus.v1;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace WolvenApp.Auth
{
    class GoogleAuth : FlowMetadata
    {
        private static readonly IAuthorizationCodeFlow flow =
            new GoogleAuthorizationCodeFlow(new
                GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = "631570348379-docrq1njcticg91g5puf6sa7q861osna.apps.googleusercontent.com",
                        ClientSecret = "leflwZyAcwfyF-MzFayb12hY"
                    },
                    Scopes = new[] 
                    { 
                        PlusService.Scope.UserinfoEmail,
                        PlusService.Scope.UserinfoProfile
                    },
                    DataStore = new FileDataStore("Google.Apis.Sample.MVC")
                });

        public override string GetUserId(Controller controller)
        {
            return "user1";
        }

        public override IAuthorizationCodeFlow Flow
        {
            get { return flow; }
        }
    }
}
