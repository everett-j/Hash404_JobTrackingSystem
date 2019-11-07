﻿// <auto-generated />
using System;
using Claymore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Claymore.Migrations
{
    [DbContext(typeof(YourContext))]
    partial class YourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Claymore.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PostingID");

                    b.Property<int>("UserId");

                    b.HasKey("GuestId");

                    b.HasIndex("PostingID");

                    b.HasIndex("UserId");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("Claymore.Models.PostingEvent", b =>
                {
                    b.Property<int>("PostingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<bool>("ConfirmationEmail");

                    b.Property<string>("ContactName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateApply");

                    b.Property<DateTime>("Denied");

                    b.Property<bool>("DeniedCall");

                    b.Property<bool>("DeniedEmail");

                    b.Property<bool>("DeniedLetter");

                    b.Property<string>("DeniedNotes");

                    b.Property<DateTime>("Interview");

                    b.Property<bool>("InterviewCall");

                    b.Property<bool>("InterviewEmail");

                    b.Property<bool>("InterviewLetter");

                    b.Property<string>("InterviewNotes");

                    b.Property<string>("JobLink");

                    b.Property<string>("JobPosting");

                    b.Property<string>("Notes");

                    b.Property<bool>("PhoneCall");

                    b.Property<bool>("PhoneEmail");

                    b.Property<DateTime>("PhoneInterview");

                    b.Property<bool>("PhoneLetter");

                    b.Property<string>("PhoneNotes");

                    b.Property<DateTime>("PhoneScreen");

                    b.Property<string>("PositionTitle");

                    b.Property<string>("RecruiterName");

                    b.Property<bool>("ScreenCall");

                    b.Property<bool>("ScreenEmail");

                    b.Property<bool>("ScreenLetter");

                    b.Property<string>("ScreenNotes");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("PostingId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Postings");
                });

            modelBuilder.Entity("Claymore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Claymore.Models.Guest", b =>
                {
                    b.HasOne("Claymore.Models.PostingEvent", "Posting")
                        .WithMany("Guests")
                        .HasForeignKey("PostingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Claymore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Claymore.Models.PostingEvent", b =>
                {
                    b.HasOne("Claymore.Models.User", "Creator")
                        .WithMany("CreatedActivities")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
