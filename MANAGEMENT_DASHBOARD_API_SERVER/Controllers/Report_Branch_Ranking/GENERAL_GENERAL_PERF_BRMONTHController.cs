using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Branch_Ranking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Branch_Ranking
{
    public class GENERAL_GENERAL_PERF_BRMONTHController : ApiController
    {
        private readonly GENERAL_GENERAL_PERF_BRMONTH_Repository _repository;

        public GENERAL_GENERAL_PERF_BRMONTHController()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_GENERAL_PERF_BRMONTH_Repository(connectionString);
        }

        // GET: GENERAL_GENERAL_PERF_BRMONTH
        public IHttpActionResult Get(int month)
        {
            try
            {
                var performanceData = _repository.CallStoredProcedure(month);
                return Ok(performanceData);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}