﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi.Models;

namespace WebApi.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebApi.Models.QSelectOutOfFour", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("answerString")
                        .HasColumnType("text");

                    b.Property<string>("lesson")
                        .HasColumnType("text");

                    b.Property<string>("questionType")
                        .HasColumnType("text");

                    b.Property<string>("task")
                        .HasColumnType("text");

                    b.Property<string>("variant1")
                        .HasColumnType("text");

                    b.Property<string>("variant2")
                        .HasColumnType("text");

                    b.Property<string>("variant3")
                        .HasColumnType("text");

                    b.Property<string>("variant4")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("QSelectOutOfFours");
                });

            modelBuilder.Entity("WebApi.Models.QSelectOutOfFourDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("answerString")
                        .HasColumnType("text");

                    b.Property<string>("task")
                        .HasColumnType("text");

                    b.Property<string>("variant1")
                        .HasColumnType("text");

                    b.Property<string>("variant2")
                        .HasColumnType("text");

                    b.Property<string>("variant3")
                        .HasColumnType("text");

                    b.Property<string>("variant4")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("QSelectOutOfFourDTO");
                });

            modelBuilder.Entity("WebApi.Models.QSelectOutOfThreePic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("answerString")
                        .HasColumnType("text");

                    b.Property<string>("lesson")
                        .HasColumnType("text");

                    b.Property<string>("questionType")
                        .HasColumnType("text");

                    b.Property<string>("task")
                        .HasColumnType("text");

                    b.Property<string>("variant1")
                        .HasColumnType("text");

                    b.Property<string>("variant2")
                        .HasColumnType("text");

                    b.Property<string>("variant3")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("QSelectOutOfThreePics");
                });

            modelBuilder.Entity("WebApi.Models.QWriteRightAnswer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("answerString")
                        .HasColumnType("text");

                    b.Property<string>("lesson")
                        .HasColumnType("text");

                    b.Property<string>("questionType")
                        .HasColumnType("text");

                    b.Property<string>("task")
                        .HasColumnType("text");

                    b.Property<string>("variant1")
                        .HasColumnType("text");

                    b.Property<string>("variant2")
                        .HasColumnType("text");

                    b.Property<string>("variant3")
                        .HasColumnType("text");

                    b.Property<string>("variant4")
                        .HasColumnType("text");

                    b.Property<string>("variant5")
                        .HasColumnType("text");

                    b.Property<string>("variant6")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("QWriteRightAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
