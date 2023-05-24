using DataAccessLayer.Models;
using System.Linq;

namespace DataAccessLayer.Repositories.Interface
{
    public interface IEmpRepository
    {
        public IQueryable<EmpDetail> GetEmp();
    }
}
