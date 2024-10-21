﻿using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.FireApp_Regional_Class_Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.FireApp_Regional_Class_Summary
{
    public class GenNonMotorClassBranchWiseRMController : ApiController
    {
        private readonly GenNonMotorClassBranchWiseRM_Repository _repository;

        public GenNonMotorClassBranchWiseRMController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GenNonMotorClassBranchWiseRM_Repository(connectionString);
        }

        // GET: GenNonMotorClassBranchWiseRM
        public IHttpActionResult Get(string year, string month, string region)
        {
            try
            {
                // Call the repository method to get the data
                var data = _repository.CallStoredProcedure(year, month, region);

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