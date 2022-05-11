using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models
{
    public class Images
    {
        [Key]
        public int IdImages { get; set; }
        [Required]
        public Guid Guid { get; set; }

        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
