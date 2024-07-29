using Microsoft.EntityFrameworkCore;
using Tactsoft.Core.Entities;

namespace Tactsoft.Data.DbDependencies
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                CountryName = "Bangladesh",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<District>().HasData(new District
            {
                Id = 1,
                DistrictName = "Barisal",
                CountryId = 1,
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            }) ;
            modelBuilder.Entity<Thana>().HasData(new Thana
            {
                Id = 1,
                ThanaName = "Porijpuer",
                DistrictId = 1,
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
           
            modelBuilder.Entity<Relative>().HasData(new Relative
            {
                Id = 1,
                RelativeName = "Techer",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<Reading>().HasData(new Reading
            {
                Id = 1,
                ReadingName = "Bangla",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<Writing>().HasData(new Writing
            {
                Id = 1,
                WritingName = "Bangla",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<Speaking>().HasData(new Speaking
            {
                Id = 1,
                SpeakingName = "Bangla",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<IndustryType>().HasData(new IndustryType
            {
                Id = 1,
                IndustryTypeName = "Devlopment",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });

            modelBuilder.Entity<CompanySize>().HasData(new CompanySize
            {
                Id = 1,
                CompanyTotalSize = "10 too 100",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory
            {
                Id = 1,
                JobCategoryeName = "IT",
                JobCategoryeLogo="",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<ResumeReceivingOption>().HasData(new ResumeReceivingOption
            {
                Id = 1,
                ResumeOption = "Apply Online",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<ServiceType>().HasData(new ServiceType
            {
                Id = 1,
                ServiceTypeName = "Stand-out Listing",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });
            modelBuilder.Entity<OrganizationType>().HasData(new OrganizationType
            {
                Id = 1,
                OrganizationName = "Government",
                CreatedBy = 1,
                CreatedDateUtc = DateTime.ParseExact("2023-02-01", "yyyy-MM-dd", null)
            });

        }

    }
}
