
namespace V2.Data
{
    using Microsoft.EntityFrameworkCore;
    using V2.Models;

    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// DbSet de la entidad Automoviles
        /// </summary>
        public DbSet<Automoviles> Automoviles { get; set; }


        /// <summary>
        /// DbSet de la entidad Marcas
        /// </summary>
        public DbSet<Marcas> Marcas { get; set; }
    }

}
