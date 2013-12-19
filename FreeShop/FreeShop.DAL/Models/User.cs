using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeShop.DAL.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}