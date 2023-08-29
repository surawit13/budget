using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnetcore.Models;

namespace dotnetcore.Dbcon
{
    public class Dbconnect : DbContext
    {
        public Dbconnect (DbContextOptions<Dbconnect> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}