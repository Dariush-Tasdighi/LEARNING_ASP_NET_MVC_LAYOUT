﻿using System.Linq;
//using System.Data.Entity;

namespace LEARNING_LAYOUTS
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public MvcApplication() : base()
		{
		}

		protected void Application_Start()
		{
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
		}
	}
}