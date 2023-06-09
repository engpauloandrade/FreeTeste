﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FreeTeste.Api.Database;

#nullable disable

namespace FreeTeste.Api.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20230411001148_FreeTeste")]
    partial class FreeTeste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TesteFrenet.Api.Models.Colors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "fuchsia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "plum"
                        },
                        new
                        {
                            Id = 3,
                            Name = "turquoise"
                        },
                        new
                        {
                            Id = 4,
                            Name = "white"
                        },
                        new
                        {
                            Id = 5,
                            Name = "red"
                        },
                        new
                        {
                            Id = 6,
                            Name = "azure"
                        },
                        new
                        {
                            Id = 7,
                            Name = "olive"
                        },
                        new
                        {
                            Id = 8,
                            Name = "lavender"
                        },
                        new
                        {
                            Id = 9,
                            Name = "grey"
                        },
                        new
                        {
                            Id = 10,
                            Name = "white"
                        },
                        new
                        {
                            Id = 11,
                            Name = "violet"
                        },
                        new
                        {
                            Id = 12,
                            Name = "indigo"
                        },
                        new
                        {
                            Id = 13,
                            Name = "indigo"
                        },
                        new
                        {
                            Id = 14,
                            Name = "plum"
                        },
                        new
                        {
                            Id = 15,
                            Name = "salmon"
                        },
                        new
                        {
                            Id = 16,
                            Name = "plum"
                        },
                        new
                        {
                            Id = 17,
                            Name = "violet"
                        },
                        new
                        {
                            Id = 18,
                            Name = "magenta"
                        },
                        new
                        {
                            Id = 19,
                            Name = "ivory"
                        },
                        new
                        {
                            Id = 20,
                            Name = "orange"
                        });
                });

            modelBuilder.Entity("TesteFrenet.Api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 4, 28, 1, 23, 44, 366, DateTimeKind.Local).AddTicks(6945),
                            Email = "Rafael8@hotmail.com",
                            FirstName = "Rafael",
                            LastName = "Reichel",
                            Salary = 9886.872036384272000m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 10, 27, 14, 17, 46, 338, DateTimeKind.Local).AddTicks(1855),
                            Email = "Jackie_Carroll41@yahoo.com",
                            FirstName = "Jackie",
                            LastName = "Carroll",
                            Salary = 5079.919581172272000m
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 10, 3, 16, 30, 32, 222, DateTimeKind.Local).AddTicks(9090),
                            Email = "Abel41@yahoo.com",
                            FirstName = "Abel",
                            LastName = "Kertzmann",
                            Salary = 9323.274162279648000m
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 8, 20, 6, 29, 52, 547, DateTimeKind.Local).AddTicks(7367),
                            Email = "Leroy_Green10@hotmail.com",
                            FirstName = "Leroy",
                            LastName = "Green",
                            Salary = 7158.165116534768000m
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 12, 6, 17, 32, 12, 183, DateTimeKind.Local).AddTicks(2051),
                            Email = "Elena.Strosin@hotmail.com",
                            FirstName = "Elena",
                            LastName = "Strosin",
                            Salary = 8856.73051061944000m
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 1, 25, 22, 47, 55, 871, DateTimeKind.Local).AddTicks(8913),
                            Email = "Dianne_Hamill@hotmail.com",
                            FirstName = "Dianne",
                            LastName = "Hamill",
                            Salary = 9290.7033985408000m
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 4, 8, 12, 26, 45, 332, DateTimeKind.Local).AddTicks(9492),
                            Email = "Claudia41@gmail.com",
                            FirstName = "Claudia",
                            LastName = "Zemlak",
                            Salary = 5851.64898395536000m
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 2, 21, 23, 41, 21, 296, DateTimeKind.Local).AddTicks(249),
                            Email = "Bradford47@gmail.com",
                            FirstName = "Bradford",
                            LastName = "Okuneva",
                            Salary = 2381.0427164521128000m
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2022, 4, 12, 7, 24, 2, 665, DateTimeKind.Local).AddTicks(6192),
                            Email = "Saul96@hotmail.com",
                            FirstName = "Saul",
                            LastName = "Koelpin",
                            Salary = 4728.231977749224000m
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 3, 25, 3, 41, 31, 84, DateTimeKind.Local).AddTicks(1156),
                            Email = "Amos_OKon@gmail.com",
                            FirstName = "Amos",
                            LastName = "O'Kon",
                            Salary = 8710.526821846288000m
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2022, 11, 23, 14, 33, 28, 501, DateTimeKind.Local).AddTicks(2466),
                            Email = "Jermaine_Fritsch44@hotmail.com",
                            FirstName = "Jermaine",
                            LastName = "Fritsch",
                            Salary = 4461.847230532136000m
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2022, 9, 22, 2, 59, 32, 760, DateTimeKind.Local).AddTicks(6873),
                            Email = "Otis71@gmail.com",
                            FirstName = "Otis",
                            LastName = "Kling",
                            Salary = 9096.838467874024000m
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2022, 10, 18, 21, 24, 47, 570, DateTimeKind.Local).AddTicks(7515),
                            Email = "Lola44@gmail.com",
                            FirstName = "Lola",
                            LastName = "Davis",
                            Salary = 3706.689786099160000m
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2023, 3, 12, 0, 45, 54, 884, DateTimeKind.Local).AddTicks(3791),
                            Email = "Jeremy.Rau@yahoo.com",
                            FirstName = "Jeremy",
                            LastName = "Rau",
                            Salary = 3307.172019198384000m
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2023, 4, 2, 3, 40, 46, 97, DateTimeKind.Local).AddTicks(5908),
                            Email = "Kent.Stehr27@gmail.com",
                            FirstName = "Kent",
                            LastName = "Stehr",
                            Salary = 5829.644678317800000m
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2023, 1, 5, 7, 43, 43, 589, DateTimeKind.Local).AddTicks(5876),
                            Email = "Karl_Witting@yahoo.com",
                            FirstName = "Karl",
                            LastName = "Witting",
                            Salary = 5828.558742720048000m
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2023, 3, 4, 13, 3, 29, 655, DateTimeKind.Local).AddTicks(9930),
                            Email = "Rodolfo52@gmail.com",
                            FirstName = "Rodolfo",
                            LastName = "Runte",
                            Salary = 2269.2875657039584000m
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2022, 8, 7, 8, 48, 29, 214, DateTimeKind.Local).AddTicks(5752),
                            Email = "Johanna26@yahoo.com",
                            FirstName = "Johanna",
                            LastName = "Goodwin",
                            Salary = 4530.740130259744000m
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2023, 2, 5, 14, 45, 4, 919, DateTimeKind.Local).AddTicks(6885),
                            Email = "Jerome40@hotmail.com",
                            FirstName = "Jerome",
                            LastName = "Tromp",
                            Salary = 8064.41877138248000m
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2023, 3, 26, 17, 9, 45, 341, DateTimeKind.Local).AddTicks(5977),
                            Email = "Ernestine_Stracke@gmail.com",
                            FirstName = "Ernestine",
                            LastName = "Stracke",
                            Salary = 7444.665285665016000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
