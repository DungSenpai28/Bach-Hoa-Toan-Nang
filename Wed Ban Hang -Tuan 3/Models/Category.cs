using System.ComponentModel.DataAnnotations;

namespace Wed_Ban_Hang__Tuan_3.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        public string? Description  { get; set; }

        public List<Product>? Products { get; set; }
    }

}
