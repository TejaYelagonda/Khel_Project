using AutoMapper;
using BusinessLayer.Interface;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.Interface;
using Shared.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Implementation
{
    public class EmpServices:IEmpServices
    {
        private readonly IEmpRepository _emprepository;
        private readonly IMapper _mapper;
        public EmpServices(IEmpRepository emprepository, IMapper mapper)
        {
            _emprepository = emprepository;
            _mapper = mapper;
        }
        public List<EmpDTO> GetEmp()
        {
            IQueryable<EmpDetail> getEmpDetails = _emprepository.GetEmp();
            
            List<EmpDTO> mappedProjectData = _mapper.Map<List<EmpDTO>>(getEmpDetails);
            return mappedProjectData;
        }
    }
}
