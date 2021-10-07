using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DeliveryPartner.NewsModel
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

        public virtual DbSet<DeliveryPartnertbl> DeliveryPartnertbls { get; set; }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
