﻿// <auto-generated />
using Ashish_P_301089716.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Ashish_P_301089716.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200321013310_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ashish_P_301089716.Models.Clubs", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LeagueParticipated");

                    b.Property<string>("NameOfClub");

                    b.Property<string>("NameOfCoach");

                    b.Property<int>("NumberOfPlayers");

                    b.Property<string>("President");

                    b.Property<int>("StadiumCapacity");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Ashish_P_301089716.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClubId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("MatchPlayer");

                    b.Property<string>("Name");

                    b.Property<string>("Nationality");

                    b.Property<decimal>("age");

                    b.HasKey("PlayerId");

                    b.HasIndex("ClubId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Ashish_P_301089716.Models.Player", b =>
                {
                    b.HasOne("Ashish_P_301089716.Models.Clubs", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId");
                });
#pragma warning restore 612, 618
        }
    }
}
