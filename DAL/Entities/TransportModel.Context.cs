﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TransportDBEntities : DbContext
    {
        public TransportDBEntities()
            : base("name=TransportDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_masterFuelStation> tbl_masterFuelStation { get; set; }
        public virtual DbSet<tbl_masterFuelType> tbl_masterFuelType { get; set; }
        public virtual DbSet<tbl_masterbus> tbl_masterbus { get; set; }
    }
}
