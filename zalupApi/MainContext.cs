﻿using Microsoft.EntityFrameworkCore;
using zalupApi.Models;

namespace zalupApi
{
    public class MainContext : DbContext
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=zalupa;Username=postgres;Password=home";
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<CabinetType> CabinetTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher_Subject> Teacher_Subjects { get; set; }
        public MainContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality[]
                {
                    new Speciality{Id = 1, Name="09.02.07"},
                    new Speciality{Id = 2, Name="09.02.01"},
                    new Speciality{Id = 3, Name="09.02.06"},
                    new Speciality{Id = 4, Name="09.02.07"},
                    new Speciality{Id = 5, Name="10.02.05"},
                    new Speciality{Id = 6, Name="13.02.11"},
                    new Speciality{Id = 7, Name="15.02.14"},
                    new Speciality{Id = 8, Name="15.01.17"},
                    new Speciality{Id = 9, Name="08.01.18"},
                    new Speciality{Id = 10, Name="15.01.31"},
                });
        }
    }
}
