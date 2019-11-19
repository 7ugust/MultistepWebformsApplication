using System.ComponentModel.DataAnnotations;

namespace WebformsApplication.Models
{
    public class Person
    {
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

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