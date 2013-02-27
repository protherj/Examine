﻿using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Examine.LuceneEngine.Faceting;
using Examine.LuceneEngine.Providers;

namespace Examine.Web.Demo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            //This is how to create a config from code. This allows your own termfacetextractors to be used.

            //var searcher = ExamineManager.Instance.SearchProviderCollection["Simple2Searcher"];
            //((LuceneSearcher) searcher).FacetConfiguration = new FacetConfiguration
            //    { 
            //        FacetExtractors = new List<IFacetExtractor> {new TermFacetExtractor("Column1")}
            //    };
        }
    }
}