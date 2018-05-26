using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Core.Repos;

namespace RazorPage.WebUI.Pages.Goods
{
    using M=Goods;
    public class GoodsListModel : PageModel
    {
        private readonly IGoodsRepo _goodsRepo;

        public GoodsListModel(IGoodsRepo goodsRepo)
        {
            _goodsRepo = goodsRepo;
        }

        public List<Core.Models.Goods> Goodses { get; set; }

        public void OnGet()
        {
            var criteria =new Core.Models.Goods.Criteria();
            Goodses = _goodsRepo.Get(criteria).ToList();
        }
    }
}