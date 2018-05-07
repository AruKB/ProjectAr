﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using project.EmpDataContext;

namespace project.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("project.Models.BLOGS", b =>
                {
                    b.Property<int>("BLOGS_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogsStatus_Id");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Users_Id");

                    b.Property<DateTime>("WritingDate");

                    b.HasKey("BLOGS_Id");

                    b.HasIndex("BlogsStatus_Id");

                    b.HasIndex("Users_Id");

                    b.ToTable("BLOGS");
                });

            modelBuilder.Entity("project.Models.BlogsStatus", b =>
                {
                    b.Property<int>("BlogsStatus_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("BlogsStatus_Id");

                    b.ToTable("BlogsStatus");
                });

            modelBuilder.Entity("project.Models.StatusUsers", b =>
                {
                    b.Property<int>("StatusUsers_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("StatusUsers_Id");

                    b.ToTable("StatusUsers");
                });

            modelBuilder.Entity("project.Models.Users", b =>
                {
                    b.Property<int>("Users_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegistrDate");

                    b.Property<int>("StatusUsers_Id");

                    b.Property<string>("Users_Logins")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Users_Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Users_Password")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Users_Id");

                    b.HasIndex("StatusUsers_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("project.Models.BLOGS", b =>
                {
                    b.HasOne("project.Models.BlogsStatus", "BlogsStatus")
                        .WithMany()
                        .HasForeignKey("BlogsStatus_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("project.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Users_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("project.Models.Users", b =>
                {
                    b.HasOne("project.Models.StatusUsers", "StatusUsers")
                        .WithMany()
                        .HasForeignKey("StatusUsers_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
