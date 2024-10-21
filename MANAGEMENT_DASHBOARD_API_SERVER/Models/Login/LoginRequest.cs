using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Login
{
    public class LoginRequest
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
    }
}