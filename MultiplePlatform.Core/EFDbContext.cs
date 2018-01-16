namespace MultiplePlatform.Core
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }

        public virtual DbSet<T_BaseGoods> T_BaseGoods { get; set; }
        public virtual DbSet<T_Capital> T_Capital { get; set; }
        public virtual DbSet<T_CapitalChanges> T_CapitalChanges { get; set; }
        public virtual DbSet<T_Orders> T_Orders { get; set; }
        public virtual DbSet<T_Users> T_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_BaseGoods>()
                .Property(e => e.G_GoodName)
                .IsUnicode(false);

            modelBuilder.Entity<T_BaseGoods>()
                .Property(e => e.G_GoodCode)
                .IsUnicode(false);

            modelBuilder.Entity<T_BaseGoods>()
                .HasMany(e => e.T_Orders)
                .WithRequired(e => e.T_BaseGoods)
                .HasForeignKey(e => e.O_GoodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_Capital>()
                .Property(e => e.C_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_CapitalChanges>()
                .Property(e => e.C_OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<T_CapitalChanges>()
                .Property(e => e.C_Value)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_CapitalChanges>()
                .Property(e => e.C_BeforeValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_CapitalChanges>()
                .Property(e => e.C_AfterValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_CapitalChanges>()
                .Property(e => e.C_Mes)
                .IsUnicode(false);

            modelBuilder.Entity<T_Orders>()
                .Property(e => e.O_OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<T_Orders>()
                .Property(e => e.O_SubOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<T_Orders>()
                .Property(e => e.O_OrderValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Orders>()
                .Property(e => e.O_SuccessValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Orders>()
                .Property(e => e.O_Source)
                .IsUnicode(false);

            modelBuilder.Entity<T_Orders>()
                .Property(e => e.O_Account)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_Key)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_Email)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .Property(e => e.U_CardImg)
                .IsUnicode(false);

            modelBuilder.Entity<T_Users>()
                .HasOptional(e => e.T_Capital)
                .WithRequired(e => e.T_Users);

            modelBuilder.Entity<T_Users>()
                .HasMany(e => e.T_CapitalChanges)
                .WithRequired(e => e.T_Users)
                .HasForeignKey(e => e.C_UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
