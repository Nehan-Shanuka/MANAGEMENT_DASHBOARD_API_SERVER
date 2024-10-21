using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Login
{
    public class User
    {
        public int USER_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string NAME { get; set; }
        public string CONTACT_NO { get; set; }
        public int CATOGERY { get; set; }
        //public string CREATED_AT { get; set; }
        //public string UPDATED_AT { get; set; }
    }
}