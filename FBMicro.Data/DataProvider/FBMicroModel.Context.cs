﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FBMicro.Data.DataProvider
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FBMicroContext : DbContext
    {
        public FBMicroContext()
            : base("name=FBMicroContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankLoanDetail> BankLoanDetails { get; set; }
        public virtual DbSet<BankMaster> BankMasters { get; set; }
        public virtual DbSet<UserBalanceTransferDetail> UserBalanceTransferDetails { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserHomeLoanDetail> UserHomeLoanDetails { get; set; }
        public virtual DbSet<VoucherMaster> VoucherMasters { get; set; }
    }
}
