using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Starx.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        public List<Servis> Servis { get; set; }
    }
}
