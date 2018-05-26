using System.ComponentModel.DataAnnotations;

namespace RazorPage.WebUI2.Model
{
    public class Goods
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "名称")]
        //[StringLength(10,ErrorMessage = "")]
        public string Name { get; set; }
        
        [Required]
        //[DataType(DataType.Custom)]
        [Display(Name = "价格")]
        public decimal Price { get; set; }
    }
}
