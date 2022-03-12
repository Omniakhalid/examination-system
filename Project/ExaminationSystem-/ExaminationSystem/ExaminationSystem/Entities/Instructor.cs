﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Entities
{
    [Table("Instructor")]
    public partial class Instructor
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [Column("inst_id")]
        public int InstId { get; set; }
        [Column("inst_name")]
        [StringLength(50)]
        public string InstName { get; set; }
        [Column("dept_id")]
        public int DeptId { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.Instructors))]
        public virtual Department Dept { get; set; }

        [ForeignKey("InstId")]
        [InverseProperty(nameof(Course.Insts))]
        public virtual ICollection<Course> Courses { get; set; }
    }
}