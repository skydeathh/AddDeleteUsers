using System;
using System.Data;
using AddDeleteUsers.Domain.Consts;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AddDeleteUsers.Infrastructure.EF.Configs;

internal sealed class ReadConfiguration :  IEntityTypeConfiguration<UserReadModel> {
    public void Configure(EntityTypeBuilder<UserReadModel> builder) {
        builder.ToTable("Users");
        builder.HasKey(u => u.Id);
    }
}