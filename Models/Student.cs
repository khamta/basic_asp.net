using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Basic_asp01.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("ຊື່ນັກສຶກສາ")]
        public string Name { get; set; }
        [DisplayName("ຄະແນນສອບ")]
        [Range(0,100)]
        public int Score { get; set; }
    }
}
