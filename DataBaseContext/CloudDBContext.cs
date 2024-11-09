using ERPCloudMaker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace ERPCloudMaker.DataBaseContext 
{
    public class CloudDBContext : DbContext
    {
        //The BASIC Master context to store Tenant informations and settings

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();
            if (configuration.GetSection("DBProfile").GetSection("Database").Value == "SQL")
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("ERPCloudMaker_SQL"));
            }

        }

        
        public DbSet<Permisions> Permisions { get; set; } 
        public DbSet<Users> Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Customers> Customers { get; set; } 
        public DbSet<VoucherNames> Vouchernames { get; set; }
        public DbSet<InvoiceNumberSettings> Invoicenumbersettings  { get; set; }
        public DbSet<AccountGroup> Accountgroup  { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; } 
        public DbSet<ProductUnits> Productunits  { get; set; }
        public DbSet<ProductGroups> Productgroups { get; set; }
        public DbSet<ProductCategory> Productcategory { get; set; }
        public DbSet<Ledgers> Ledgers { get; set; }
        public DbSet<ItemMaster> Productitems { get; set; }
        public DbSet<CustomerOpenBalance> Customeropenbalance { get; set; }
        public DbSet<CustomerAddress> Customeraddress { get; set; }

          
    } 
} 
