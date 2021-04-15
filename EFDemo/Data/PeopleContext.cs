using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Address> Address { get; set; }
        public DbSet<Person> Person { get; set; }
    }

}
