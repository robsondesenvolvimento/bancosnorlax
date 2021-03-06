// <auto-generated />
using BancoSnorlax.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BancoSnorlax.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210616045654_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("BancoSnorlax.Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Agency")
                        .HasColumnType("INTEGER");

                    b.Property<double>("NegativeSale")
                        .HasColumnType("REAL");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Sale")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
