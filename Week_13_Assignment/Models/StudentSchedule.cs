﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Week_13_Assignment.Models
{
    public partial class StudentSchedule
    {
        public int ScheduleId { get; set; }
        public string Grade { get; set; }
        public int? StudentId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}