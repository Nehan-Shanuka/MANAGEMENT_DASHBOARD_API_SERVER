﻿using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Regional_Ranking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Regional_Ranking
{
    public class GENERAL_GENERAL_PERF_CMLTVController : ApiController
    {
        private readonly GENERAL_GENERAL_PERF_CMLTV_Repository _repository;

        public GENERAL_GENERAL_PERF_CMLTVController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_GENERAL_PERF_CMLTV_Repository(connectionString);
        }

        // GET: GENERAL_GENERAL_PERF_CMLTV
        public IHttpActionResult Get(int month)
        {
            try
            {
                // Call the repository method to get the data
                var data = _repository.CallStoredProcedure(month);

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