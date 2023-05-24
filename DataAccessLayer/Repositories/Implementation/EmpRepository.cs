using DataAccessLayer.Models;
using DataAccessLayer.Repositories.Interface;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation
{
    public class EmpRepository:IEmpRepository
    {
        ADO_DBContext _dbcontext;
        public EmpRepository(ADO_DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IQueryable<EmpDetail> GetEmp()
        {
            return _dbcontext.EmpDetails;
        }
    }
}
