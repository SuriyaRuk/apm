﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample.ElasticApm.Persistence.Context;

namespace Sample.ElasticApm.Persistence.Migrations;

[DbContext(typeof(SampleDataContext))]
partial class SampleDataContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .UseIdentityColumns()
            .HasAnnotation("Relational:MaxIdentifierLength", 128)
            .HasAnnotation("ProductVersion", "5.0.4");

        modelBuilder.Entity("Sample.ElasticApm.Persistence.Entity.Pessoa", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("DataNascimento")
                    .HasColumnType("datetime2");

                b.Property<string>("Endereco")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Pessoas");
            });
#pragma warning restore 612, 618
    }
}