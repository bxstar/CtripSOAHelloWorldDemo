using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ctrip.Fin.API.Data.Model;

namespace ConsoleHelloWorldService.InterfaceDefine
{
    /// <summary>
    /// 福利平台，订单接口
    /// </summary>
    public interface IFuliOrderServiceDefine
    {
        /// <summary>
        /// 保存余额充值订单信息
        /// </summary>
        /// <param name="vid">访问跟踪ID</param>
        /// <param name="bModel">余额充值订单信息</param>
        /// <param name="iModel">发票信息列表</param>
        /// <returns>带订单号的余额充值订单及详情信息</returns>
        BalanceRechargeOrderModel AddBalanceRechargeOrder(int? vid, BalanceRechargeOrderModel BalanceRechargeOrder, List<InvoiceModel> Invoice);


        Tuple<BalanceRechargeOrderModel,List<InvoiceModel>> AddBalanceRechargeOrder(BalanceRechargeOrderModel BalanceRechargeOrder, List<InvoiceModel> Invoice);

        /// <summary>
        /// 两个返回值的函数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        Tuple<int, long> Add(int a, long b);
    }
}
