using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.WebUI.Models
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
