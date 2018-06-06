using System;

namespace RazorPage.Core.DataContract
{
    public interface iGoods:IEntity<string>
    {
        string GoodsName { get; }

        decimal GoodsPrice { get; }

        DateTime CreateDate { get; }
    }
}
