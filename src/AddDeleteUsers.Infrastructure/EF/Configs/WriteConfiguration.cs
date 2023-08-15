using AddDeleteUsers.Domain.Consts;
using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddDeleteUsers.Infrastructure.EF.Configs;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<User> {
    public void Configure(EntityTypeBuilder<User> builder) {
        builder.HasKey(u => u.Id);

        var nameConvertor = new ValueConverter<UserName, string>(un => un.ToString(),
            un => new UserName(un));

        var surnameConvertor = new ValueConverter<UserSurname, string>(sn => sn.ToString(),
            sn => new UserSurname(sn));

        builder
            .Property(u => u.Id)
            .HasConversion(id => id.Id, id => new Domain.ValueObjects.UserId(id));

        builder
            .Property(typeof(UserName), "_userName")
            .HasConversion(nameConvertor)
            .HasColumnName("Name");

        builder
            .Property(typeof(UserSurname), "_userSurname")
            .HasConversion(nameConvertor)
            .HasColumnName("Surname");

        builder.ToTable("Users");
    }
}