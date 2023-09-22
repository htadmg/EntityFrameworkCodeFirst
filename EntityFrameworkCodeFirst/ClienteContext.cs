using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("name=conexao")
        {
        }
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Produto> Produtos { get; set; }
    }
}
