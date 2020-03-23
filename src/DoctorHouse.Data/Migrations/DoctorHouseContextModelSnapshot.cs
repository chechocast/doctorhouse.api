﻿// <auto-generated />
using System;
using DoctorHouse.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorHouse.Data.Migrations
{
    [DbContext(typeof(DoctorHouseContext))]
    partial class DoctorHouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorHouse.Data.EmailNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cc")
                        .HasColumnName("CC")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSent")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("SentTries")
                        .HasColumnType("smallint");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ToName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IsSent");

                    b.HasIndex("SentTries", "SentDate");

                    b.ToTable("EmailNotifications");
                });

            modelBuilder.Entity("DoctorHouse.Data.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(140)")
                        .HasMaxLength(140);

                    b.Property<string>("JobPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(140)")
                        .HasMaxLength(140);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("DoctorHouse.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("ParentLocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ParentLocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DoctorHouse.Data.Notification", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("EmailHtml")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailSubject")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("IsEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMobile")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("bit");

                    b.Property<string>("MobileText")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("SystemText")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("DoctorHouse.Data.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<DateTime?>("AvailableFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AvailableTo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Bathroom")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EntireHouse")
                        .HasColumnType("bit");

                    b.Property<bool>("Food")
                        .HasColumnType("bit");

                    b.Property<byte>("GuestsAllowed")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Internet")
                        .HasColumnType("bit");

                    b.Property<bool>("Kitchen")
                        .HasColumnType("bit");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal");

                    b.Property<bool>("Parking")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("DoctorHouse.Data.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("GuestTypeId")
                        .HasColumnType("tinyint");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<byte>("StatusId")
                        .HasColumnType("tinyint");

                    b.Property<int>("UserOwnerId")
                        .HasColumnType("int");

                    b.Property<int>("UserRequesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("UserOwnerId");

                    b.HasIndex("UserRequesterId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DoctorHouse.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("IOsDeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JobAddress")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("JobPlace")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordRecoveryToken")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DoctorHouse.Data.Guest", b =>
                {
                    b.HasOne("DoctorHouse.Data.Request", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorHouse.Data.Location", b =>
                {
                    b.HasOne("DoctorHouse.Data.Location", null)
                        .WithMany("InverseParentLocation")
                        .HasForeignKey("LocationId");

                    b.HasOne("DoctorHouse.Data.Location", "ParentLocation")
                        .WithMany()
                        .HasForeignKey("ParentLocationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DoctorHouse.Data.Place", b =>
                {
                    b.HasOne("DoctorHouse.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DoctorHouse.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorHouse.Data.Request", b =>
                {
                    b.HasOne("DoctorHouse.Data.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DoctorHouse.Data.User", "UserOwner")
                        .WithMany()
                        .HasForeignKey("UserOwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DoctorHouse.Data.User", "UserRequester")
                        .WithMany()
                        .HasForeignKey("UserRequesterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorHouse.Data.User", b =>
                {
                    b.HasOne("DoctorHouse.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
