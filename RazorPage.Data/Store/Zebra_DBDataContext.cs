﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RazorPage.Data.Store
{
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Data;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.ComponentModel;
    using System;


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "Zebra_DB")]
    public partial class Zebra_DBDataContext : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region 可扩展性方法定义
        partial void OnCreated();
        #endregion


        public Zebra_DBDataContext(string connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public Zebra_DBDataContext(System.Data.IDbConnection connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public Zebra_DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public Zebra_DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.JaniceGoods$Raw", IsComposable = true)]
        public IQueryable<JaniceGoods_RawResult> JaniceGoods_Raw()
        {
            return this.CreateMethodCallQuery<JaniceGoods_RawResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.JaniceGoods$Operate")]
        public void JaniceGoods_Operate([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(MAX)")] string data)
        {
            this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), data);
        }
    }

    public partial class JaniceGoods_RawResult
    {

        private string _ID;

        private string _GoodsName;

        private decimal _GoodsPrice;

        public JaniceGoods_RawResult()
        {
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", DbType = "NVarChar(32) NOT NULL", CanBeNull = false)]
        public string ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_GoodsName", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string GoodsName
        {
            get
            {
                return this._GoodsName;
            }
            set
            {
                if ((this._GoodsName != value))
                {
                    this._GoodsName = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_GoodsPrice", DbType = "Decimal(18,2) NOT NULL")]
        public decimal GoodsPrice
        {
            get
            {
                return this._GoodsPrice;
            }
            set
            {
                if ((this._GoodsPrice != value))
                {
                    this._GoodsPrice = value;
                }
            }
        }
    }
}
#pragma warning restore 1591
