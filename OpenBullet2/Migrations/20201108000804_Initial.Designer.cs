﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenBullet2;

namespace OpenBullet2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201108000804_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("OpenBullet2.Entities.GuestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AccessExpiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("AllowedAddresses")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("OpenBullet2.Entities.HitEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CapturedData")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConfigCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConfigId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConfigName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Proxy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int>("WordlistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WordlistName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hits");
                });

            modelBuilder.Entity("OpenBullet2.Entities.JobEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobOptions")
                        .HasColumnType("TEXT");

                    b.Property<int>("JobType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("OpenBullet2.Entities.ProxyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Host")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastChecked")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ping")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Proxies");
                });

            modelBuilder.Entity("OpenBullet2.Entities.ProxyGroupEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProxyGroups");
                });

            modelBuilder.Entity("OpenBullet2.Entities.RecordEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Checkpoint")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfigId")
                        .HasColumnType("TEXT");

                    b.Property<int>("WordlistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("OpenBullet2.Entities.TriggeredActionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TriggeredAction")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TriggeredActions");
                });

            modelBuilder.Entity("OpenBullet2.Entities.WordlistEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Purpose")
                        .HasColumnType("TEXT");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Wordlists");
                });
#pragma warning restore 612, 618
        }
    }
}