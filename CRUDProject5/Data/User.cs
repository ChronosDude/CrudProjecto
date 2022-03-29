using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CRUDProject5.Data
{
    public  class User
    {
        


        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
    }
}
