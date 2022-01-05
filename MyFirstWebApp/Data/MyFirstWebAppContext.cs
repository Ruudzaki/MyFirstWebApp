using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Data
{
    public class MyFirstWebAppContext : DbContext
    {
        public MyFirstWebAppContext (DbContextOptions<MyFirstWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstWebApp.Models.Movie> Movie { get; set; }
    }
}
