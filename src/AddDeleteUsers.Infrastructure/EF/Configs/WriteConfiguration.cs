using AddDeleteUsers.Domain.Consts;
using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace AddDeleteUsers.Infrastructure.EF.Configs;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<User> {
    public void Configure(EntityTypeBuilder<User> builder) {
        builder.HasKey(u => u.Id);

        var nameConvertor = new ValueConverter<UserName, string>(un => un.Name,
            un => new UserName(un));

        var surnameConvertor = new ValueConverter<UserSurname, string>(sn => sn.Surname,
            sn => new UserSurname(sn));

        var genderConvertor = new ValueConverter<Gender, string>(g => g.ToString(),
            g => (Gender)Enum.Parse(typeof(Gender), g));

        builder
            .Property(u => u.Id)
            .HasConversion(id => id.Id, id => new Domain.ValueObjects.UserId(id));

        builder
            .Property(typeof(UserName), "_userName")
            .HasConversion(nameConvertor)
            .HasColumnName("Name");

        builder
            .Property(typeof(UserSurname), "_userSurname")
            .HasConversion(surnameConvertor)
            .HasColumnName("Surname");

        builder.Property(typeof(Gender), "_gender")
          .HasConversion(genderConvertor)
          .HasColumnName("Gender");


        builder.ToTable("Users");
    }
}