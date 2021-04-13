using Microsoft.EntityFrameworkCore;


namespace CrudProduto.Models
{
    public class ProdutoContexto : DbContext    
    {
        public ProdutoContexto(DbContextOptions<ProdutoContexto> options):base(options)
        {
    }
    public DbSet<Produto> Produtos {get; set;}
    }
}