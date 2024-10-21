﻿using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Non_Motor_Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Report_Non_Motor_Summary
{
    public class GENERAL_NMOTOR_MONTH_SUMMARY_NController : ApiController
    {
        private readonly GENERAL_NMOTOR_MONTH_SUMMARY_N_Repository _repository;

        public GENERAL_NMOTOR_MONTH_SUMMARY_NController()
        {
            // Initialize the repository with the connection string to Oracle database
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            _repository = new GENERAL_NMOTOR_MONTH_SUMMARY_N_Repository(connectionString);
        }

        // GET: GENERAL_NMOTOR_MONTH_SUMMARY_N
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