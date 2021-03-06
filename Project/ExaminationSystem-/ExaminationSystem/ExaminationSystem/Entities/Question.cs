// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Entities
{
    [Table("Question")]
    public partial class Question
    {
        public Question()
        {
            ExamChoices = new HashSet<ExamChoice>();
            QExStuds = new HashSet<QExStud>();
        }

        [Key]
        [Column("Q_id")]
        public int QId { get; set; }
        [Column("Question")]
        public string Question1 { get; set; }
        [Column("Q_type")]
        [StringLength(20)]
        public string QType { get; set; }
        [Column("Q_model_answer")]
        public string QModelAnswer { get; set; }
        [Column("grade")]
        public int? Grade { get; set; }
        [Column("course_id")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("Questions")]
        public virtual Course Course { get; set; }
        [InverseProperty(nameof(ExamChoice.QIdNavigation))]
        public virtual ICollection<ExamChoice> ExamChoices { get; set; }
        [InverseProperty(nameof(QExStud.QIdNavigation))]
        public virtual ICollection<QExStud> QExStuds { get; set; }
    }
}