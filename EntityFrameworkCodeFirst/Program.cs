using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connection = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            using (var context = new ClienteContext())
            {
                var quantidade_clientes = context.Clientes.Count();
                context.Clientes.Add(new Cliente() { Nome = "Agata2", Telefone = "15981712153", CPF = "48156290801" });
                context.Produtos.Add(new Produto() { Nome = "Camera 2x", Descricao = "Teste produto" });

                context.SaveChanges();
            }
        }
    }
}
