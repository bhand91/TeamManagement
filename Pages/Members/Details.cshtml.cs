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
    public class DetailsModel : PageModel
    {
        private readonly TeamManagement.Models.TeamManagementContext _context;

        public DetailsModel(TeamManagement.Models.TeamManagementContext context)
        {
            _context = context;
        }

        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Members.Include(tm => tm.TaskMembers).ThenInclude(t => t.Task).AsNoTracking().FirstOrDefaultAsync(m => m.MemberID == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
