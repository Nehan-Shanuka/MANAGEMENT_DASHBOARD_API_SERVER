using MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Annual_Ranking;
using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Annual_Ranking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Annual_Ranking
{
    public class GeneralAnnualRankingController : ApiController
    {
        private readonly GeneralAnnualRanking_Repository _repository;

        public GeneralAnnualRankingController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GeneralAnnualRanking_Repository(connectionString);
        }

        // GET: GeneralAnnualRanking
        public IHttpActionResult Get()
        {
            try
            {
                GeneralAnnualAward data = new GeneralAnnualAward
                {
                    // Call the repository method to get the data
                    RmList = _repository.CallStoredProcedureRMRankingData(),
                    BmList = _repository.CallStoredProcedureBMRankingData()
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