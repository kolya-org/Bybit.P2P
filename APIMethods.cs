using Bybit.P2P.Models;
using Bybit.P2P.Models.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bybit.P2P
{
    public static class APIMethods
    {
        private static async Task<T> Call<T>(this APIClient api, string endpoint, HttpMethod method, object? req = null)
        {
            return await api.SendRequest<T>(endpoint, method, req);
        }

        private static async Task Call(this APIClient api, string endpoint, HttpMethod method, object? req = null)
        {
            await api.SendRequest<object>(endpoint, method, req);
        }

        public static Task<GetCurrentBalanceResponse> GetCurrentBalance(this APIClient api, object? req = null) =>
            api.Call<GetCurrentBalanceResponse>(MethodList.GET_CURRENT_BALANCE, HttpMethod.Get, req);

        public static Task<GetAccountInformationResponse> GetAccountInformation(this APIClient api, object? req = null) =>
            api.Call<GetAccountInformationResponse>(MethodList.GET_ACCOUNT_INFORMATION, HttpMethod.Post, req);

        public static Task<GetAdsListResponse> GetAdsList(this APIClient api, object? req = null) =>
            api.Call<GetAdsListResponse>(MethodList.GET_ADS_LIST, HttpMethod.Post, req);

        public static Task<Advertisement> GetAdDetails(this APIClient api, object? req = null) =>
            api.Call<Advertisement>(MethodList.GET_AD_DETAILS, HttpMethod.Post, req);

        public static Task<Generic2FA> UpdateAd(this APIClient api, object? req = null) =>
            api.Call<Generic2FA>(MethodList.UPDATE_AD, HttpMethod.Post, req);

        public static Task RemoveAd(this APIClient api, object? req = null) =>
            api.Call(MethodList.REMOVE_AD, HttpMethod.Post, req);

        public static Task<GetOrdersResponse> GetOrders(this APIClient api, object? req = null) =>
            api.Call<GetOrdersResponse>(MethodList.GET_ORDERS, HttpMethod.Post, req);

        public static Task<GetOrdersResponse> GetPendingOrders(this APIClient api, object? req = null) =>
            api.Call<GetOrdersResponse>(MethodList.GET_PENDING_ORDERS, HttpMethod.Post, req);

        public static Task<UserInfo> GetCounterpartyInfo(this APIClient api, object? req = null) =>
            api.Call<UserInfo>(MethodList.GET_COUNTERPARTY_INFO, HttpMethod.Post, req);

        public static Task<GetOrderDetailsResponse> GetOrderDetails(this APIClient api, object? req = null) =>
            api.Call<GetOrderDetailsResponse>(MethodList.GET_ORDER_DETAILS, HttpMethod.Post, req);

        public static Task ReleaseAssets(this APIClient api, object? req = null) =>
            api.Call(MethodList.RELEASE_ASSETS, HttpMethod.Post, req);

        public static Task MarkAsPaid(this APIClient api, object? req = null) =>
            api.Call(MethodList.MARK_AS_PAID, HttpMethod.Post, req);

        public static Task<GetChatMessagesResponse> GetChatMessages(this APIClient api, object? req = null) =>
            api.Call<GetChatMessagesResponse>(MethodList.GET_CHAT_MESSAGES, HttpMethod.Post, req);

        public static Task<UploadChatFileResponse> UploadChatFile(this APIClient api, object? req = null) =>
            api.Call<UploadChatFileResponse>(MethodList.UPLOAD_CHAT_FILE, HttpMethod.Put, req);

        public static Task SendChatMessage(this APIClient api, object? req = null) =>
            api.Call(MethodList.SEND_CHAT_MESSAGE, HttpMethod.Post, req);

        public static Task<Generic2FA> PostNewAd(this APIClient api, object? req = null) =>
            api.Call<Generic2FA>(MethodList.POST_NEW_AD, HttpMethod.Post, req);

        public static Task<GetOnlineAdsResponse> GetOnlineAds(this APIClient api, object? req = null) =>
            api.Call<GetOnlineAdsResponse>(MethodList.GET_ONLINE_ADS, HttpMethod.Post, req);

        public static Task<List<PaymentTerm>> GetUserPaymentTypes(this APIClient api, object? req = null) =>
            api.Call<List<PaymentTerm>>(MethodList.GET_USER_PAYMENT_TYPES, HttpMethod.Post, req);

    }
}
