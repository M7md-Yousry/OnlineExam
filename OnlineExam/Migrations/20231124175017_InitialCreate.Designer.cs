﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineExam.Data;

#nullable disable

namespace OnlineExam.Migrations
{
    [DbContext(typeof(OnlineExamContext))]
    [Migration("20231124175017_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("OnlineExam.Models.Exams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answer1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer5")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<double>("Score")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
