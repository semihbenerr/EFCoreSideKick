using EFCoreSideKick.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EFCoreSideKick.Api
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsUnicode(true);

            builder
                .Property(x => x.Surname)
                .HasColumnName("Surname")
                .IsUnicode(true);

            builder
                .Property(x => x.Salary)
                .HasColumnName("Salary")
                .HasPrecision(18, 2);

            builder
                .Property(x => x.Department)
                .HasColumnName("Department")
                .IsUnicode(true);

            builder
                .Property(x => x.Status)
                .HasColumnName("Status");

            builder
                .ToTable("Employee", "dbo");
        }
    }
}
