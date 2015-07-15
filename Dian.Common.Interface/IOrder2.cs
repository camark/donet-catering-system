﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;
using CSN.DotNetLibrary.EntityExpressions.Entitys;
using Dian.Common.Entity;
namespace Dian.Common.Interface
{
    public interface IOrder2 : IAppBizAvailableV2
    {
        DataTable GetOrderMainDataTable();
        List<OrderMainEntity2> GetOrderMainEntityList(OrderMainEntity2 condition_entity);
        void InsertOrderMainEntity(OrderMainEntity2 condition_entity);
        void UpdateOrderMainEntity(OrderMainEntity2 condition_entity);
        void DeleteOrderMainEntity(OrderMainEntity2 condition_entity);
        OrderMainEntity2 GetOrderMainEntity(int? id);

        DataTable GetOrderListDataTable();
        List<OrderListEntity2> GetOrderListEntityList(OrderListEntity2 condition_entity);
        void InsertOrderListEntity(OrderListEntity2 condition_entity);
        void UpdateOrderListEntity(OrderListEntity2 condition_entity);
        void DeleteOrderListEntity(OrderListEntity2 condition_entity);
        OrderListEntity2 GetOrderListEntity(int? id);
    }
}
