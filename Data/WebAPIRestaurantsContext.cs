using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIRestaurants.Models;

namespace WebAPIRestaurants.Data
{
    public class WebAPIRestaurantsContext : DbContext
    {
        public WebAPIRestaurantsContext (DbContextOptions<WebAPIRestaurantsContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIRestaurants.Models.Restaurant> Restaurant { get; set; }
    }
}
