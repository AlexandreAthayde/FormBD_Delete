namespace Login
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdventureWorksModel : DbContext
    {
        public AdventureWorksModel()
            : base("name=AdventureWorksModel")
        {
        }

        public virtual DbSet<Usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Senha)
                .IsUnicode(false);
        }
    }
}
