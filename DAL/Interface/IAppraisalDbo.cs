using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interface
{
    /// <summary>
    /// All CRUD related to Appraisal will be added here first and then will be implemented in web services
    /// </summary>
    public interface IAppraisalDbo
    {
        Task<bool> Store(Appraisal appraisal);
       
    }
}
