﻿using System.Web;
using System.Web.Mvc;

namespace Asp_DotNet_MVC_WebApplication_Authorization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
