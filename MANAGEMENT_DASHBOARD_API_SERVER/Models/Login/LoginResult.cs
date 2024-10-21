using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Login
{
	public class LoginResult
	{
        public string ACCESS_TOKEN { get; set; }
        public string USERNAME { get; set; }
        public int CATOGERY { get; set; }
    }
}