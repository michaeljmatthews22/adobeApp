using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdobeApp.Models
{
    [Table("Users")]
    public class Users
    {

        [Key]
        
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Notifications { get; set; }
        public bool Available { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Score { get; set; }
       
    }
}