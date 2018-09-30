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
        List<SystemUser> systemUser;
        public List<SystemUser> DisplayedSystemUser { get; set; }
        public SystemUserModel()
        {
            systemUser = new List<SystemUser>()
            {
                new SystemUser {
                    SystemUserId = new Guid(),
                    Name = "Никита",
                    IsDisabled = false,
                    Login = "Nikita",
                    Password = "123",
                    PhoneNumber = "-",
                    Email = "-"
                },
                new SystemUser {
                    SystemUserId = new Guid(),
                    Name = "Давид",
                    IsDisabled = false,
                    Login = "David",
                    Password = "555",
                    PhoneNumber = "-",
                    Email = "-"
                },
                new SystemUser {
                    SystemUserId = new Guid(),
                    Name = "Дмитрий",
                    IsDisabled = true   ,
                    Login = "Dmitriy",
                    Password = "666",
                    PhoneNumber = "-",
                    Email = "-"
                },
            };
        }

        public void OnGet()
        {
            DisplayedSystemUser = systemUser;
        }
        public void OnGetByIsDisabled(bool isDisabled)
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