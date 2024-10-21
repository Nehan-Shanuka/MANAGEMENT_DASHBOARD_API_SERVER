using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Region_Branch_Ranking
{
    public class GeneralBranchPerformance
    {
        public int RANK { get; set; }
        public string BRANCH_NAME { get; set; }
        public double LAST_YEAR { get; set; }
        public double ACHIEVEMENT { get; set; }
        public double TARGET { get; set; }
        public double ACH_PRESENTAGE { get; set; }
        public double GROWTH_PRESENTAGE { get; set; }
    }
}