﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Entities
{
    public partial class get_examResult
    {
        public int exam_id { get; set; }
        public TimeSpan? duration { get; set; }
        public int course_id { get; set; }
    }
}
