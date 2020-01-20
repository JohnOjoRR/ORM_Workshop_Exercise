using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ORM_Workshop_Exercise.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;

namespace ORM_Workshop_Exercise.DAL
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base (options)//base("name=HospitalConnectionString")
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Illness> Illness { get; set; }
    }
}
