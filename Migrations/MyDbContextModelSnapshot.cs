﻿// <auto-generated />
using EFCoreRepro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreRepro.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreRepro.Models.TestEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("SubStatus")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("TestEntity", t =>
                        {
                            t.HasCheckConstraint("CK_TestEntity_TestEnum2", "(Status = 'Status1' AND SubStatus IN ('Status1_SubStatus1','Status1_SubStatus2','Status1_SubStatus3','Status1_SubStatus4','Status1_SubStatus5','Status1_SubStatus6') OR Status = 'Status2' AND SubStatus IN ('Status2_SubStatus1','Status2_SubStatus2','Status2_SubStatus3','Status2_SubStatus4')))");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
