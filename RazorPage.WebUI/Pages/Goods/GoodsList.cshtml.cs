using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Core.Repos;

namespace RazorPage.WebUI.Pages.Goods
{
    using M= Core.Models.Goods;
    public class GoodsListModel : PageModel
    {
        private readonly IGoodsRepo _goodsRepo;

        public GoodsListModel(IGoodsRepo goodsRepo)
        {
            _goodsRepo = goodsRepo;
        }

        public List<M> Goodses { get; set; }

        public void OnGet()
        {
            var criteria =new M.Criteria(string.Empty, string.Empty, "CreateDate");
            Goodses = _goodsRepo.Get(criteria).ToList();
        }

        public void OnPostSearch(string searchValue)
        {
            var criteria = new Core.Models.Goods.Criteria(string.Empty, searchValue, "CreateDate");
            Goodses = _goodsRepo.Get(criteria).ToList();
        }

        public IActionResult OnPostDelete(string id)
        {
            var criteria= new M.Criteria(id,string.Empty, "CreateDate");
            var goodses = _goodsRepo.Get(criteria);
            if (goodses == null || goodses.Count == 0)
            {
                ModelState.AddModelError(string.Empty,"删除的数据无效！");
                return Page();
            }
            var spec = new M.CreationSpec
            {
                Id = id,
                GoodsName = string.Empty,
                GoondsPrice = 0,
                Operate = "D"
            };
            _goodsRepo.Operate(spec);
            return RedirectToPage("/Goods/GoodsList");
        }
    }
}