using System;
using System.Collections.Generic;
using System.Text;
using QA.SMELL;
using RazorPage.Core.DataContract;
using Zebra;

namespace RazorPage.Core.Models
{
    using iM = iGoods;
    using M = Goods;
    using S=String;
    public partial class Goods : Entity<M, string>
    {
        #region { Holder }
        
        public S GoodsName { get; set; }
        
        public decimal GoodsPrice { get; set; }

        public DateTime CreateDate { get; set; }

        #endregion

        #region { Criteria }

        public class Criteria : EntityCriteria<iM, string>
        {
            public S Id { get;}
            public S GoodsName { get; }

            public S OrderByName { get; }

            public Criteria(string id,string goodsName,string orderByName)
            {
                ID = id;
                GoodsName = goodsName;
                OrderByName = orderByName;
            }

            protected override void OnCollect(ICriteriaPool<iM> pool)
            {
                pool.Add(x => x.ID==Id, Id.IsTruthy());
                pool.Add(x => x.GoodsName.Contains(GoodsName), GoodsName.IsTruthy());
            }
        }

        #endregion

        #region { Spec }

        public class CreationSpec
        {
            public S Id { get; set; }

            public S GoodsName { get; set; }

            public decimal GoondsPrice { get; set; }

            public S Operate { get; set; }

            public S ToTvp()
                => at.Tvp.Field.Join(Id, GoodsName, GoondsPrice, Operate);

        }

        #endregion
    }
}
