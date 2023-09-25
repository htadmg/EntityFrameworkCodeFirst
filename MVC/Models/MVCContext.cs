using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MVCContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}