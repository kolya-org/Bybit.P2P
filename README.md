# Bybit.P2P
## An **unofficial** Bybit P2P API integration library written in C#.

![NuGet Version](https://img.shields.io/nuget/v/Bybit.P2P)

`Bybit.P2P` is the **unofficial** C# SDK for Bybit's P2P API, enabling seamless integration of your software solutions with Bybit's P2P trading platform.

- No need to implement signature (HMAC, RSA) logic yourself
- Easy & quick to work with
- Actively developed and maintained

*developed and maintained by kolya5544 at this point in time*

## Features

`Bybit.P2P` currently implements all methods available for P2P API. The library is in active development, so any newly released features will be added almost immediately. Here is a short list of what the library can do:

- Create, edit, delete, activate advertisements
- Get pending orders, mark orders as paid, release assets to the buyer
- Get and send text messages, upload files and send files to the chat
- Get all public advertisements for tokens
- ...and so much else! 🌟

All features are usually one method call away and do not require advanced API understanding to interact with.

## Tech

`Bybit.P2P` uses just one other package to work:

- `Newtonsoft.Json` for JSON operations (serialization & deserialization)

## Installation

`Bybit.P2P` should work with all modern .NET versions, since the library is developed in .NET Standard 2.1. Recommended version is .NET 8. You can install the package using NuGet:
```
nuget install Bybit.P2P
```

## Usage

Upon installation, you can use bybit_p2p by importing it in your code:
```
using Bybit.P2P;
```

Here is a quickstart example to get some info from the exchange:
```
using Bybit.P2P;
using Newtonsoft.Json;

void Pretty(object obj) => Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));

var p2p = new APIClient(
    apiKey: "x",
    apiSecret: "x",
    testnet: true
    );

# 1. Get current balance
Pretty(await p2p.GetCurrentBalance(new { accountType = "FUND", coin = "USDC" }));

# 2. Get account information
Pretty(await p2p.GetAccountInformation());

# 3. Get ads list
Pretty(await p2p.GetAdsList());
```

`APIClient()` class is used for P2P API interactions. Here, `testnet` refers to environment. For Mainnet (https://bybit.com/), you shall use `testnet = false`. For Testnet (https://testnet.bybit.com/), use `testnet = true` instead.

RSA users should also set `rsa = true` in the constructor. TR/KZ/NL/etc. users can manipulate `domain` and `tld` parameters, like `tld = "kz"`.

You can find the complete Quickstart example here: [Bybit.P2P Quickstart](https://github.com/kolya5544/Bybit.P2P/tree/master/examples/Quickstart.cs).

## Documentation

`Bybit.P2P` package currently consists of just one module, which is used for direct REST API requests to Bybit P2P API.

You can access P2P API documentation using this link: [Official P2P docs](https://bybit-exchange.github.io/docs/p2p/guide)

Here is a breakdown of how API methods correspond to appropriate `Bybit.P2P` methods:

Advertisements:
| Bybit.P2P method name | P2P API method name | P2P API endpoint path |
| --- | --- | --- |
| GetOnlineAds() | Get Market Online Ads list | [/v5/p2p/item/online](https://bybit-exchange.github.io/docs/p2p/ad/online-ad-list) |
| PostNewAd() | Post New Ad | [/v5/p2p/item/create](https://bybit-exchange.github.io/docs/p2p/ad/post-new-ad) |
| RemoveAd() | Remove ad | [/v5/p2p/item/cancel](https://bybit-exchange.github.io/docs/p2p/ad/remove-ad) |
| UpdateAd() | Update / Relist My Ad | [/v5/p2p/item/update](https://bybit-exchange.github.io/docs/p2p/ad/update-list-ad) |
| GetAdsList() | Get ads list | [/v5/p2p/item/personal/list](https://bybit-exchange.github.io/docs/p2p/ad/ad-list) |
| GetAdDetails() | Get ad detail | [/v5/p2p/item/info](https://bybit-exchange.github.io/docs/p2p/ad/ad-detail) |

Orders:
| Bybit.P2P method name | P2P API method name | P2P API endpoint path |
| --- | --- | --- |
| GetOrders() | Get All Orders | [/v5/p2p/order/simplifyList](https://bybit-exchange.github.io/docs/p2p/order/order-list) |
| GetOrderDetails() | Get Order Details | [/v5/p2p/order/info](https://bybit-exchange.github.io/docs/p2p/order/order-detail) |
| GetPendingOrders() | Get Pending Orders | [/v5/p2p/order/pending/simplifyList](https://bybit-exchange.github.io/docs/p2p/order/pending-order) |
| MarkAsPaid() | Mark Order As Paid | [/v5/p2p/order/pay](https://bybit-exchange.github.io/docs/p2p/order/mark-order-as-paid) |
| ReleaseAssets() | Release Digital Asset | [/v5/p2p/order/finish](https://bybit-exchange.github.io/docs/p2p/order/release-digital-asset) |
| SendChatMessage() | Send chat message | [/v5/p2p/order/message/send](https://bybit-exchange.github.io/docs/p2p/order/send-chat-msg) |
| UploadChatFile() | Upload chat file | [/v5/p2p/oss/upload_file](https://bybit-exchange.github.io/docs/p2p/order/upload-chat-file) |
| GetChatMessages() | Get Chat Message | [/v5/p2p/order/message/listpage](https://bybit-exchange.github.io/docs/p2p/order/chat-msg) |


User:
| bybit_p2p method name | P2P API method name | P2P API endpoint path |
| --- | --- | --- |
| GetAccountInformation() | Get Account Information | [/v5/p2p/user/personal/info](https://bybit-exchange.github.io/docs/p2p/user/acct-info) |
| GetCounterpartyInfo() | Get Counterparty User Info | [/v5/p2p/user/order/personal/info](https://bybit-exchange.github.io/docs/p2p/user/counterparty-user-info) |
| GetUserPaymentTypes() | Get User Payment | [/v5/p2p/user/payment/list](https://bybit-exchange.github.io/docs/p2p/user/user-payment) |

Misc:
| bybit_p2p method name | P2P API method name | P2P API endpoint path |
| --- | --- | --- |
| GetCurrentBalance() | Get Coin Balance | [/v5/asset/transfer/query-account-coins-balance](https://bybit-exchange.github.io/docs/p2p/all-balance) |

More methods will come soon, allowing for more advanced operations.

## Development

All contributions are welcome.

## License

MIT