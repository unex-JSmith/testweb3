﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testweb3.Startup))]
namespace testweb3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
