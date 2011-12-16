using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using ServiceStack.WebHost.Endpoints;
using System.Reflection;

namespace TestServiceStackService
{
    public class Global : System.Web.HttpApplication
    {

        public class TestServiceAppHost : AppHostBase
        {
            public TestServiceAppHost() : base("Test Service Stack Service", typeof(AuthenticateService).Assembly) { }

            public override void Configure(Funq.Container container)
            {
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            new TestServiceAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}