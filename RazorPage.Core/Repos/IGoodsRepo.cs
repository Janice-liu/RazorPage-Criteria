using System;
using System.Collections.Generic;

namespace RazorPage.Core.Repos
{
    using M = Models.Goods;
    public interface IGoodsRepo:ITvpRepo
    {
        IReadOnlyList<M> Get(M.Criteria criteria);

        void Add(M.CreationSpec spec);
    }
}
