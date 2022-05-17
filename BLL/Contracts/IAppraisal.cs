using Component;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    //Whatever we will write in this file, we will have to implement it
    /// <summary>
    /// This interface is responisble for dealing with business logic of methods
    /// </summary>
    public interface IAppraisal
    {
        Task<bool> Store(CodingExamXML model);
    }
}
