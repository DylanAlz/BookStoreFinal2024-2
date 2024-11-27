using ApilibrosFinal2024_2.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApilibrosFinal2024_2.Dal
{
    public class DataBaseContext : DbContext
    {
        //por medio de este constructor me conecto a la BD
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        //Este metodo me sirve para configurar unos indices de cada campo en una tabla en BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().HasIndex(L => L.titulo).IsUnique();
            modelBuilder.Entity<Categoria>().HasIndex("Nombre_cat", "LibroId").IsUnique();
        }

        #region
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        #endregion
    }
}
