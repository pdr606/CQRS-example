using crqs.example.domain.Enties.CarContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.Infrastructure.Config.CarContext
{
    public class CarConfig : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ComplexProperty(x => x.Info);
        }
    }
}
