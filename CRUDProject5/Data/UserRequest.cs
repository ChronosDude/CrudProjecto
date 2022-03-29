using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CRUDProject5.Data
{
    public partial class UserRequest
    {


        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int IdRole { get; set; }

        public string Rolename { get; set; }

    }
}
