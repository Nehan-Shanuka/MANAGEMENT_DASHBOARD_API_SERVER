using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Configuration;
using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Branch_Ranking_Region_Wise;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Branch_Ranking_Region_Wise
{
    public class GENERAL_NMOTOR_PERF_RGBRMONTHController : ApiController
    {
        private readonly GENERAL_NMOTOR_PERF_RGBRMONTH_Repository _repository;

        public GENERAL_NMOTOR_PERF_RGBRMONTHController()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_NMOTOR_PERF_RGBRMONTH_Repository(connectionString);
        }

        // GET: GENERAL_NMOTOR_PERF_RGBRMONTH
        public IHttpActionResult Get(int month, string region)
        {
            try
            {
                var data = _repository.CallStoredProcedure(month, region);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}