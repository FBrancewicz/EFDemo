using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Street { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(6)]
        [Column(TypeName = "varchar(6)")]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(2)]
        public string Country { get; set; }


    }
}
