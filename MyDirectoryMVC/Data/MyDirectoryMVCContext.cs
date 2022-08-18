using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyDirectoryMVC.Models;

namespace MyDirectoryMVC.Data
{
    public class MyDirectoryMVCContext : DbContext
    {
        public MyDirectoryMVCContext (DbContextOptions<MyDirectoryMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyDirectoryMVC.Models.Contact> Contact { get; set; } = default!;
    }
}
