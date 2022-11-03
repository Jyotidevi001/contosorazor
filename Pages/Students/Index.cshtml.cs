using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using contosorazor.Data;
using contosorazor.models;

namespace contosorazor.Pages.Students_folder
{
    public class IndexModel : PageModel
    {
        private readonly contosorazor.Data.contosorazorContext _context;

        public IndexModel(contosorazor.Data.contosorazorContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
