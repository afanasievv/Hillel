using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VolunteerHeadquarters.Models;

namespace DataLibrary.DataAccess
{
    public class VolunteerHeadquatersDbContext : DbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<MilitaryUnit> MilitaryUnits { get; set; }
        public DbSet<Request> Requests { get; set; }

        public VolunteerHeadquatersDbContext(DbContextOptions<VolunteerHeadquatersDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Виконати налаштування моделей даних (таблиць) та їх зв'язків, якщо потрібно
        }
    }
}
