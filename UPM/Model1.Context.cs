﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abonent> Abonent { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Moduls> Moduls { get; set; }
        public virtual DbSet<ProblemType> ProblemType { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestService> RequestService { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }
        public virtual DbSet<ServiceView> ServiceView { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StaffInform> StaffInform { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeEquipment> TypeEquipment { get; set; }
        public virtual DbSet<CodeRole> CodeRole { get; set; }
    }
}
