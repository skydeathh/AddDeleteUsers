using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Infrastructure.EF.Configs;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDeleteUsers.Infrastructure.EF.Contexts;

internal sealed class WriteDbContext : DbContext {
    public DbSet<User> Users { get; set; }

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.HasDefaultSchema("users");
        var configuration = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<User>(configuration);
    }
}