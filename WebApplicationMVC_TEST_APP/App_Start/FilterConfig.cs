﻿using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC_TEST_APP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
