﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iGMS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iGMSEntities : DbContext
    {
        public iGMSEntities()
            : base("name=iGMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<CateGood> CateGoods { get; set; }
        public virtual DbSet<CategoryGood> CategoryGoods { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<DetailBill> DetailBills { get; set; }
        public virtual DbSet<DetailEPC> DetailEPCs { get; set; }
        public virtual DbSet<DetailGoodOrder> DetailGoodOrders { get; set; }
        public virtual DbSet<DetailReportEndShift> DetailReportEndShifts { get; set; }
        public virtual DbSet<DetailSaleOrder> DetailSaleOrders { get; set; }
        public virtual DbSet<DetailSupplierGood> DetailSupplierGoods { get; set; }
        public virtual DbSet<DetailWareHouse> DetailWareHouses { get; set; }
        public virtual DbSet<EPC> EPCs { get; set; }
        public virtual DbSet<GeneralAccounting> GeneralAccountings { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<GroupGood> GroupGoods { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<InternalAccounting> InternalAccountings { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Method> Methods { get; set; }
        public virtual DbSet<NumberShift> NumberShifts { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderReport> PurchaseOrderReports { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReportFirstShift> ReportFirstShifts { get; set; }
        public virtual DbSet<ReportlEndShift> ReportlEndShifts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAdmin> RoleAdmins { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Stall> Stalls { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TypeSale> TypeSales { get; set; }
        public virtual DbSet<TypeStatu> TypeStatus { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WareHouse> WareHouses { get; set; }
    }
}
