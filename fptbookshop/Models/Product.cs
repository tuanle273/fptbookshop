using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fptbookshop.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { set; get; }
        
        public string Name { set; get; }
       
        public string Image { set; get; }
       
        public string Description { set; get; }
        public decimal Price { set; get; }
       

    }
}
