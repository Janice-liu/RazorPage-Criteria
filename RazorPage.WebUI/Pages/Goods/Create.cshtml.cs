using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Core.Repos;

namespace RazorPage.WebUI.Pages.Goods
{
    public class CreateModel : PageModel
    {
        private readonly IGoodsRepo _goodsRepo;

        public CreateModel(IGoodsRepo goodsRepo)
        {
            _goodsRepo = goodsRepo;
        }

        [BindProperty]
        public Models.Goods Goods { get; set; }

        public IActionResult OnGet()
        {
            Goods=new Models.Goods();
            return Page();
        }

        public IActionResult OnPost()
        {
            var spec = new Core.Models.Goods.CreationSpec
            {
                Id = Guid.NewGuid().ToString("N"),
                GoodsName = Goods.Name,
                GoondsPrice = Goods.Price
            };
            return Page();
        }
    }
}