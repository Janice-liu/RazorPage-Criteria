using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.WebUI.Data;

namespace RazorPage.WebUI.Pages.Goods
{
    public class CreateModel : PageModel
    {
        public RazorPageDbContex _razorPageDbContex;

        public CreateModel(RazorPageDbContex razorPageDbContex)
        {
            _razorPageDbContex = razorPageDbContex;
        }

        [BindProperty]
        public WebUI2.Model.Goods InputGoods { get; set; }

        public IActionResult OnGet(int? id=0)
        {
            var model=new WebUI2.Model.Goods();
            if (id > 0)
            {
                model = _razorPageDbContex.Goods.FirstOrDefault(x=>x.Id==id);
            }
            InputGoods = model;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var goods = new WebUI2.Model.Goods { Name = InputGoods .Name,Price = InputGoods.Price};
            _razorPageDbContex.Goods.Add(goods);
            _razorPageDbContex.SaveChanges();
            return RedirectToPage("/Goods/Index");
        }

        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid)
                return Page();
            var model = _razorPageDbContex.Goods.FirstOrDefault(x => x.Id == InputGoods.Id);
            if (model == null)
            {
                ModelState.AddModelError(string.Empty,"无效数据，无法修改！");
                return Page();
            }
            model.Name = InputGoods.Name;
            model.Price = InputGoods.Price;
            _razorPageDbContex.Goods.Update(model);
            _razorPageDbContex.SaveChanges();
            return RedirectToPage("/Goods/Index");
        }
    }
}