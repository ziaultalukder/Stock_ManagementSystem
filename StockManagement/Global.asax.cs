using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using StockeManagement.Models.Models;
using StockeManagement.Models.ViewModels;

namespace StockManagement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<StockCreateVM, StockIn>();
                cfg.CreateMap<StockIn, StockCreateVM>();
            });
        }
    }
}
