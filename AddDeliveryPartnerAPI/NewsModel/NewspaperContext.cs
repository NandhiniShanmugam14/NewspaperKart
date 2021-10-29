using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AddDeliveryPartner.NewsModel
{
    public partial class NewspaperContext : DbContext
    {
        public NewspaperContext()
        {
        }

        public NewspaperContext(DbContextOptions<NewspaperContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual DbSet<Admintbl> Admintbls { get; set; }
        public virtual DbSet<Customertbl> Customertbls { get; set; }
        public virtual DbSet<DeliveryPartnertbl> DeliveryPartnertbls { get; set; }
        public virtual DbSet<Feedbacktbl> Feedbacktbls { get; set; }
        public virtual DbSet<Newspapertbl> Newspapertbls { get; set; }
        public virtual DbSet<Paymenttbl> Paymenttbls { get; set; }
        public virtual DbSet<Subscriptiontbl> Subscriptiontbls { get; set; }
        public virtual DbSet<Vendortbl> Vendortbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KANINI-LTP-497\\SQLSERVER2019NAN;Database=Newspaper;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddDeliverytbl>(entity =>
            {
                entity.HasKey(e => e.DelId)
                    .HasName("PK__AddDeliv__ED30F6F56B378816");

                entity.ToTable("AddDeliverytbl");

                entity.Property(e => e.DelId).HasColumnName("Del_id");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cust_name");

                entity.Property(e => e.DelPartner)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Del_partner");

                entity.Property(e => e.Timeperiod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("timeperiod");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Admintbl>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__Admintbl__4A3001173F1C4BBB");

                entity.ToTable("Admintbl");

                entity.Property(e => e.AdminId).HasColumnName("Admin_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customertbl>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB382B17C5C002C");

                entity.ToTable("Customertbl");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phoneno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryPartnertbl>(entity =>
            {
                entity.HasKey(e => e.DelPartId)
                    .HasName("PK__Delivery__275CC2F0AF5D0076");

                entity.ToTable("DeliveryPartnertbl");

                entity.Property(e => e.DelPartId).HasColumnName("DelPart_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phoneno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Feedbacktbl>(entity =>
            {
                entity.HasKey(e => e.FeedId)
                    .HasName("PK__Feedback__FD097F47F32F1BAC");

                entity.ToTable("Feedbacktbl");

                entity.Property(e => e.FeedId).HasColumnName("Feed_id");

                entity.Property(e => e.CustId).HasColumnName("Cust_Id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Issue)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("issue");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phoneno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Feedbacktbls)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cf");
            });

            modelBuilder.Entity<Newspapertbl>(entity =>
            {
                entity.ToTable("Newspapertbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Paymenttbl>(entity =>
            {
                entity.HasKey(e => e.PayId)
                    .HasName("PK__Paymentt__7AAD1CEA3A581754");

                entity.ToTable("Paymenttbl");

                entity.Property(e => e.PayId).HasColumnName("pay_id");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("Card_No");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Exp_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subscriptiontbl>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("PK__Subscrip__DFB370E54F36F499");

                entity.ToTable("Subscriptiontbl");

                entity.Property(e => e.SubId).HasColumnName("Sub_id");

                entity.Property(e => e.CustId).HasColumnName("Cust_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subscriptiontype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("subscriptiontype");

                entity.Property(e => e.Timeperiod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("timeperiod");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Subscriptiontbls)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CFK");
            });

            modelBuilder.Entity<Vendortbl>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK__Vendortb__D9CCC2881578CFDB");

                entity.ToTable("Vendortbl");

                entity.Property(e => e.VendorId).HasColumnName("Vendor_ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_name");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phoneno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
