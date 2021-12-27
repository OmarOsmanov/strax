using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Starx.Models
{
    public class Servis
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required(ErrorMessage = "title yaz")]
        public string SubTitle { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [ForeignKey("Category"), Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
