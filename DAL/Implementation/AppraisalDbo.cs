using DAL.Entities;
using DAL.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    /// <summary>
    /// Class deals with all operation related to Appraisal Entity
    /// </summary>
    public class AppraisalDbo : IAppraisalDbo
    {
        private readonly IDbConnection Db;

        public AppraisalDbo(IConfiguration configuration)
        {
            //Reads Connection string from settings file
            Db = new SqlConnection(configuration.GetSection("Connectionstring").Value);
        }
        /// <summary>
        /// Saves Appraisal Data into database
        /// </summary>
        /// <param name="appraisal"></param>
        /// <returns>boolean value indicating true in case of successful operation</returns>
        public async Task<bool> Store(Appraisal appraisal)
        {

            int result = await Db.ExecuteAsync("insert into Appraisal(Appraisalid,RepresentativeId,BranchId,PropertyAddress,PropertyZip," +
                "EntryContactName,PropertyInfo,LoanType,LenderLoanNumber,AppraisalCheck,AppraisalTimeRequest,EntryContactPhone)",
                new
                {
                    appraisal.AppraisalID,
                    appraisal.RepresentativeId,
                    appraisal.BranchId,
                    appraisal.PropertyAddress,
                    appraisal.PropertyZip,
                    appraisal.EntryContactName,
                    appraisal.PropertyInfo,
                    appraisal.LoanType,
                    appraisal.LenderLoanNumber,
                    appraisal.AppraisalCheck,
                    appraisal.AppraisalTimeRequest,
                    appraisal.EntryContactPhone
                }
                );
            //returns true
            return result > 0 ? true : false;
        }
    }
}
