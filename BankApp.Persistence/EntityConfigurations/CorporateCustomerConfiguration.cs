using BankApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Persistence.EntityConfigurations;

public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
{
    public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
    {
        builder.ToTable("CorporateCustomers");

        builder.HasKey(cc => cc.Id);

        builder.Property(cc => cc.Id)
            .IsRequired();

        builder.Property(cc => cc.TaxNumber)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(cc => cc.CompanyName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(cc => cc.AuthorizedPersonName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(cc => cc.AuthorizedPersonIdentityNumber)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(cc => cc.TradeRegistryNumber)
            .HasMaxLength(50);

        builder.Property(cc => cc.EstablishmentDate);

        builder.Property(cc => cc.Sector)
            .HasMaxLength(100);

        builder.Property(cc => cc.AnnualRevenue)
            .HasColumnType("decimal(18,2)");

        builder.Property(cc => cc.EmployeeCount);

        builder.HasIndex(cc => cc.TaxNumber)
            .IsUnique();

        builder.HasIndex(cc => cc.CompanyName);

        builder.HasOne(cc => (Customer)cc)
            .WithOne()
            .HasForeignKey<CorporateCustomer>(cc => cc.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

