using System.ComponentModel.DataAnnotations;

namespace WebformsApplication.Models
{
    public class PersonMoreInfo
    {
        [Required]
        public string street { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string country { get; set; }
        public string postalcode { get; set; }

        [Required]
        public string phone { get; set; }

    }
}