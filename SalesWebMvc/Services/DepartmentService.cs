using System.Linq;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        //Declaração de dependência
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
