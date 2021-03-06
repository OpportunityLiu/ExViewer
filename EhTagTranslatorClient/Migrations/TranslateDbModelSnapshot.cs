﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EhTagTranslatorClient.Model;
using ExClient.Tagging;

namespace EhTagTranslatorClient.Migrations
{
    [DbContext(typeof(TranslateDb))]
    partial class TranslateDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6");

            modelBuilder.Entity("EhTagTranslatorClient.Record", b =>
                {
                    b.Property<int>("Namespace");

                    b.Property<string>("Original");

                    b.Property<string>("Introduction");

                    b.Property<string>("Translated");

                    b.HasKey("Namespace", "Original");

                    b.ToTable("Table");
                });
        }
    }
}
