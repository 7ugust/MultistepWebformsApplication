using System.ComponentModel.DataAnnotations;

namespace WebformsApplication.Models
{
    public class PersonBasicInfo
    {
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }


    }
}