using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]//默认只会识别ID字段为主键，加Key就代表该字段为主键
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name= "Office Location ")]
        public string Location { get; set; }
        public Instructor Instructor { get; set; }
    }
}
