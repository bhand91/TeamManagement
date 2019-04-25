using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamManagement.Models;

namespace TeamManagement.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly TeamManagement.Models.TeamManagementContext _context;

        public IndexModel(TeamManagement.Models.TeamManagementContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        /* 
        public async Task OnGetAsync()
        {
            Member = await _context.Members.ToListAsync();
        }
        */
    }
}
