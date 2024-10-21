using Dapper;
using MANAGEMENT_DASHBOARD_API_SERVER.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Repositories.FireApp_RM_Detail
{
    public class GetGeneralListRMBM_Repository
    {
        private readonly string _connectionString;

        public GetGeneralListRMBM_Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<GeneralRmBmDetail> CallStoredProcedure(string type)
        {
            using (var conn = new OracleConnection(_connectionString))
            {
                // Query to retrieve data from the table
                string query = @"SELECT ROW_ID, BRANCH_CODE, BRANCH_NAME, REGION, EPF, STATUS, NAME, MOBILE, TYP 
                             FROM SLIC_AGENT.MGT_DASHBOARD_RMBM WHERE TYP = :TYP";

                // Use Dapper to execute the query and map the result to the BranchDetails model
                IEnumerable<GeneralRmBmDetail> result = conn.Query<GeneralRmBmDetail>(query, new { TYP = type });

                foreach (GeneralRmBmDetail manager in result)
                {
                    manager.FULL_NAME = manager.STATUS + manager.NAME;
                }

                return result;
            }
        }
    }
}