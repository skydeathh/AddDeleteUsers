using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Infrastructure.EF.Configs;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDeleteUsers.Infrastructure.EF;

internal sealed class WriteDbContext : DbContext {
    public DbSet<User> User { get; set; }

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.HasDefaultSchema("users");
        var configuration = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<User>(configuration);
    }
}