﻿// <auto-generated />
using System;
using BillingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    [DbContext(typeof(BillingSystemDbContext))]
    [Migration("20240412162640_ChangeProductEntity")]
    partial class ChangeProductEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Client identificator");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("City where customer uses the service");

                    b.Property<string>("CivilNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Client persanal number");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Client Email address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Client first name");

                    b.Property<int?>("IPTVId")
                        .HasColumnType("int")
                        .HasComment("IPTV Id");

                    b.Property<int?>("InternetServiceId")
                        .HasColumnType("int")
                        .HasComment("Internet Service Id");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Client last name");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Client middle name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Client phone number");

                    b.Property<int?>("SatelliteTvId")
                        .HasColumnType("int")
                        .HasComment("Satellite Id");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("Street where customer uses the service");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("StreetNumber where customer uses the service");

                    b.HasKey("Id");

                    b.HasIndex("IPTVId")
                        .IsUnique()
                        .HasFilter("[IPTVId] IS NOT NULL");

                    b.HasIndex("InternetServiceId")
                        .IsUnique()
                        .HasFilter("[InternetServiceId] IS NOT NULL");

                    b.HasIndex("SatelliteTvId")
                        .IsUnique()
                        .HasFilter("[SatelliteTvId] IS NOT NULL");

                    b.ToTable("Clients");

                    b.HasComment("Client contract");

                    b.HasData(
                        new
                        {
                            Id = 9999,
                            City = "Варна",
                            CivilNumber = "8801018899",
                            Email = "angel.angelov@gmail.com",
                            FirstName = "Ангел",
                            IPTVId = 1,
                            InternetServiceId = 1,
                            LastName = "Ангелов",
                            MiddleName = "Ангелов",
                            PhoneNumber = "0888001100",
                            SatelliteTvId = 1,
                            StreetName = "Васил Левски",
                            StreetNumber = "10А"
                        });
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.InternetService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Internet service identificator");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActiveUntilDate")
                        .HasColumnType("datetime2")
                        .HasComment("Until which date the service is active");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Client Id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("The service is paid/unpaid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Name of service. Include internet speed");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasComment("Internet product Identificator");

                    b.Property<string>("RouterMACAdress")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)")
                        .HasComment("MAC address client device");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("InternetServices");

                    b.HasComment("Internet service");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveUntilDate = new DateTime(2024, 5, 12, 19, 26, 40, 107, DateTimeKind.Local).AddTicks(9510),
                            ClientId = 9999,
                            IsActive = true,
                            Name = "InternetProduct75Mbps",
                            ProductId = 3,
                            RouterMACAdress = "0C:8B:3A:25:0D:F4"
                        });
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.IPTV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Interactive television identificator");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActiveUntilDate")
                        .HasColumnType("datetime2")
                        .HasComment("Until which date the service is active");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Client Id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("The service is paid/unpaid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Device model name");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasComment("Television product Identificator");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int")
                        .HasComment("Serial number of device");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("IPTVs");

                    b.HasComment("Interactive television");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveUntilDate = new DateTime(2024, 5, 12, 19, 26, 40, 111, DateTimeKind.Local).AddTicks(3800),
                            ClientId = 9999,
                            IsActive = true,
                            Name = "WinMat",
                            ProductId = 13,
                            SerialNumber = 3000001
                        });
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identificator");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Name of the service");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Price of  service");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");

                    b.HasComment("IPTV product");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "InternetProduct50Mbps",
                            Price = 12.99m,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 1,
                            Name = "InternetProduct25Mbps",
                            Price = 10.99m,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "InternetProduct75Mbps",
                            Price = 14.99m,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "InternetProduct100Mbps",
                            Price = 16.99m,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Start",
                            Price = 9.99m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sport",
                            Price = 11.99m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Kids",
                            Price = 3.99m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 10,
                            Name = "Erotic",
                            Price = 7.99m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Films",
                            Price = 5.99m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Popularsciene",
                            Price = 8.99m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 13,
                            Name = "Sport",
                            Price = 11.99m,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "Start",
                            Price = 9.99m,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 16,
                            Name = "Erotic",
                            Price = 7.99m,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            Name = "Kids",
                            Price = 3.99m,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 14,
                            Name = "Popularsciene",
                            Price = 8.99m,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "Films",
                            Price = 5.99m,
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.SatelliteTV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Satellite television identificator");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActiveUntilDate")
                        .HasColumnType("datetime2")
                        .HasComment("Until which date the service is active");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Client Id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("The service is paid/unpaid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Model of satelite device");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int")
                        .HasComment("Satellite device serial number");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("SatelliteTVs");

                    b.HasComment("Satellite televiision");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveUntilDate = new DateTime(2024, 5, 12, 19, 26, 40, 114, DateTimeKind.Local).AddTicks(8748),
                            ClientId = 9999,
                            IsActive = true,
                            Name = "PomSat",
                            ProductId = 5,
                            SerialNumber = 5000001
                        });
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Ticket identificator");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("City");

                    b.Property<int>("ClientContractNumber")
                        .HasColumnType("int")
                        .HasComment("Client contract number");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Date of created ticket");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("Problem description");

                    b.Property<bool>("IsComplited")
                        .HasColumnType("bit")
                        .HasComment("Is complited ticket");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Street");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("StreetNumber");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Tickets");

                    b.HasComment("Service tickets");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.TypeOfService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfService");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Internet"
                        },
                        new
                        {
                            Id = 2,
                            Name = "SatelliteTv"
                        },
                        new
                        {
                            Id = 3,
                            Name = "IPTV"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "723179d2-361d-4366-926a-9ad92eeb6db5",
                            Email = "cashier@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "cashier@mail.com",
                            NormalizedUserName = "cashier@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEA0aBEk64WRAKmciLY6KZJIpMeAqSLlnHLyI1utM4oTCB0TJJ7pf030Xhc37Aoof1Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2d11dd91-61fe-475c-af14-0e8fa41055f4",
                            TwoFactorEnabled = false,
                            UserName = "cashier@mail.com"
                        },
                        new
                        {
                            Id = "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "95129156-30e4-4e7f-a9c1-1648c4c68ce8",
                            Email = "support@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "support@mail.com",
                            NormalizedUserName = "support@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEECVM5+0PIYDdaQ74/t9bMHl3mJXpsG/vOsVR9dJIZpv18pntmf1QCzvIn5+ewx+g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8dbd2577-a7bc-48b3-887a-2b5873570fbc",
                            TwoFactorEnabled = false,
                            UserName = "support@mail.com"
                        },
                        new
                        {
                            Id = "dea12896-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ff374d89-6abf-4868-924f-bb8c8c3ab395",
                            Email = "client@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "client@mail.com",
                            NormalizedUserName = "client@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ4aeBA9dPPYdtGoGJHPQy3UE96owX09LPVb2zm35MufOxWx7hSeO4ohobxgq2qKzg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6a176f34-4628-4800-a9d2-c10a35e51b60",
                            TwoFactorEnabled = false,
                            UserName = "client@mail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Client", b =>
                {
                    b.HasOne("BillingSystem.Infrastructure.DataModels.IPTV", "IPTV")
                        .WithOne("Client")
                        .HasForeignKey("BillingSystem.Infrastructure.DataModels.Client", "IPTVId");

                    b.HasOne("BillingSystem.Infrastructure.DataModels.InternetService", "InternetService")
                        .WithOne("Client")
                        .HasForeignKey("BillingSystem.Infrastructure.DataModels.Client", "InternetServiceId");

                    b.HasOne("BillingSystem.Infrastructure.DataModels.SatelliteTV", "SatelliteTV")
                        .WithOne("Client")
                        .HasForeignKey("BillingSystem.Infrastructure.DataModels.Client", "SatelliteTvId");

                    b.Navigation("IPTV");

                    b.Navigation("InternetService");

                    b.Navigation("SatelliteTV");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.InternetService", b =>
                {
                    b.HasOne("BillingSystem.Infrastructure.DataModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.IPTV", b =>
                {
                    b.HasOne("BillingSystem.Infrastructure.DataModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Product", b =>
                {
                    b.HasOne("BillingSystem.Infrastructure.DataModels.TypeOfService", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.SatelliteTV", b =>
                {
                    b.HasOne("BillingSystem.Infrastructure.DataModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Ticket", b =>
                {
                    b.HasOne("BillingSystem.Infrastructure.DataModels.Client", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.Client", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.InternetService", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.IPTV", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });

            modelBuilder.Entity("BillingSystem.Infrastructure.DataModels.SatelliteTV", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
