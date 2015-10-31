using Quiron.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();
       

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        //    modelBuilder.Entity<Produto>().ToTable("Produtos");
        //}



    }
}
