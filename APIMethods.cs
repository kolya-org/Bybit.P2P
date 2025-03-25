using Bybit.P2P.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bybit.P2P
{
    public static class APIMethods
    {
        public static async Task<GetCurrentBalanceResponse> GetCurrentBalance(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetCurrentBalanceResponse>(MethodList.GET_CURRENT_BALANCE, HttpMethod.Get, req);
        }

        public static async Task<GetAccountInformationResponse> GetAccountInformation(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetAccountInformationResponse>(MethodList.GET_ACCOUNT_INFORMATION, HttpMethod.Post, req);
        }

        public static async Task<GetAdsListResponse> GetAdsList(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetAdsListResponse>(MethodList.GET_ADS_LIST, HttpMethod.Post, req);
        }

        public static async Task<GetAdDetailsResponse> GetAdDetails(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetAdDetailsResponse>(MethodList.GET_AD_DETAILS, HttpMethod.Post, req);
        }

        public static async Task<UpdateAdResponse> UpdateAd(this APIClient api, object? req = null)
        {
            return await api.SendRequest<UpdateAdResponse>(MethodList.UPDATE_AD, HttpMethod.Post, req);
        }

        public static async Task RemoveAd(this APIClient api, object? req = null)
        {
            await api.SendRequest<object>(MethodList.REMOVE_AD, HttpMethod.Post, req);
        }

        public static async Task<GetOrdersResponse> GetOrders(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetOrdersResponse>(MethodList.GET_ORDERS, HttpMethod.Post, req);
        }

        public static async Task<GetOrdersResponse> GetPendingOrders(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetOrdersResponse>(MethodList.GET_PENDING_ORDERS, HttpMethod.Post, req);
        }

        public static async Task<GetCounterpartyInfoResponse> GetCounterpartyInfo(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetCounterpartyInfoResponse>(MethodList.GET_COUNTERPARTY_INFO, HttpMethod.Post, req);
        }

        public static async Task<GetOrderDetailsResponse> GetOrderDetails(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetOrderDetailsResponse>(MethodList.GET_ORDER_DETAILS, HttpMethod.Post, req);
        }

        public static async Task ReleaseAssets(this APIClient api, object? req = null)
        {
            await api.SendRequest<object>(MethodList.RELEASE_ASSETS, HttpMethod.Post, req);
        }

        public static async Task MarkAsPaid(this APIClient api, object? req = null)
        {
            await api.SendRequest<object>(MethodList.MARK_AS_PAID, HttpMethod.Post, req);
        }

        public static async Task<GetChatMessagesResponse> GetChatMessages(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetChatMessagesResponse>(MethodList.GET_CHAT_MESSAGES, HttpMethod.Post, req);
        }

        public static async Task UploadChatFile(this APIClient api, object? req = null)
        {
            throw new NotImplementedException();
        }

        public static async Task SendChatMessage(this APIClient api, object? req = null)
        {
            await api.SendRequest<object>(MethodList.SEND_CHAT_MESSAGE, HttpMethod.Post, req);
        }

        public static async Task<PostNewAdResponse> PostNewAd(this APIClient api, object? req = null)
        {
            return await api.SendRequest<PostNewAdResponse>(MethodList.POST_NEW_AD, HttpMethod.Post, req);
        }

        public static async Task<GetOnlineAdsResponse> GetOnlineAds(this APIClient api, object? req = null)
        {
            return await api.SendRequest<GetOnlineAdsResponse>(MethodList.GET_ONLINE_ADS, HttpMethod.Post, req);
        }

        public static async Task<List<GetUserPaymentTypesResponse>> GetUserPaymentTypes(this APIClient api, object? req = null)
        {
            return await api.SendRequest<List<GetUserPaymentTypesResponse>>(MethodList.GET_USER_PAYMENT_TYPES, HttpMethod.Post, req);
        }
    }
}
