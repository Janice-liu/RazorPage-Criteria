using System.Collections.Generic;
using RazorPage.Core.Models;
using RazorPage.Core.Repos;
using RazorPage.Data.Store;
using Zebra;

namespace RazorPage.Repos
{
    using M = Goods;
    public class GoodsRepo : TvpRepoBase<Zebra_DBDataContext>, IGoodsRepo
    {
        public GoodsRepo(IDataContextFactory<Zebra_DBDataContext> dataContextFactory) : base(dataContextFactory)
        {
        }

        public IReadOnlyList<M> Get(M.Criteria criteria)
        => OnFunction(x=>criteria.ApplyTo(x.JaniceGoods_Raw).OrderBy(criteria.OrderByName).MapToReadOnlyList<M>());

        public string Operate(M.CreationSpec spec)
            => OnAction(x => x.JaniceGoods_Operate(spec.ToTvp()));
    }
}
