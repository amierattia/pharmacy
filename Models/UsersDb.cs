using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UsersDb
    {
        [Key]
        public string? username { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? PassWord { get; set; }
    }
}
