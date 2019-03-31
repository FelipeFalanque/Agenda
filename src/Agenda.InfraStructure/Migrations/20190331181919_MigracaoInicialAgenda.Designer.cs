﻿// <auto-generated />
using Agenda.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Agenda.InfraStructure.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190331181919_MigracaoInicialAgenda")]
    partial class MigracaoInicialAgenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agenda.ApplicationCore.Entities.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Telefone")
                        .HasMaxLength(20);

                    b.HasKey("ContatoId");

                    b.ToTable("Contatos");
                });
#pragma warning restore 612, 618
        }
    }
}
