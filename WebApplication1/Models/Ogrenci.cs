using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Öğrenci Adı")]
        public string OgrenciName { get; set; }
        [DisplayName("Öğrenci Soyadı")]
        public string OgrenciLastName { get; set; }
        [DisplayName("Öğrenci Numarası")]
        [Range(1, 2000)]
        public int OgrenciNo { get; set; }
    }
}
