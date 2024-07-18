using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class returnesModels
    {
        public string? RName {get ; set;}
        [Key]
        public int Id { get; set; }
        public int RQuantity {get ; set;}
    }
}
