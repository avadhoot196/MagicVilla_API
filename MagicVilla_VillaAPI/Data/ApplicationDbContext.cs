using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This is from kolhapur",
                    ImageUrl = "https://th.bing.com/th/id/OIP.xAlHEJRN3_QBNjlXnWz6vQHaFk?pid=ImgDet&rs=1",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate= DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Shalini Villa",
                    Details = "This is from Rankala",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IopqFsMD05QQh--oxuEi1AHaE2?pid=ImgDet&w=900&h=590&rs=1",
                    Occupancy = 6,
                    Rate = 250,
                    Sqft = 600,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Panhala",
                    Details = "This is from Panhala",
                    ImageUrl = "https://th.bing.com/th/id/OIP.6vWSTZBMNqQ1Ew-qLDqowwHaFj?pid=ImgDet&rs=1",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
