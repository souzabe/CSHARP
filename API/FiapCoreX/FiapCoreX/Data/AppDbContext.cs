using Microsoft.EntityFrameworkCore;
using FiapCoreX.Models;

namespace FiapCoreX.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
