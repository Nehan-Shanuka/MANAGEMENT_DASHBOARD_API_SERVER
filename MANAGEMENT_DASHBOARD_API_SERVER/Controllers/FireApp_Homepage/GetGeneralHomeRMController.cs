using MANAGEMENT_DASHBOARD_API_SERVER.Models.FireApp_Homepage;
using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.FireApp_Homepage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.FireApp_Homepage
{
    public class GetGeneralHomeRMController : ApiController
    {
        private readonly GetGeneralHomeRM_Repository _repository;

        public GetGeneralHomeRMController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GetGeneralHomeRM_Repository(connectionString);
        }

        // GET: GetGeneralHomeRM
        public IHttpActionResult Get(string year, string month, string region, string category)
        {
            try
            {
                GeneralHomeDataRM data = new GeneralHomeDataRM
                {
                    // Call the repository method to get the data
                    RegionalSummaryList = _repository.CallStoredProcedureMotorRegionalSummary(year, month, region),
                    RegionalKpiList = _repository.CallStoredProcedureGetKpiMonthRMData(month, region),
                    RegionalAmpList = _repository.CallStoredProcedureGetAmpRMData(region, category),
                    RegionalNewRecList = _repository.CallStoredProcedureGeneralNewRecruitmentRM(month, region),
                    AchievementCumulative = _repository.CallStoredProcedureGeneralTarAchRMData(region)
                };

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