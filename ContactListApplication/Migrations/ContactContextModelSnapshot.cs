﻿// <auto-generated />
using System;
using ContactListApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactListApplication.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactListApplication.Models.ContactInfo", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("StateAbbr")
                        .IsRequired();

                    b.Property<int?>("ZipCode")
                        .IsRequired();

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new { ContactId = 1, Address = "309 Arthur Neu Dr.", City = "Carroll", Name = "Nikki McCloud", Note = "Myself.", PhoneNumber = "712-210-5283", StateAbbr = "IA", ZipCode = 51401 },
                        new { ContactId = 2, Address = "309 Arthur Neu Dr.", City = "Carroll", Name = "Jon Campbell", Note = "Fiance", PhoneNumber = "712-830-5158", StateAbbr = "IA", ZipCode = 51401 },
                        new { ContactId = 3, Address = "369 Troy Dr.", City = "Los Angeles", Name = "Jason Sudekis", Note = "Famous Celebrity", PhoneNumber = "555-555-5555", StateAbbr = "CA", ZipCode = 90001 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
