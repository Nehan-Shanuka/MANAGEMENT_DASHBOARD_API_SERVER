using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Summary
{
    public class BasicKpi
    {
        public string KPI { get; set; }
        public double LAST_YEAR { get; set; }
        public double ACHIEVEMENT { get; set; }
        public int MONTH { get; set; }
    }
}