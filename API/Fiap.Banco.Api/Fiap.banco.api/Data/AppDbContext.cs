namespace Fiap.banco.api.Data

{
using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Model.Banco> Bancos { get; set; }

        public DbSet<Model.Cliente> Clientes { get; set; }
        
        public DbSet<Model.Funcionario> Funcionarios { get; set; }
        
        public DbSet<Model.Agencia> Agencias { get; set; }
    }
}
