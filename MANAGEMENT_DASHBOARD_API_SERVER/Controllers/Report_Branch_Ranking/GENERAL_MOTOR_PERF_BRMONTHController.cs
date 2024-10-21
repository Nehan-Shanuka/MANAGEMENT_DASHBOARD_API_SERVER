using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Branch_Ranking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Branch_Ranking
{
    public class GENERAL_MOTOR_PERF_BRMONTHController : ApiController
    {
        private readonly GENERAL_MOTOR_PERF_BRMONTH_Repository _repository;

        public GENERAL_MOTOR_PERF_BRMONTHController()
        {
            // Initialize the repository with a connection string to your Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_MOTOR_PERF_BRMONTH_Repository(connectionString);
        }

        // GET: GENERAL_MOTOR_PERF_BRMONTH
        public IHttpActionResult Get([FromUri] int month)
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