using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestTaxoLog.Models;

namespace TestTaxoLog.Pages
{
    public class SystemUserModel : PageModel
    {
        private readonly ApplicationContext _context;

        public List<SystemUser> systemUser;
        public List<SystemUser> DisplayedSystemUser { get; set; }
        public SystemUserModel(ApplicationContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            systemUser = _context.SystemUser.ToList();
        }
        public void OnPostAll()
        {
            DisplayedSystemUser = systemUser;
        }
        public void OnPostIsDisabled(bool isDisabled)
        {
            DisplayedSystemUser = systemUser.Where(su => su.IsDisabled == isDisabled).ToList();
        }

        public void OnPostName(string name)
        {
            DisplayedSystemUser = systemUser.Where(su => su.Name.Contains(name)).ToList();
        }
        public void OnPostLogin(string login)
        {
            DisplayedSystemUser = systemUser.Where(su => su.Login == login).ToList();
        }

    }
}