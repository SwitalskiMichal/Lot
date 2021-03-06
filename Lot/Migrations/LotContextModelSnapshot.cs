﻿// <auto-generated />
using System;
using Lot.Encje;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lot.Migrations
{
    [DbContext(typeof(LotContext))]
    partial class LotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lot.Encje.CelLotu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kraj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LotId")
                        .HasColumnType("int");

                    b.Property<string>("Lotnisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miasto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LotId")
                        .IsUnique();

                    b.ToTable("CeleLotow");
                });

            modelBuilder.Entity("Lot.Encje.Lot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("nazwaLiniLotniczej")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwaSamolotu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Loty");
                });

            modelBuilder.Entity("Lot.Encje.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrajPochodzenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LotId")
                        .HasColumnType("int");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LotId");

                    b.ToTable("Piloci");
                });

            modelBuilder.Entity("Lot.Encje.CelLotu", b =>
                {
                    b.HasOne("Lot.Encje.Lot", "Lot")
                        .WithOne("CelLotu")
                        .HasForeignKey("Lot.Encje.CelLotu", "LotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lot.Encje.Pilot", b =>
                {
                    b.HasOne("Lot.Encje.Lot", "Lot")
                        .WithMany("Piloci")
                        .HasForeignKey("LotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
