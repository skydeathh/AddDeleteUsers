using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Infrastructure.EF.Configs;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDeleteUsers.Infrastructure.EF.Contexts;

internal sealed class ReadDbContext : DbContext {
    public DbSet<UserReadModel> User { get; set; }

    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.HasDefaultSchema("users");
        var configuration = new ReadConfiguration();
        modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
    }
}