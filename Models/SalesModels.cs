using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{


    public class SalesModels
    {
        [Key]
        public int SId { get; set; }

        [Required]
        public string? SAlesName { get; set; }
        [Required]

        public int SAlesQuantity { get; set; }
        [Required]

        public decimal Salary { get; set; }

        // Add a foreign key to reference Customer
        public int CustomerID { get; set; }
       // public Cstomer? Customer { get; set; } // Navigation property
    }


}
