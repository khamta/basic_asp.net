using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Basic_asp01.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="ກະລຸນາປ້ອນຊື່ນັກສຶກສາ")]
        [DisplayName("ຊື່ນັກສຶກສາ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ກະລຸນາປ້ອນຄະແນນ")]
        [DisplayName("ຄະແນນສອບ")]
        [Range(0,100, ErrorMessage ="ກະລຸນາປ້ອນຄະແນນໃນຊ່ວງ 0-100")]
        public int Score { get; set; }
    }
}
