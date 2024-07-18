using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StokeModel
    {
        public string? sName { get; set; }
        [Key]
        [ForeignKey("SId")]
        public int Id { get; set; }
        public int SQuantity { get; set; }
    }
}
