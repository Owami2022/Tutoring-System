﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TBHAcademy.Data;

namespace TBHAcademy.Migrations
{
    [DbContext(typeof(TBHAcademyContext))]
    [Migration("20221017124604_Update-Marks Table")]
    partial class UpdateMarksTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("MyPicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TBHAcademy.Models.Announcements", b =>
                {
                    b.Property<int>("AnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnnouncementId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("TBHAcademy.Models.AssignModules", b =>
                {
                    b.Property<int>("AssignedID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAssigned")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int?>("ModulesModuleId")
                        .HasColumnType("int");

                    b.Property<string>("TBHAcademyUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TutorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssignedID");

                    b.HasIndex("ModulesModuleId");

                    b.HasIndex("TBHAcademyUserId");

                    b.ToTable("AssignModules");
                });

            modelBuilder.Entity("TBHAcademy.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("TBHAcademy.Models.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignId")
                        .HasColumnType("int");

                    b.Property<int?>("AssignModulesAssignedID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Document1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Document2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Document3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Document4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Document5")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentDescription3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentDescription4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentDescription5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDescription3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDescription4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDescription5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContentId");

                    b.HasIndex("AssignModulesAssignedID");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("TBHAcademy.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("TBHAcademy.Models.Enroll", b =>
                {
                    b.Property<int>("EnrolledID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateErolled")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<string>("StudentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TBHAcademyUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EnrolledID");

                    b.HasIndex("TBHAcademyUserId");

                    b.ToTable("Enroll");
                });

            modelBuilder.Entity("TBHAcademy.Models.FAQ", b =>
                {
                    b.Property<int>("FAQId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FAQId");

                    b.ToTable("fAQs");
                });

            modelBuilder.Entity("TBHAcademy.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("TBHAcademy.Models.Mark_Capture", b =>
                {
                    b.Property<int>("MarkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfAssessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("Overall_Mark")
                        .HasColumnType("int");

                    b.Property<string>("StudentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mark_Obtained")
                        .HasColumnType("int");

                    b.HasKey("MarkID");

                    b.ToTable("Mark_Capture");
                });

            modelBuilder.Entity("TBHAcademy.Models.Marks", b =>
                {
                    b.Property<int>("MarksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("MarksComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarksDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int?>("ModulesModuleId")
                        .HasColumnType("int");

                    b.Property<int>("ObtainedMark")
                        .HasColumnType("int");

                    b.Property<int>("OverallMarks")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("MarksId");

                    b.HasIndex("CommentId");

                    b.HasIndex("ModulesModuleId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("TBHAcademy.Models.Modules", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("ModuleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.HasIndex("CourseId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("TBHAcademy.Models.ScheduleMeeting", b =>
                {
                    b.Property<int>("ScheduleMeetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TBHAcademyUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ScheduleMeetingID");

                    b.HasIndex("TBHAcademyUserId");

                    b.ToTable("ScheduleMeeting");
                });

            modelBuilder.Entity("TBHAcademy.Models.TeamMark", b =>
                {
                    b.Property<int>("Teamid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamFour")
                        .HasColumnType("int");

                    b.Property<int>("TeamOne")
                        .HasColumnType("int");

                    b.Property<int>("TeamThree")
                        .HasColumnType("int");

                    b.Property<int>("TeamTwo")
                        .HasColumnType("int");

                    b.HasKey("Teamid");

                    b.ToTable("TeamMark");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TBHAcademy.Models.AssignModules", b =>
                {
                    b.HasOne("TBHAcademy.Models.Modules", "Modules")
                        .WithMany()
                        .HasForeignKey("ModulesModuleId");

                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", "TBHAcademyUser")
                        .WithMany()
                        .HasForeignKey("TBHAcademyUserId");

                    b.Navigation("Modules");

                    b.Navigation("TBHAcademyUser");
                });

            modelBuilder.Entity("TBHAcademy.Models.Content", b =>
                {
                    b.HasOne("TBHAcademy.Models.AssignModules", "AssignModules")
                        .WithMany()
                        .HasForeignKey("AssignModulesAssignedID");

                    b.Navigation("AssignModules");
                });

            modelBuilder.Entity("TBHAcademy.Models.Course", b =>
                {
                    b.HasOne("TBHAcademy.Models.Faculty", "Faculty")
                        .WithMany("Courses")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("TBHAcademy.Models.Enroll", b =>
                {
                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", "TBHAcademyUser")
                        .WithMany()
                        .HasForeignKey("TBHAcademyUserId");

                    b.Navigation("TBHAcademyUser");
                });

            modelBuilder.Entity("TBHAcademy.Models.Marks", b =>
                {
                    b.HasOne("TBHAcademy.Models.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TBHAcademy.Models.Modules", "Modules")
                        .WithMany()
                        .HasForeignKey("ModulesModuleId");

                    b.Navigation("Comment");

                    b.Navigation("Modules");
                });

            modelBuilder.Entity("TBHAcademy.Models.Modules", b =>
                {
                    b.HasOne("TBHAcademy.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("TBHAcademy.Models.ScheduleMeeting", b =>
                {
                    b.HasOne("TBHAcademy.Areas.Identity.Data.TBHAcademyUser", "TBHAcademyUser")
                        .WithMany()
                        .HasForeignKey("TBHAcademyUserId");

                    b.Navigation("TBHAcademyUser");
                });

            modelBuilder.Entity("TBHAcademy.Models.Faculty", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
