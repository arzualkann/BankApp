using BankApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Persistence.EntityConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.ToTable("IndividualCustomers");

        builder.HasKey(ic => ic.Id);

        builder.Property(ic => ic.Id)
            .IsRequired();

        builder.Property(ic => ic.IdentityNumber)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(ic => ic.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(ic => ic.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(ic => ic.MiddleName)
            .HasMaxLength(100);

        builder.Property(ic => ic.BirthDate)
            .IsRequired();

        builder.Property(ic => ic.Gender)
            .HasMaxLength(10);

        builder.Property(ic => ic.Occupation)
            .HasMaxLength(200);

        builder.Property(ic => ic.MonthlyIncome)
            .HasColumnType("decimal(18,2)");

        builder.HasIndex(ic => ic.IdentityNumber)
            .IsUnique();

        builder.HasOne(ic => (Customer)ic)
            .WithOne()
            .HasForeignKey<IndividualCustomer>(ic => ic.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

