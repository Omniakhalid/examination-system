﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Entities
{
    public partial class get_all_questionsResult
    {
        public int Q_id { get; set; }
        public string Question { get; set; }
        public string Q_type { get; set; }
        public string Q_model_answer { get; set; }
        public int? grade { get; set; }
        public int course_id { get; set; }
    }
}
