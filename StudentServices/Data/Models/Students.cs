using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentServices.Data.Models
{
    public class Students
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Required]
        [MaxLength(3)]
        public int Age { get; set; }
    }
}
