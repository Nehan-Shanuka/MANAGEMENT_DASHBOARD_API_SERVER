﻿using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Channel
{
    public class GENERAL_CH_CONTRIBUT_CUMULATVController : ApiController
    {
        private readonly GENERAL_CH_CONTRIBUT_CUMULATV_Repository _repository;

        public GENERAL_CH_CONTRIBUT_CUMULATVController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_CH_CONTRIBUT_CUMULATV_Repository(connectionString);
        }

        // GET: GENERAL_CH_CONTRIBUT_CUMULATV
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