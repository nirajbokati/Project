﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourPlanner.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TourPlannerEntities : DbContext
    {
        public TourPlannerEntities()
            : base("name=TourPlannerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblNavbar> tblNavbars { get; set; }
    
        public virtual ObjectResult<dbNavSelect_Result> dbNavSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dbNavSelect_Result>("dbNavSelect");
        }
    }
}