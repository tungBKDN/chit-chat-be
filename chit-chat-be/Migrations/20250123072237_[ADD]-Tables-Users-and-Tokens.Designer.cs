﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chit_chat_be.Data;

#nullable disable

namespace chit_chat_be.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250123072237_[ADD]-Tables-Users-and-Tokens")]
    partial class ADDTablesUsersandTokens
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("chit_chat_be.Models.Token", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TokenString")
                        .IsRequired()
                        .HasMaxLength(511)
                        .HasColumnType("varchar(511)");

                    b.Property<string>("Username1")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.HasKey("Username");

                    b.HasIndex("Username1");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("chit_chat_be.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateOnly>("JoinDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("chit_chat_be.Models.Token", b =>
                {
                    b.HasOne("chit_chat_be.Models.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("Username1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("chit_chat_be.Models.User", b =>
                {
                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
