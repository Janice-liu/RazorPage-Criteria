using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using RazorPage.Core.DataContract;
using RazorPage.Core.Models;

namespace RazorPage.Core.Mapping
{
   public class ZebraMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<iGoods, Goods>();
                }
            );
        }
    }
}
