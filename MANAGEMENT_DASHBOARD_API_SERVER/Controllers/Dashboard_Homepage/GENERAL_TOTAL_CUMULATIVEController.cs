using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Dashboard_Homepage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Dashboard_Homepage
{
    public class GENERAL_TOTAL_CUMULATIVEController : ApiController
    {
        private readonly GENERAL_TOTAL_CUMULATIVE_Repository _repository;

        public GENERAL_TOTAL_CUMULATIVEController()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_TOTAL_CUMULATIVE_Repository(connectionString);
        }

        // GET: GENERAL_TOTAL_CUMULATIVE
        public IHttpActionResult Get(int month)
        {
            var result = _repository.CallStoredProcedure(month);
            return Ok(result);
        }
    }
}