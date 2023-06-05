using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Display(Name="First Name")]
        [StringLength(50)]
        [Column("FirstName")]//字段名,不写这个的话默认生成的字段名和属性名一样
        public string FirstMidName { get; set; }
        [Display(Name="Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name="Full Name")]
        public string FullName//只有一个计算属性，数据库中不会生成列
        {
            get
            {
                return LastName + "," + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
