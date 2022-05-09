
using Project_5S.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5S.Data.Context
{
    public class Project_5SContext : DbContext
    {
        public Project_5SContext(DbContextOptions options) : base(options)
        {

        }

        #region DbSet
  
        public DbSet<Filiale> Filiale { get; set; }
        public DbSet<Pole> Pole { get; set; }
        public DbSet<FilLocal> FilLocal { get; set; }
        public DbSet<Normes> Normes { get; set; }
        public DbSet<notation> notation { get; set; }
        public DbSet<plan_action> plan_action { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<criteres> criteres { get; set; }



        #endregion

        #region Setting
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Settings: set Primary keys
            modelBuilder.Entity<criteres>().HasKey(c => c.critereId);
            // modelBuilder.Entity<SaisieComment>().HasKey(c => c.Id);
            modelBuilder.Entity<Filiale>().HasKey(c => c.FilialId);
            modelBuilder.Entity<FilLocal>().HasKey(c => c.LocallId);
            modelBuilder.Entity<notation>().HasKey(c => c.Id);
            modelBuilder.Entity<criteres>().HasKey(c => c.critereId);
            modelBuilder.Entity<Pole>().HasKey(c => c.PoleId);
            modelBuilder.Entity<Users>().HasKey(c => c.userId);
            modelBuilder.Entity<Normes>().HasKey(c => c.normeId);
            modelBuilder.Entity<plan_action>().HasKey(c => c.planId);


            #endregion


            #region Settings: set one to many relations

            modelBuilder.Entity<criteres>()
                  .HasOne(e => e.Normes)
                  .WithMany(i => i.criteress)
                  .HasForeignKey(d => d.NormeId);

            modelBuilder.Entity<Filiale>()
                  .HasOne(e => e.pole)
                  .WithMany(i => i.Filiales)
                  .HasForeignKey(d => d.poleId);

            modelBuilder.Entity<FilLocal>()
                  .HasOne(e => e.Filiale)
                  .WithMany(i => i.FilLocals)
                  .HasForeignKey(d => d.Filialeid);

            modelBuilder.Entity<notation>()
                 .HasOne(e => e.FilLocal)
                 .WithMany(i => i.notations)
                 .HasForeignKey(d => d.FilLocalid);

            modelBuilder.Entity<notation>()
               .HasOne(e => e.criteres)
               .WithMany(i => i.notations)
               .HasForeignKey(d => d.critereid);

            modelBuilder.Entity<notation>()
               .HasOne(e => e.User)
               .WithMany(i => i.notations)
               .HasForeignKey(d => d.Userid);

            modelBuilder.Entity<plan_action>()
               .HasOne(e => e.notation)
               .WithMany(i => i.plan_Actions)
               .HasForeignKey(d => d.notationid);
            #endregion
        }
       
        #endregion
    }
}
