﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Data.Migrations
{
    [DbContext(typeof(BackEndDataContext))]
    partial class BackEndDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("BackEnd.Data.Entities.Channel", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("theme")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("BackEnd.Data.Entities.User", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<long?>("Channelid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("username");

                    b.HasIndex("Channelid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BackEnd.Data.Entities.User", b =>
                {
                    b.HasOne("BackEnd.Data.Entities.Channel", null)
                        .WithMany("members")
                        .HasForeignKey("Channelid");
                });
#pragma warning restore 612, 618
        }
    }
}
