﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ExaminationSystem.Entities;

namespace ExaminationSystem.Context
{
    public partial class ExamprojectContext : DbContext
    {
        public ExamprojectContext()
        {
        }

        public ExamprojectContext(DbContextOptions<ExamprojectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamChoice> ExamChoices { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<QExStud> QExStuds { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<StudCourse> StudCourses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P84ETB9\\MSSQLSERVER01;Initial Catalog=ExamProject;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).ValueGeneratedNever();

                entity.Property(e => e.CourseName).IsFixedLength();

                entity.HasMany(d => d.Insts)
                    .WithMany(p => p.Courses)
                    .UsingEntity<Dictionary<string, object>>(
                        "InstCourse",
                        l => l.HasOne<Instructor>().WithMany().HasForeignKey("InstId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Inst_course_Instructor"),
                        r => r.HasOne<Course>().WithMany().HasForeignKey("CourseId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Inst_course_Course"),
                        j =>
                        {
                            j.HasKey("CourseId", "InstId");

                            j.ToTable("Inst_course");

                            j.IndexerProperty<int>("CourseId").HasColumnName("course_id");

                            j.IndexerProperty<int>("InstId").HasColumnName("inst_id");
                        });
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.DeptName).IsFixedLength();
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.ExamId).ValueGeneratedNever();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Course");
            });

            modelBuilder.Entity<ExamChoice>(entity =>
            {
                entity.HasKey(e => new { e.QId, e.Choices });

                entity.HasOne(d => d.QIdNavigation)
                    .WithMany(p => p.ExamChoices)
                    .HasForeignKey(d => d.QId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_choices_Question");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.Property(e => e.InstId).ValueGeneratedNever();

                entity.Property(e => e.InstName).IsFixedLength();

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instructor_Department");
            });

            modelBuilder.Entity<QExStud>(entity =>
            {
                entity.HasKey(e => new { e.QId, e.ExId })
                    .HasName("PK_Q_ex_stud_1");

                entity.Property(e => e.StdAnswer).IsFixedLength();

                entity.HasOne(d => d.Ex)
                    .WithMany(p => p.QExStuds)
                    .HasForeignKey(d => d.ExId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Q_ex_stud_Exam");

                entity.HasOne(d => d.QIdNavigation)
                    .WithMany(p => p.QExStuds)
                    .HasForeignKey(d => d.QId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Q_ex_stud_Question");

                entity.HasOne(d => d.Stud)
                    .WithMany(p => p.QExStuds)
                    .HasForeignKey(d => d.StudId)
                    .HasConstraintName("FK_Q_ex_stud_Student");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QId).ValueGeneratedNever();

                entity.Property(e => e.QType).IsFixedLength();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Course");
            });

            modelBuilder.Entity<StudCourse>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.StudId });

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stud_course_Course");

                entity.HasOne(d => d.Stud)
                    .WithMany(p => p.StudCourses)
                    .HasForeignKey(d => d.StudId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stud_course_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.FName).IsFixedLength();

                entity.Property(e => e.LName).IsFixedLength();

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Department");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.TopicId).ValueGeneratedNever();

                entity.Property(e => e.TopicName).IsFixedLength();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Topic_Course");
            });

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}