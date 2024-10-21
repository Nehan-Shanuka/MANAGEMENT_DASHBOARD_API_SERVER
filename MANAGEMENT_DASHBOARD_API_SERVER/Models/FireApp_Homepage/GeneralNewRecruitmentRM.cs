using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.FireApp_Homepage
{
    public class GeneralNewRecruitmentRM
    {
        public string REGION { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int NEW_RECRUIT_COUNT { get; set; }
    }
}