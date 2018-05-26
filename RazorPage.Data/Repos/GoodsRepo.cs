using RazorPage.Core.Models;
using RazorPage.Core.Repos;
using RazorPage.Data.Store;
using System.Collections.Generic;

namespace RazorPage.Data.Repos
{
    using M = Goods;
    public class GoodsRepo : TvpRepoBase<Zebra_DBDataContext>, IGoodsRepo
    {
        public GoodsRepo(IDataContextFactory<Zebra_DBDataContext> dataContextFactory) : base(dataContextFactory)
        {
        }

        public IReadOnlyList<M> Get(M.Criteria criteria)
        => OnFunction(x=>criteria.ApplyTo(x.JaniceGoods_Raw).MapToReadOnlyList<M>());

        public void Add(M.CreationSpec spec)
        =>Actions(m=>m.)
    }
}
