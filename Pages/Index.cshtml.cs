using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Azure_App_Timm.Data;

namespace Azure_App_Timm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Azure_App_Timm.Data.AppDbContext _context;

        public IndexModel(Azure_App_Timm.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
