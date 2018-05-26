using System;
using Microsoft.EntityFrameworkCore;
using RazorPage.WebUI2.Model;

namespace RazorPage.WebUI.Data
{
    public class RazorPageDbContex:DbContext
    {
        public RazorPageDbContex(DbContextOptions<RazorPageDbContex> options):base(options)
        {
        }

        public DbSet<Goods> Goods { get; set; }
    }
}
