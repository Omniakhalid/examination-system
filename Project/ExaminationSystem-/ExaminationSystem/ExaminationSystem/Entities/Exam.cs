// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Entities
{
    [Table("Exam")]
    public partial class Exam
    {
        public Exam()
        {
            QExStuds = new HashSet<QExStud>();
        }

        [Key]
        [Column("exam_id")]
        public int ExamId { get; set; }
        [Column("duration")]
        public TimeSpan? Duration { get; set; }
        [Column("course_id")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("Exams")]
        public virtual Course Course { get; set; }
        [InverseProperty(nameof(QExStud.Ex))]
        public virtual ICollection<QExStud> QExStuds { get; set; }
    }
}