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
        public static string GET_AD_DETAILS = "/v5/p2p/item/info";
        public static string UPDATE_AD = "/v5/p2p/item/update";
        public static string REMOVE_AD = "/v5/p2p/item/cancel";
        public static string GET_ORDERS = "/v5/p2p/order/simplifyList";
        public static string GET_PENDING_ORDERS = "/v5/p2p/order/pending/simplifyList";
        public static string GET_COUNTERPARTY_INFO = "/v5/p2p/user/order/personal/info";
        public static string GET_ORDER_DETAILS = "/v5/p2p/order/info";
        public static string RELEASE_ASSETS = "/v5/p2p/order/finish";
        public static string MARK_AS_PAID = "/v5/p2p/order/pay";
        public static string GET_CHAT_MESSAGES = "/v5/p2p/order/message/listpage";
        public static string UPLOAD_CHAT_FILE = "/v5/p2p/oss/upload_file";
        public static string SEND_CHAT_MESSAGE = "/v5/p2p/order/message/send";
        public static string POST_NEW_AD = "/v5/p2p/item/create";
        public static string GET_ONLINE_ADS = "/v5/p2p/item/online";
        public static string GET_USER_PAYMENT_TYPES = "/v5/p2p/user/payment/list";
    }
}
