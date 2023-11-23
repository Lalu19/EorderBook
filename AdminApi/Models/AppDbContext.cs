using AdminApi.Models.App;
using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using AdminApi.Models.App.Location;
using AdminApi.Models.App.BeatMaster;
using AdminApi.Models.App.StoreMaster;
using AdminApi.Models.App.ProductMaster;
using AdminApi.Models.App.Order;
using AdminApi.Models.App.OrderMaster;
using AdminApi.Models.App.UserAsign;
using AdminApi.Models.App.Agent;
using AdminApi.Models.App.CreditHistory;
using AdminApi.Models.App.AddtoCart;
using AdminApi.Models.App.StoreNotification;


//using AdminApi.Models.App;

namespace AdminApi.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<City> Citys { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Beat> Beats { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<ProductDetails> ProductDetailss { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<UserAssign> UserAssigns { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<CreditHistory> CreditHistory { get; set; }
        public virtual DbSet<AddtoCart> AddtoCart { get; set; }
        public virtual DbSet<StoreNotification> StoreNotification { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
                                //modelBuilder.SeedOracle();//use this only for Oracle
            #region 

            //Website pages start
            modelBuilder.Entity<Country>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Country>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end


            //Website pages start
            modelBuilder.Entity<State>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<State>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end
            

            //Website pages start
            modelBuilder.Entity<District>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<District>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<City>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<City>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end


            //Website pages start
            modelBuilder.Entity<Area>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Area>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<Beat>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Beat>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<Store>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Store>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end
            //Website pages start
            modelBuilder.Entity<Brand>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Brand>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end
            //Website pages start
            modelBuilder.Entity<Category>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Category>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end
            //Website pages start
            modelBuilder.Entity<ProductDetails>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProductDetails>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<Order>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Order>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<OrderDetails>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<OrderDetails>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<UserAssign>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<UserAssign>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            

            //Website pages start
            modelBuilder.Entity<Agent>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Agent>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<CreditHistory>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<CreditHistory>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<AddtoCart>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AddtoCart>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Website pages start
            modelBuilder.Entity<StoreNotification>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<StoreNotification>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            #endregion
        }

    }
}
