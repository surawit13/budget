using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnetcore.Models;

namespace dotnetcore.Dbcon
{
    public class Dbcon : DbContext
    {
        public Dbcon (DbContextOptions<Dbcon> options)
            : base(options)
        {
        }

        public DbSet<dotnetcore.Models.User> User { get; set; }
    }
}