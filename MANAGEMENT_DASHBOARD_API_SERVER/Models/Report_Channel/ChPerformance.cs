using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Channel
{
    public class ChPerformance
    {
        public string SALES_DEPARTMENT { get; set; }
        public double LAST_YAER { get; set; }
        public double TARGET { get; set; }
        public double ACHIEVEMENT { get; set; }
        public double ACH_PRESENTAGE { get; set; }
        public double GROWTH_PRESENTAGE { get; set; }
        public double CONTRIBUTION { get; set; }
    }
}