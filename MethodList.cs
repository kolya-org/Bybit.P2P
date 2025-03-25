using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P
{
    internal class MethodList
    {
        public static string GET_CURRENT_BALANCE = "/v5/asset/transfer/query-account-coins-balance";
        public static string GET_ACCOUNT_INFORMATION = "/v5/p2p/user/personal/info";
        public static string GET_ADS_LIST = "/v5/p2p/item/personal/list";
    }
}
