using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CRUDProject5.Data
{
    public class UserLogin
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Rolename { get; set; }
        public string Token { get; set; }
    }
}
