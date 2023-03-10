// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6_WebApi.Models
{
    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
        public int CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CourseName { get; set; }
        
        [NotMapped]
        public Geometry Location { get; set; }
        public int? TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        [InverseProperty("Courses")]
        public virtual Teacher Teacher { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}