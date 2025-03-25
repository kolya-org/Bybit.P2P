using Bybit.P2P;
using Newtonsoft.Json;

void Pretty(object obj) => Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));

var p2p = new APIClient(
    apiKey: "x",
    apiSecret: "x",
    testnet: true
);

// 1. Get current balance
Pretty(await p2p.GetCurrentBalance(new { accountType = "FUND" }));

// 2. Get account information
Pretty(await p2p.GetAccountInformation());

// 3. Get ads list
Pretty(await p2p.GetAdsList());

// 4. Get ad detail
Pretty(await p2p.GetAdDetails(new { itemId = "1234567890123456789" }));

// 5. Update/reOnline ads
Pretty(await p2p.UpdateAd(new {
    id = "1234567890123456789",
    priceType = "0",
    premium = "90",
    price = "78.3",
    minAmount = "500",
    maxAmount = "3500000",
    remark = "Contact @kolya5544 on Telegram once you've paid..",
    tradingPreferenceSet = new {
        hasUnPostAd = "0",
        isKyc = "1",
        isEmail = "0",
        isMobile = "0",
        hasRegisterTime = "0",
        registerTimeThreshold = "0",
        orderFinishNumberDay30 = "0",
        completeRateDay30 = "",
        nationalLimit = "",
        hasOrderFinishNumberDay30 = "0",
        hasCompleteRateDay30 = "0",
        hasNationalLimit = "0",
    },
    paymentIds = new string[] { "6558" },
    actionType = "MODIFY",
    quantity = "25000",
    paymentPeriod = "15"
}));

// 6. Remove ad
await p2p.RemoveAd(new { itemId = "1234567890123456789" });

// 7. Get Orders
Pretty(await p2p.GetOrders(new { page = 1, size = 10 }));

// 8. Get Pending Orders
Pretty(await p2p.GetPendingOrders(new { page = 1, size = 10 }));

// 9. Get Counterparty Info
Pretty(await p2p.GetCounterpartyInfo(new {
    originalUid = "118027304",
    orderId = "1234567890123456789"
}));

// 10. Get Order Details
Pretty(await p2p.GetOrderDetails(new { orderId = "1234567890123456789" }));

// 11. Release Assets
await p2p.ReleaseAssets(new { orderId = "1234567890123456789" });

// 12. Mark as Paid
await p2p.MarkAsPaid(new { orderId = "1234567890123456789", paymentType = "541", paymentId = "7146" });

// 13. Get Chat Messages
Pretty(await p2p.GetChatMessages(new
{
    orderId = "1234567890123456789",
    startMessageId = 0,
    size = 100
}));

// 14. Upload Chat File
await p2p.UploadChatFile(new
{
    upload_file = "F:/grub.png" // https://img.nk.ax/eLbPQWWRUWxKQbrQK.png
});

// 15. Send Chat Message
await p2p.SendChatMessage(new
{
    message = "Hello, please send funds to the bank account specified",
    contentType = "str",
    orderId = "1234567890123456789",
    msgUuid = Guid.NewGuid().ToString()
});

// 16. Post New Ad
Pretty(await p2p.PostNewAd(new
{
    tokenId = "USDT",
    currencyId = "RUB",
    side = "1",
    priceType = "0",
    premium = "90",
    price = "109",
    minAmount = "500",
    maxAmount = "3500000",
    remark = "Contact @kolya5544 on Telegram once you've paid.",
    tradingPreferenceSet = new
    {
        hasUnPostAd = "0",
        isKyc = "1",
        isEmail = "0",
        isMobile = "0",
        hasRegisterTime = "0",
        registerTimeThreshold = "0",
        orderFinishNumberDay30 = "0",
        completeRateDay30 = "",
        nationalLimit = "",
        hasOrderFinishNumberDay30 = "0",
        hasCompleteRateDay30 = "0",
        hasNationalLimit = "0"
    },
    paymentIds = new string[] { "6558" },
    quantity = "25000",
    paymentPeriod = "15",
    itemType = "ORIGIN"
}));

// 17. Get Online Ads
Pretty(await p2p.GetOnlineAds(new
{
    tokenId = "USDT",
    currencyId = "RUB",
    side = "0"
}));

// 18. Get user payment
Pretty(await p2p.GetUserPaymentTypes());