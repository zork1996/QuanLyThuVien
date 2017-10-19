namespace QuanLyThuVien.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryManagementEntities : DbContext
    {
        public LibraryManagementEntities()
            : base("name=LibraryManagementEntities")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Reader>()
                .Property(e => e.Phone)
                .IsFixedLength();
        }
    }
}
