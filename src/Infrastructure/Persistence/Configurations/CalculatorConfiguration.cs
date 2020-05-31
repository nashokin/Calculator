using Calculator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calculator.Infrastructure.Persistence.Configurations
{
    public class CalculatorConfiguration : IEntityTypeConfiguration<CalculatorResult>
    {
        public void Configure(EntityTypeBuilder<CalculatorResult> builder)
        {
            builder.Property(t => t.Num1)
                .IsRequired();

            builder.Property(t => t.Action)
                .IsRequired();

            builder.Property(t => t.Num2)
                .IsRequired();
        }
    }
}
