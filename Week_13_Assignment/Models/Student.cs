﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Week_13_Assignment.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentSchedules = new HashSet<StudentSchedule>();
        }

        public int StudentId { get; set; }
        public string StudFirstName { get; set; }
        public string StudLastName { get; set; }
        public string StudMajor { get; set; }
        public string StudPhone { get; set; }

        public virtual ICollection<StudentSchedule> StudentSchedules { get; set; }
    }
}