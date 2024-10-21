using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Annual_Ranking
{
    public class GeneralAnnualAward
    {
        public IList<GeneralAnnualAwardRankingRMData> RmList { get; set; }
        public IList<GeneralAnnualAwardRankingBMData> BmList { get; set; }
    }
}