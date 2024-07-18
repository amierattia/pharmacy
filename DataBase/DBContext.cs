using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DBContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
           
              var  fileName = Path.Combine(path,"_PharmacyDataBase.db");

            optionsBuilder.UseSqlite("FileName="+fileName);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cstomer>(entity =>
            {
                entity.HasKey(c => c.CustomerID);
            });
        }

        public DbSet<ClsModel> Order { get; set; }
        public DbSet<UsersDb> Users { get; set; }
        public DbSet<returnesModels> Returnes { get; set; }
        public DbSet<StokeModel> Soke { get; set; }
        public DbSet<SalesModels> Sales { get; set; }
        public DbSet<storeModels> store { get; set; }
        public DbSet<Cstomer> Cstomer { get; set; }



    }
}
