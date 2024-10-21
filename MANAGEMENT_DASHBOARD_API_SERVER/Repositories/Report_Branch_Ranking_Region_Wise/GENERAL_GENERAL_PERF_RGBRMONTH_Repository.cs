using Dapper;
using Dapper.Oracle;
using MANAGEMENT_DASHBOARD_API_SERVER.Models.Report_Region_Branch_Ranking;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Report_Branch_Ranking_Region_Wise
{
    public class GENERAL_GENERAL_PERF_RGBRMONTH_Repository
    {
        private readonly string _connectionString;

        public GENERAL_GENERAL_PERF_RGBRMONTH_Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<GeneralBranchPerformance> CallStoredProcedure(int month, string region)
        {
            using (var conn = new OracleConnection(_connectionString))
            {
                // Define the input and output parameters
                var parameters = new OracleDynamicParameters();
                parameters.Add("p_recordset", dbType: OracleMappingType.RefCursor, direction: ParameterDirection.Output);
                parameters.Add("p_month", month, OracleMappingType.Int32, ParameterDirection.Input);
                parameters.Add("p_region", region, OracleMappingType.Varchar2, ParameterDirection.Input);

                // Execute the stored procedure and map the result to the MotorPerformanceData model
                var result = conn.Query<GeneralBranchPerformance>(
                    "SLIC_AGENT.GENERAL_GENERAL_PERF_RGBRMONTH",
                    parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}