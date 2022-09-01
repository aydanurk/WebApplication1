using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Ogretmen
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Öğretmen Adı")]
        public string OgretmenName { get; set; }
        [DisplayName("Öğretmen Soyadı")]
        public string OgretmenLastName { get; set; }
    }
}
