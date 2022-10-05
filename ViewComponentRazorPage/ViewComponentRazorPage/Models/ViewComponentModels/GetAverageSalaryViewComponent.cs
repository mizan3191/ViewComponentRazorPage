using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentRazorPage.Models.ViewComponentModels
{
    public class GetAverageSalaryViewComponent : ViewComponent
    {
        private readonly DatabaseContext _context;
        
        public GetAverageSalaryViewComponent(DatabaseContext context)
        {
            _context = context;
        }
        
        
        AverageSalary model = new AverageSalary();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AverageSalary = _context.Employees.Average(s => s.Salary);
            model.GetAverageSalary = Convert.ToInt32( AverageSalary);

            return View(model);
        }
    }
}
