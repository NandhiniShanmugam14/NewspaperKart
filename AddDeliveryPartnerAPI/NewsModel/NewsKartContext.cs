using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AddDeliveryPartner.NewsModel
{
    public partial class NewsKartContext : DbContext
    {
        public NewsKartContext()
        {
        }

        public NewsKartContext(DbContextOptions<NewsKartContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual DbSet<Customertbl> Customertbls { get; set; }
        public virtual DbSet<DeliveryPartnertbl> DeliveryPartnertbls { get; set; }
        public virtual DbSet<Newspapertbl> Newspapertbls { get; set; }

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
                    .HasName("PK__AddDeliv__ED30F6F54F8A908C");

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

            modelBuilder.Entity<Customertbl>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB382B1D0CA5267");

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
                    .HasName("PK__Delivery__275CC2F050E9F0C5");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
