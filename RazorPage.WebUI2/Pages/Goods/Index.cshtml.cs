using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RazorPage.WebUI.Data;

namespace RazorPage.WebUI.Pages.Goods
{
    public class IndexModel : PageModel
    {
        public RazorPageDbContex _razorPageDbContex;

        public IndexModel(RazorPageDbContex razorPageDbContex)
        {
            _razorPageDbContex = razorPageDbContex;
        }

        public List<WebUI2.Model.Goods> Goodses { get; set; }

        public void OnGet()
        {
            var goodsData = _razorPageDbContex.Goods.ToList();
            //Goodses = goodsData.Select(x => new Model.Goods
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    Price = x.Price
            //}).ToList();
            Goodses = goodsData;
        }
    }
}