﻿using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Plus.v1;
using Google.Apis.Plus.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WolvenApp.Auth;
using WolvenApp.DAL;

namespace WolvenApp.Controllers
{
    public class HomeController : Controller
    {
        private WolvenContext db = new WolvenContext();

        //
        // GET: /Auth/
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GoogleLogin(CancellationToken cancelToken)
        {
            var result = await new AuthorizationCodeMvcApp(this,
                new GoogleAuth()).AuthorizeAsync(cancelToken);

            if (result.Credential == null)
                return new RedirectResult(result.RedirectUri);

            var plusService = new PlusService(new BaseClientService.Initializer
            {
                HttpClientInitializer = result.Credential,
                ApplicationName = "MyApp"
            });

            // get the user basic information
            Person me = plusService.People.Get("me").Execute();

            // check if the user is already in our database
            User account = db.Users.FirstOrDefault(u =>
                u.UserId.Equals(me.Id));
            
            User profile = new User()
            {
                Name = me.Name.GivenName + " " + me.Name.FamilyName,
                Email = me.Emails.ElementAt(0).Value,
                DisplayName = me.DisplayName,
                Picture = me.Image.Url,
                UserId = me.Id,
                Provider = IdentityProvider.Google
            };

            if (account == null)
            // this is a new user -> register view
            {            
                db.Users.Add(profile);
                db.SaveChanges();
            }

            Session["login"] = profile;

            return RedirectToAction("Index", "home");
        }
    }
}