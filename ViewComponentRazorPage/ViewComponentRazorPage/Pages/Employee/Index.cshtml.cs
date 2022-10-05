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
    public class IndexModel : PageModel
    {
        private readonly ViewComponentRazorPage.Models.DatabaseContext _context;

        public IndexModel(ViewComponentRazorPage.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<ViewComponentRazorPage.Models.Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
