using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Cstomer
    {
        [Key]
        public int CustomerID { get; set; }
        public String? CustomerName { get; set; }
        public int CustomerPhone { get; set; }

        // Navigation property to SalesModels
        public ICollection<SalesModels> Sales { get; set; }
    }


}
