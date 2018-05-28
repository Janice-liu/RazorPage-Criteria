using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult OnGet(string id="")
        {
            Goods=new Models.Goods();
            if (!string.IsNullOrEmpty(id))
            {
                var criteria = new Core.Models.Goods.Criteria(id,string.Empty);
                var goods = _goodsRepo.Get(criteria).FirstOrDefault();
                Goods = new Models.Goods
                {
                    Id = goods?.ID,
                    Name = goods?.GoodsName,
                    Price = goods?.GoodsPrice ?? 0
                };
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var page = OperateGoods();
            return page;
        }

        private IActionResult OperateGoods()
        {
            if (!ModelState.IsValid)
                return Page();
            var spec = new Core.Models.Goods.CreationSpec
            {
                Id = Goods.Id,
                GoodsName = Goods.Name,
                GoondsPrice = Goods.Price,
                Operate = "U"
            };
            _goodsRepo.Operate(spec);
            return RedirectToPage("/Goods/GoodsList");
        }

        public IActionResult OnPostEdit()
        {
            var page=OperateGoods();
            return page;
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/Goods/GoodsList");
        }
    }
}