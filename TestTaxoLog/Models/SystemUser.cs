using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaxoLog.Models
{
    public class SystemUser
    {
        public Guid SystemUserId { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
