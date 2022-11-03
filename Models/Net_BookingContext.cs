using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class Net_BookingContext : DbContext
    {
        public Net_BookingContext()
        {
        }

        public Net_BookingContext(DbContextOptions<Net_BookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelCategory> HotelCategories { get; set; }
        public virtual DbSet<RoomDetail> RoomDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=123456;database=.Net_Booking");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("Account");

                entity.HasIndex(e => e.Username, "UQ__Account__536C85E461690FC4")
                    .IsUnique();

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.HashPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Hash_password");

                entity.Property(e => e.IdHotel).HasColumnName("ID_Hotel");

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdHotel)
                    .HasConstraintName("FK_Account_Hotel");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.IdBooking)
                    .HasName("PK_idBooking");

                entity.ToTable("Booking");

                entity.HasIndex(e => e.IdBooking, "UQ__Booking__47353443246A9A56")
                    .IsUnique();

                entity.Property(e => e.IdBooking).HasColumnName("ID_Booking");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("date")
                    .HasColumnName("Create at");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("Date_End");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("Date_Start");

                entity.Property(e => e.IdRoomDetails).HasColumnName("ID_Room_Details");

                entity.Property(e => e.StaffId).HasColumnName("Staff_id");

                entity.Property(e => e.TotalCosts).HasColumnName("Total_Costs");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.HasOne(d => d.IdRoomDetailsNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.IdRoomDetails)
                    .HasConstraintName("FK_Booking_Room_Details");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.BookingStaffs)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_Booking_staffid");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.BookingUidNavigations)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_UID");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity)
                    .HasName("PK_Id_City");

                entity.ToTable("City");

                entity.HasIndex(e => e.Name, "UQ__City__737584F61AAA6B19")
                    .IsUnique();

                entity.HasIndex(e => e.IdCity, "UQ__City__7C17FD3F2C9DFA06")
                    .IsUnique();

                entity.Property(e => e.IdCity).HasColumnName("ID_City");

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.IdHotel)
                    .HasName("PK_Id_Hotel");

                entity.ToTable("Hotel");

                entity.HasIndex(e => e.IdHotel, "UQ__Hotel__198505EE5FC4BDD0")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "UQ__Hotel__5C7E359E2F0F9D6A")
                    .IsUnique();

                entity.Property(e => e.IdHotel).HasColumnName("ID_Hotel");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IdCategory).HasColumnName("ID_Category");

                entity.Property(e => e.IdCity).HasColumnName("ID_City");

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(75);

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Hotels)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Hotel_Hotel_Category");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Hotels)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hotel_City");
            });

            modelBuilder.Entity<HotelCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK_Id_CategoryHotel");

                entity.ToTable("Hotel_Category");

                entity.HasIndex(e => e.IdCategory, "UQ__Hotel_Ca__6DB3A68B4B83AE69")
                    .IsUnique();

                entity.Property(e => e.IdCategory).HasColumnName("ID_Category");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<RoomDetail>(entity =>
            {
                entity.HasKey(e => e.IdRoomDetails)
                    .HasName("PK_Id_typeroom");

                entity.ToTable("Room_Details");

                entity.HasIndex(e => e.IdRoomDetails, "UQ__Room_Det__62906BBF5F395CDD")
                    .IsUnique();

                entity.Property(e => e.IdRoomDetails).HasColumnName("ID_Room_Details");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.IdHotel).HasColumnName("ID_Hotel");

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.RoomDetails)
                    .HasForeignKey(d => d.IdHotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Room_Details_Hotel");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
