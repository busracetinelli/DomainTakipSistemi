﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainTakipSistemi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DomainTakipSistemiEntities : DbContext
    {
        public DomainTakipSistemiEntities()
            : base("name=DomainTakipSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DomainKayit> DomainKayit { get; set; }
        public virtual DbSet<Proje_Tipleri> Proje_Tipleri { get; set; }
    }
}