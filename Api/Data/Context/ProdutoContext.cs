using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class ProdutoContext : DbContext
    {
        public DbSet<Produto> produtos { get; set; }
        public ProdutoContext() : base ("Data Source=192.168.0.186;Initial Catalog=Matheus;Persist Security Info=True;User ID=Matheus;Password=#matheus")
        {

        }
    }
}
