using Bogus;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using TesteFrenet.Api.Models;

namespace TesteFrenet.Api.Database
{

    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().Property(e => e.Salary).HasColumnType("decimal(10,2)");
            modelBuilder.Entity<Employee>().HasData(getEmployeeSeed());

            modelBuilder.Entity<Colors>().HasData(getColorSeed());
        }

        //Gera automaticamente uma lista de 20 cores
        private Colors[] getColorSeed()
        {
            var faker = new Faker<Colors>().RuleFor(c => c.Name, f => f.Commerce.Color());
            var colors = faker.Generate(20).ToArray();
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i].Id = i + 1;
            }

            return colors;
        }

        //Gera automaticamente uma lista de 20 funcionários
        private Employee[] getEmployeeSeed()
        {
            var faker = new Faker<Employee>()
                .RuleFor(e => e.FirstName, f => f.Person.FirstName)
                .RuleFor(e => e.LastName, f => f.Person.LastName)
                .RuleFor(e => e.Date, f => f.Date.Recent(365))
                .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
                .RuleFor(e => e.Salary, f => f.Random.Decimal(2000, 10000));

            var employees = faker.Generate(20).ToArray();
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Id = i + 1;
            }

            return employees;
        }

        public DbSet<Colors> Colors { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }


}
