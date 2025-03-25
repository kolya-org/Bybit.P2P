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
    }
}
