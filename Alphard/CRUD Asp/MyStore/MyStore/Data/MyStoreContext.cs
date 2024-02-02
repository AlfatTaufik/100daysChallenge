using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyStore.Models;

namespace MyStore.Data
{
    public class MyStoreContext : DbContext
    {
        public MyStoreContext (DbContextOptions<MyStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MyStore.Models.User> Users { get; set; } = default!;
    }
}
