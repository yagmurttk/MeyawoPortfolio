﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeyawoPortfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMyPortfolioEntities : DbContext
    {
        public DbMyPortfolioEntities()
            : base("name=DbMyPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_About> Tbl_About { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
        public virtual DbSet<Tbl_Future> Tbl_Future { get; set; }
        public virtual DbSet<Tbl_Project> Tbl_Project { get; set; }
        public virtual DbSet<Tbl_Service> Tbl_Service { get; set; }
        public virtual DbSet<Tbl_SocialMedia> Tbl_SocialMedia { get; set; }
        public virtual DbSet<Tbl_Testimonial> Tbl_Testimonial { get; set; }
    }
}
