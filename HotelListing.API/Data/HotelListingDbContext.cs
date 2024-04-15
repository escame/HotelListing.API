using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

public class HotelListingDbContext : DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "India", ShortName = "IN" },
            new Country { Id = 2, Name = "United States", ShortName = "US" },
            new Country { Id = 3, Name = "United Kingdom", ShortName = "UK" }
        );
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Taj Mahal Palace",
                Address = "Apollo Bunder, Mumbai, Maharashtra, India",
                Rating = 3,
                CountryId = 1
            },
            new Hotel
            {
                Id = 2,
                Name = "The Oberoi Amarvilas",
                Address = "Taj East Gate Road, Agra, Uttar Pradesh, India",
                Rating = 5,
                CountryId = 1
            },
            new Hotel
            {
                Id = 3,
                Name = "The Ritz-Carlton",
                Address = "280 Vanderbilt Beach Road, Naples, Florida, United States",
                Rating = 4,
                CountryId = 2
            },
            new Hotel
            {
                Id = 4,
                Name = "The Langham",
                Address = "1C Portland Place, Regent Street, London, United Kingdom",
                Rating = 5,
                CountryId = 3
            }
        );
    }
}