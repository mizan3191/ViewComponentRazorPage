using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentRazorPage.Models.ViewComponentModels
{
    public class EmployeeViewComponent : ViewComponent
    {
        private readonly DatabaseContext _context;
        public IList<Employee> Employees { get; set; }
        public EmployeeViewComponent(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Employees = await _context.Employees.ToListAsync();
            
            return View(Employees);
        }
    }
}
