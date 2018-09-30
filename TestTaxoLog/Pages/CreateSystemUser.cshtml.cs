using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestTaxoLog.Models;

namespace TestTaxoLog.Pages
{
    public class CreateSystemUserModel : PageModel
    {
        private readonly ApplicationContext _context;
        [BindProperty]
        public SystemUser systemUser { get; set; }

        public CreateSystemUserModel(ApplicationContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                systemUser.IsDisabled = false;
                systemUser.SystemUserId = new Guid();
                _context.SystemUser.Add(systemUser);
                await _context.SaveChangesAsync();
                return RedirectToPage("SystemUser");
            }
            return Page();
        }
    }
}