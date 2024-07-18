using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ClsModel
    {

        public string? Productname { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
