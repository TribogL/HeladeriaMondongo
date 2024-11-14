﻿// <auto-generated />
using HeladeriaMondongo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HeladeriaMondongo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241114162435_SeedUsersWithAdmin")]
    partial class SeedUsersWithAdmin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HeladeriaMondongo.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("email");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_admin");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("varchar(220)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Elfrieda_Wiza75@gmail.com",
                            IsAdmin = false,
                            LastName = "Cummerata",
                            Name = "Dangelo",
                            Password = "heeeoaea"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Meagan.Jones@gmail.com",
                            IsAdmin = false,
                            LastName = "Lang",
                            Name = "Burdette",
                            Password = "neuiiiee"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Keegan.Walker17@hotmail.com",
                            IsAdmin = false,
                            LastName = "Leuschke",
                            Name = "Michael",
                            Password = "bueeaoie"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Alberta.Franecki@yahoo.com",
                            IsAdmin = false,
                            LastName = "Senger",
                            Name = "Justen",
                            Password = "suueeieo"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Theron47@gmail.com",
                            IsAdmin = false,
                            LastName = "Kohler",
                            Name = "Ulises",
                            Password = "haaooaoi"
                        },
                        new
                        {
                            Id = 6,
                            Email = "Benny.Becker@yahoo.com",
                            IsAdmin = false,
                            LastName = "Stokes",
                            Name = "Dawn",
                            Password = "wuoueeia"
                        },
                        new
                        {
                            Id = 7,
                            Email = "Zaria.Runolfsdottir27@yahoo.com",
                            IsAdmin = false,
                            LastName = "Hamill",
                            Name = "Monte",
                            Password = "jioauaia"
                        },
                        new
                        {
                            Id = 8,
                            Email = "Brayan11@gmail.com",
                            IsAdmin = false,
                            LastName = "Murphy",
                            Name = "Rosamond",
                            Password = "soiooaeu"
                        },
                        new
                        {
                            Id = 9,
                            Email = "Stuart35@yahoo.com",
                            IsAdmin = false,
                            LastName = "Romaguera",
                            Name = "Melba",
                            Password = "xooioaee"
                        },
                        new
                        {
                            Id = 10,
                            Email = "Ocie.Rath@gmail.com",
                            IsAdmin = false,
                            LastName = "Schaefer",
                            Name = "Hallie",
                            Password = "teaauoai"
                        },
                        new
                        {
                            Id = 100,
                            Email = "admin@example.com",
                            IsAdmin = true,
                            LastName = "User",
                            Name = "Admin",
                            Password = "AdminPassword123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
