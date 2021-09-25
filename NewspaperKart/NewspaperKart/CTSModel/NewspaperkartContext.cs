using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NewspaperKart.CTSModel
{
    public partial class NewspaperkartContext : DbContext
    {
        public NewspaperkartContext()
        {
        }

        public NewspaperkartContext(DbContextOptions<NewspaperkartContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddDelivery> AddDeliveries { get; set; }
        public virtual DbSet<AdminRegistertbl> AdminRegistertbls { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Logintbl> Logintbls { get; set; }
        public virtual DbSet<Newspaper> Newspapers { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<UserRegistertbl> UserRegistertbls { get; set; }
        public virtual DbSet<VendorRegistertbl> VendorRegistertbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KANINI-LTP-497\\SQLSERVER2019NAN;Database=Newspaperkart;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddDelivery>(entity =>
            {
                entity.ToTable("AddDelivery");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.DeliveryMan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("delivery_man");

                entity.Property(e => e.NewspaperName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("newspaper_name");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");
            });

            modelBuilder.Entity<AdminRegistertbl>(entity =>
            {
                entity.ToTable("AdminRegistertbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Issue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("issue");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NewspaperTitle)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("newspaper_title");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Subscriptiontype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("subscriptiontype");

                entity.Property(e => e.Timeperiod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("timeperiod");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");
            });

            modelBuilder.Entity<Logintbl>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Logintbl__536C85E5A2ECA75F");

                entity.ToTable("Logintbl");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Newspaper>(entity =>
            {
                entity.ToTable("Newspaper");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Language)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("Partner");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("Subscription");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SubscriptionType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("subscription_type");

                entity.Property(e => e.TimePeriod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("time_period");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<UserRegistertbl>(entity =>
            {
                entity.ToTable("UserRegistertbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorRegistertbl>(entity =>
            {
                entity.ToTable("VendorRegistertbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
