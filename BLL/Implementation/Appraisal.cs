using BLL.Contracts;
using Component;
using DAL.Interface;
using System.Threading.Tasks;

namespace BLL.Implementation
{
    /// <summary>
    /// Implements business Business logic layer interfaces
    /// </summary>
    public class Appraisal : IAppraisal
    {
        private readonly IAppraisalDbo _bllAppraisal;

        public Appraisal(IAppraisalDbo bllAppraisal)
        {
            _bllAppraisal = bllAppraisal;
        }
        /// <summary>
        /// Converts outer world models into database models and does any other working if required.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<bool> Store(CodingExamXML model)
        {
            DAL.Entities.Appraisal entity = new DAL.Entities.Appraisal
            {
                AppraisalID = model.OrderID,
                BranchId = model.BranchId,
                AppraisalCheck = model.AppraisalCheck,
                AppraisalTimeRequest = model.AppraisalTimeRequest,
                EntryContactName = model.EntryContactName,
                EntryContactPhone = model.EntryContactPhone,
                LenderLoanNumber = model.LenderLoanNumber,
                LoanType = model.LoanType,
                PropertyAddress = model.PropertyAddress,
                PropertyInfo = model.PropertyInfo,
                PropertyZip = model.PropertyZip,
                RepresentativeId = model.UserId
            };
            return _bllAppraisal.Store(entity);
        }
    }
}
