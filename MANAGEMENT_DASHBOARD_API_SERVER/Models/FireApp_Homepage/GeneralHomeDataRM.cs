using MANAGEMENT_DASHBOARD_API_SERVER.Models.FireApp_Regional_Due_Summary;
using MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.FireApp_Homepage
{
    public class GeneralHomeDataRM
    {
        public IList<GeneralRegionalSummary> RegionalSummaryList { get; set; }
        public IList<GeneralKpi> RegionalKpiList { get; set; }
        public IList<GeneralAmpDataRM> RegionalAmpList { get; set; }
        public IList<GeneralNewRecruitmentRM> RegionalNewRecList { get; set; }
        public GenTarAchChartCumuData AchievementCumulative { get; set; }
    }
}