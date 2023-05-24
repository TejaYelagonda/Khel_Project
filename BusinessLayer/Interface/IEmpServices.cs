using Shared.DTO;
using System.Collections.Generic;

namespace BusinessLayer.Interface
{
    public interface IEmpServices
    {
        public List<EmpDTO> GetEmp();
    }
}
