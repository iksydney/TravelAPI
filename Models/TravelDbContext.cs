using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options)
        {}
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelReview> HotelReviews { get; set; }
        public DbSet<Restaurant> Restaurants{ get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
    }
}
