// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF6_WebApi.Models
{
    [Keyless]
    public partial class ViewStudentCourse
    {
        [Column("StudentID")]
        public int StudentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CourseName { get; set; }
    }
}