using Microsoft.EntityFrameworkCore;
using RestaurantsApi.Model;
using System.Collections.Generic;

namespace RestaurantsApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<FavoriteRestaurant> FavoriteRestaurants { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Only used during migrations
                optionsBuilder.UseNpgsql("Host=dpg-d084rvvdiees738thoe0-a.oregon-postgres.render.com;Port=5432;Database=my_restaurant_db_3ewt;Username=my_restaurant_db_3ewt_user;Password=VVMS5vBzRTErm9UkpsqvCwObMsUuq9xD;SSL Mode=Require;Trust Server Certificate=true;");

            }
        }
    }
}
