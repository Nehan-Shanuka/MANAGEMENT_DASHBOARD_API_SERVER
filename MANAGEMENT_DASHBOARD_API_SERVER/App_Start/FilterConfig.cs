﻿using System.Web;
using System.Web.Mvc;

namespace MANAGEMENT_DASHBOARD_API_SERVER
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
