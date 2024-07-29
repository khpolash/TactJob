using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace Tactsoft.Service.DbDependencies
{
    public static class ModelBuilderExtension
    {
        public static void DateTimeConvention(this ModelBuilder modelBuilder)
        {
            modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetProperties())
               .Where(p => p.ClrType == typeof(decimal)
                        || p.ClrType == typeof(decimal?))
               .ToList()
               .ForEach(p =>
               {
                   p.SetColumnType("datetime2");
               });
        }

        public static void DecimalConvention(this ModelBuilder modelBuilder)
        {
            modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal)
                         || p.ClrType == typeof(decimal?))
                .ToList()
                .ForEach(p =>
                {
                    if (p.GetPrecision() is null)
                        p.SetPrecision(18);
                    if (p.GetScale() is null)
                        p.SetScale(4);
                });
        }

        public static void RelationConvetion(this ModelBuilder modelBuilder)
        {
            modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetForeignKeys())
               //.Where(e => !e.IsOwnership && e.DeleteBehavior == DeleteBehavior.Cascade)
               .ToList()
               .ForEach(relationship => relationship.DeleteBehavior = DeleteBehavior.Restrict);
        }

    }

}
