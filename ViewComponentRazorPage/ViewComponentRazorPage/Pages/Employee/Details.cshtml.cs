using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ViewComponentRazorPage.Models;

namespace ViewComponentRazorPage.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly ViewComponentRazorPage.Models.DatabaseContext _context;

        public DetailsModel(ViewComponentRazorPage.Models.DatabaseContext context)
        {
            _context = context;
        }

        public ViewComponentRazorPage.Models.Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees.FirstOrDefaultAsync(m => m.EmployeeId == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
