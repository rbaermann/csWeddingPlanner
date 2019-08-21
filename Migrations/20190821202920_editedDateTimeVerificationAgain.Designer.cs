﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using weddingPlanner.Models;

namespace weddingPlanner.Migrations
{
    [DbContext(typeof(WeddingPlannerContext))]
    [Migration("20190821202920_editedDateTimeVerificationAgain")]
    partial class editedDateTimeVerificationAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("weddingPlanner.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("weddingPlanner.Models.UserWedding", b =>
                {
                    b.Property<int>("UserWeddingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.Property<int>("WeddingId");

                    b.HasKey("UserWeddingId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeddingId");

                    b.ToTable("UserWeddings");
                });

            modelBuilder.Entity("weddingPlanner.Models.Wedding", b =>
                {
                    b.Property<int>("WeddingId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("HostUserId");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WedderOne")
                        .IsRequired();

                    b.Property<string>("WedderTwo")
                        .IsRequired();

                    b.Property<DateTime>("WeddingDate");

                    b.HasKey("WeddingId");

                    b.HasIndex("HostUserId");

                    b.ToTable("Weddings");
                });

            modelBuilder.Entity("weddingPlanner.Models.UserWedding", b =>
                {
                    b.HasOne("weddingPlanner.Models.User", "User")
                        .WithMany("UsersWedding")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("weddingPlanner.Models.Wedding", "Wedding")
                        .WithMany("WeddingsUsers")
                        .HasForeignKey("WeddingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("weddingPlanner.Models.Wedding", b =>
                {
                    b.HasOne("weddingPlanner.Models.User", "Host")
                        .WithMany()
                        .HasForeignKey("HostUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
