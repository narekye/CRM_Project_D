﻿using CRM.Entities;
using CRM.WebApi.InfrastructureOAuth;
using CRM.WebApi.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

namespace CRM.WebApi
{
    public partial class Startup
    {
        private void ConfigureOAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext<CrmUserManager>(CrmUserManager.Create);
            app.CreatePerOwinContext(CRMContext.Create);

            var options = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new ApplicationOAuthProvider()
            };
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication
            (
                new OAuthBearerAuthenticationOptions
                {
                    Provider = new OAuthBearerAuthenticationProvider()
                }
            );
        }
    }
}