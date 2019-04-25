﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamManagement.Models;

namespace TeamManagement.Migrations
{
    [DbContext(typeof(TeamManagementContext))]
    partial class TeamManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("TeamManagement.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("MemberID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("TeamManagement.Models.Task", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("TaskDec");

                    b.Property<string>("TaskName");

                    b.HasKey("TaskID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TeamManagement.Models.TasksMembers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignmentDes");

                    b.Property<int>("MemberID");

                    b.Property<int?>("MemberRole");

                    b.Property<int>("TaskID");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.HasIndex("TaskID");

                    b.ToTable("TasksMembers");
                });

            modelBuilder.Entity("TeamManagement.Models.TasksMembers", b =>
                {
                    b.HasOne("TeamManagement.Models.Member", "Member")
                        .WithMany("TaskMembers")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TeamManagement.Models.Task", "Task")
                        .WithMany("TaskMembers")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
