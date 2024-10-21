using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Branch_Ranking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Branch_Ranking
{
    public class GENERAL_NMOTOR_PERF_BRCMLTVController : ApiController
    {
        private readonly GENERAL_NMOTOR_PERF_BRCMLTV_Repository _repository;

        public GENERAL_NMOTOR_PERF_BRCMLTVController()
        {
            // Initialize the repository with a connection string to your Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_NMOTOR_PERF_BRCMLTV_Repository(connectionString);
        }

        // GET: GENERAL_NMOTOR_PERF_BRCMLTV
        public IHttpActionResult Get(int month)
        {
            try
            {
                // Call the repository method to get the motor performance data
                var performanceData = _repository.CallStoredProcedure(month);

                // Return the data as a JSON response
                return Ok(performanceData);
            }
            catch (Exception ex)
            {
                // Log the error (implement logging as needed) and return a 500 Internal Server Error response
                return InternalServerError(ex);
            }
        }
    }
}