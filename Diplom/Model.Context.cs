﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Directions> Directions { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Сompetencies> Сompetencies { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
    }
}
