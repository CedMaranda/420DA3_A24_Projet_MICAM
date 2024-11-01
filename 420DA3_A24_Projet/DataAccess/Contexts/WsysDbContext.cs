using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class WsysDbContext : DbContext {

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseSqlServer("") // TODO: ajouteer stringue de connectshion
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);


        // TODO: @WHOLE_TEAM configurez vos entités ici

    }

}
