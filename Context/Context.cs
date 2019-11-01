using AppTeste.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTeste.Context
{
    public class Context:DbContext
    {

        public DbSet<Person> Person { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            var isCreated = Database.EnsureCreated();

            Console.WriteLine($"Database was Created ? {isCreated}");
        }

    }
}
