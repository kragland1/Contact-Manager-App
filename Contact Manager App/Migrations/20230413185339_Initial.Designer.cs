﻿// <auto-generated />
using System;
using Contact_Manager_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contact_Manager_App.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20230413185339_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Contact_Manager_App.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Contact_Manager_App.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 4, 13, 14, 53, 39, 747, DateTimeKind.Local).AddTicks(8564),
                            Email = "Dav.Hen@aol.com",
                            Firstname = "David",
                            Lastname = "Henry",
                            Phone = "270-788-8899"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 2,
                            DateAdded = new DateTime(2023, 4, 13, 14, 53, 39, 747, DateTimeKind.Local).AddTicks(8610),
                            Email = "JimJimLeeson@yahoo.com",
                            Firstname = "Jimmy",
                            Lastname = "Lee",
                            Phone = "707-556-8569"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = 3,
                            DateAdded = new DateTime(2023, 4, 13, 14, 53, 39, 747, DateTimeKind.Local).AddTicks(8614),
                            Email = "Geo.Santo@gmail.com",
                            Firstname = "George",
                            Lastname = "Santos",
                            Phone = "270-988-5667"
                        });
                });

            modelBuilder.Entity("Contact_Manager_App.Models.Contact", b =>
                {
                    b.HasOne("Contact_Manager_App.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}