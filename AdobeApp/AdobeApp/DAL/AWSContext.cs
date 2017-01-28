using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdobeApp.Models;
using System.Data.Entity;


namespace AdobeApp.DAL
{
    public class AWSContext : DbContext
    {
        public AWSContext() : base("AWSContext")
        {

        }
        public DbSet<Users> Users_s { get; set; }
        public DbSet<Games> Games_s { get; set; }
    }
}
