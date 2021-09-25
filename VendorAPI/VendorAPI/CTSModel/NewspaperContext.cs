using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VendorAPI.CTSModel
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
        public virtual DbSet<Subscriptiontbl> Subscriptiontbls { get; set; }
        public virtual DbSet<Vendortbl> Vendortbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KANINI-LTP-497\\SQLSERVER2019NAN;Database=Newspaper;User ID=sa;Password=Nandhini@sql;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddDeliverytbl>(entity =>
            {
                entity.HasKey(e => e.DelId)
                    .HasName("PK__AddDeliv__ED30F6F5EEBCFFEF");

                entity.ToTable("AddDeliverytbl");

                entity.Property(e => e.DelId).HasColumnName("Del_id");

                entity.Property(e => e.DelpartId).HasColumnName("delpart_id");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.AddDeliverytbls)
                    .HasForeignKey(d => d.Custid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cd");

                entity.HasOne(d => d.Delpart)
                    .WithMany(p => p.AddDeliverytbls)
                    .HasForeignKey(d => d.DelpartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dd");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.AddDeliverytbls)
                    .HasForeignKey(d => d.Titleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Nd");
            });

            modelBuilder.Entity<Admintbl>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__Admintbl__4A300117114617C6");

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
                    .HasName("PK__Customer__8CB382B19CD372F5");

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
                    .HasName("PK__Delivery__275CC2F041AF95F6");

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
                    .HasName("PK__Feedback__FD097F47AED87D3A");

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

                entity.Property(e => e.TitleId).HasColumnName("Title_id");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Feedbacktbls)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cf");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Feedbacktbls)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Nf");
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

            modelBuilder.Entity<Subscriptiontbl>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("PK__Subscrip__DFB370E58D41F72C");

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

                entity.Property(e => e.TitleId).HasColumnName("Title_id");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Subscriptiontbls)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CFK");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Subscriptiontbls)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NFK");
            });

            modelBuilder.Entity<Vendortbl>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK__Vendortb__D9CCC288200210D9");

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
