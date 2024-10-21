using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Branch_Ranking_Region_Wise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Configuration;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Branch_Ranking_Region_Wise
{
    public class GENERAL_NMOTOR_PERF_RGBRCMLTVController : ApiController
    {
        private readonly GENERAL_NMOTOR_PERF_RGBRCMLTV_Repository _repository;

        public GENERAL_NMOTOR_PERF_RGBRCMLTVController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_NMOTOR_PERF_RGBRCMLTV_Repository(connectionString);
        }

        // GET: GENERAL_NMOTOR_PERF_RGBRCMLTV
        public IHttpActionResult Get(int month, string region)
        {
            try
            {
                // Call the repository method to get the data
                var data = _repository.CallStoredProcedure(month, region);

                // Return the data as a JSON response
                return Ok(data);
            }
            catch (Exception ex)
            {
                // Log the error (implement logging as needed) and return a 500 Internal Server Error response
                return InternalServerError(ex);
            }
        }
    }
}