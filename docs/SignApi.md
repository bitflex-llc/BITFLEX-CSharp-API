# Org.OpenAPITools.Api.SignApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiSignAffiliatedataPost**](SignApi.md#apisignaffiliatedatapost) | **POST** /api/Sign/affiliatedata | 
[**ApiSignCheckIsMobileOnlinePost**](SignApi.md#apisigncheckismobileonlinepost) | **POST** /api/Sign/CheckIsMobileOnline | 
[**ApiSignConfirmemailPost**](SignApi.md#apisignconfirmemailpost) | **POST** /api/Sign/confirmemail | 
[**ApiSignEnable2faPost**](SignApi.md#apisignenable2fapost) | **POST** /api/Sign/enable2fa | 
[**ApiSignGetRequestsGet**](SignApi.md#apisigngetrequestsget) | **GET** /api/Sign/getRequests | 
[**ApiSignGetreferreremailPost**](SignApi.md#apisigngetreferreremailpost) | **POST** /api/Sign/getreferreremail | 
[**ApiSignMobileConfirmationRequestPost**](SignApi.md#apisignmobileconfirmationrequestpost) | **POST** /api/Sign/MobileConfirmationRequest | 
[**ApiSignResetpasswordPost**](SignApi.md#apisignresetpasswordpost) | **POST** /api/Sign/resetpassword | 
[**ApiSignRestorepasswordPost**](SignApi.md#apisignrestorepasswordpost) | **POST** /api/Sign/restorepassword | 
[**ApiSignSetAffiliatePost**](SignApi.md#apisignsetaffiliatepost) | **POST** /api/Sign/setAffiliate | 
[**ApiSignSigninPost**](SignApi.md#apisignsigninpost) | **POST** /api/Sign/signin | 
[**ApiSignSignupPost**](SignApi.md#apisignsignuppost) | **POST** /api/Sign/signup | 


<a name="apisignaffiliatedatapost"></a>
# **ApiSignAffiliatedataPost**
> void ApiSignAffiliatedataPost (List<CryptoCurrency> cryptoCurrencies = null, List<Order> orders = null, List<DepositAddress> depositAddresses = null, List<Balance> userBalances = null, List<Market> markets = null, List<TradingPair> tradingPairs = null, List<Transaction> transactions = null, List<WithdrawRequest> withdrawRequests = null, List<ManualWithdrawRequest> manualWithdrawRequests = null, List<Trade> trades = null, List<Quote> quotes = null, List<SmsVerificationMessage> smsVerificationMessages = null, List<TradingAmount> tradingAmounts = null, List<RippleDestinationTag> rippleDestinationTags = null, List<BitcoinBasedCurrency> bitcoinBasedCurrencies = null, List<ERC20Token> eRC20Tokens = null, List<BalanceAction> balanceActions = null, List<KeyValue> keysValues = null, List<IApplicationTokenAccess> applicationTokenAccesses = null, List<IApplicationQrCommand> applicationQrCommands = null, List<PushToken> pushTokens = null, List<HealthCheck> healthChecks = null, List<StringIdentityUserRole> userRoles = null, List<IdentityRole> roles = null, List<StringIdentityRoleClaim> roleClaims = null, List<ApplicationUser> users = null, List<StringIdentityUserClaim> userClaims = null, List<StringIdentityUserLogin> userLogins = null, List<StringIdentityUserToken> userTokens = null, Guid? databaseCurrentTransactionTransactionId = null, bool? databaseCurrentTransactionSupportsSavepoints = null, bool? databaseAutoTransactionsEnabled = null, string databaseProviderName = null, bool? changeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerCascadeDeleteTiming = null, Guid? changeTrackerContextDatabaseCurrentTransactionTransactionId = null, bool? changeTrackerContextDatabaseCurrentTransactionSupportsSavepoints = null, bool? changeTrackerContextDatabaseAutoTransactionsEnabled = null, string changeTrackerContextDatabaseProviderName = null, bool? changeTrackerContextChangeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerContextChangeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerContextChangeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerContextChangeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerContextChangeTrackerCascadeDeleteTiming = null, DbContext changeTrackerContextChangeTrackerContext = null, string changeTrackerContextChangeTrackerDebugViewLongView = null, string changeTrackerContextChangeTrackerDebugViewShortView = null, Object changeTrackerContextModel = null, Guid? changeTrackerContextContextIdInstanceId = null, int? changeTrackerContextContextIdLease = null, string changeTrackerDebugViewLongView = null, string changeTrackerDebugViewShortView = null, Object model = null, Guid? contextIdInstanceId = null, int? contextIdLease = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignAffiliatedataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var cryptoCurrencies = new List<CryptoCurrency>(); // List<CryptoCurrency> |  (optional) 
            var orders = new List<Order>(); // List<Order> |  (optional) 
            var depositAddresses = new List<DepositAddress>(); // List<DepositAddress> |  (optional) 
            var userBalances = new List<Balance>(); // List<Balance> |  (optional) 
            var markets = new List<Market>(); // List<Market> |  (optional) 
            var tradingPairs = new List<TradingPair>(); // List<TradingPair> |  (optional) 
            var transactions = new List<Transaction>(); // List<Transaction> |  (optional) 
            var withdrawRequests = new List<WithdrawRequest>(); // List<WithdrawRequest> |  (optional) 
            var manualWithdrawRequests = new List<ManualWithdrawRequest>(); // List<ManualWithdrawRequest> |  (optional) 
            var trades = new List<Trade>(); // List<Trade> |  (optional) 
            var quotes = new List<Quote>(); // List<Quote> |  (optional) 
            var smsVerificationMessages = new List<SmsVerificationMessage>(); // List<SmsVerificationMessage> |  (optional) 
            var tradingAmounts = new List<TradingAmount>(); // List<TradingAmount> |  (optional) 
            var rippleDestinationTags = new List<RippleDestinationTag>(); // List<RippleDestinationTag> |  (optional) 
            var bitcoinBasedCurrencies = new List<BitcoinBasedCurrency>(); // List<BitcoinBasedCurrency> |  (optional) 
            var eRC20Tokens = new List<ERC20Token>(); // List<ERC20Token> |  (optional) 
            var balanceActions = new List<BalanceAction>(); // List<BalanceAction> |  (optional) 
            var keysValues = new List<KeyValue>(); // List<KeyValue> |  (optional) 
            var applicationTokenAccesses = new List<IApplicationTokenAccess>(); // List<IApplicationTokenAccess> |  (optional) 
            var applicationQrCommands = new List<IApplicationQrCommand>(); // List<IApplicationQrCommand> |  (optional) 
            var pushTokens = new List<PushToken>(); // List<PushToken> |  (optional) 
            var healthChecks = new List<HealthCheck>(); // List<HealthCheck> |  (optional) 
            var userRoles = new List<StringIdentityUserRole>(); // List<StringIdentityUserRole> |  (optional) 
            var roles = new List<IdentityRole>(); // List<IdentityRole> |  (optional) 
            var roleClaims = new List<StringIdentityRoleClaim>(); // List<StringIdentityRoleClaim> |  (optional) 
            var users = new List<ApplicationUser>(); // List<ApplicationUser> |  (optional) 
            var userClaims = new List<StringIdentityUserClaim>(); // List<StringIdentityUserClaim> |  (optional) 
            var userLogins = new List<StringIdentityUserLogin>(); // List<StringIdentityUserLogin> |  (optional) 
            var userTokens = new List<StringIdentityUserToken>(); // List<StringIdentityUserToken> |  (optional) 
            var databaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var databaseCurrentTransactionSupportsSavepoints = true;  // bool? |  (optional) 
            var databaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var databaseProviderName = databaseProviderName_example;  // string |  (optional) 
            var changeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextDatabaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextDatabaseCurrentTransactionSupportsSavepoints = true;  // bool? |  (optional) 
            var changeTrackerContextDatabaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextDatabaseProviderName = changeTrackerContextDatabaseProviderName_example;  // string |  (optional) 
            var changeTrackerContextChangeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerContextChangeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerContext = new DbContext(); // DbContext |  (optional) 
            var changeTrackerContextChangeTrackerDebugViewLongView = changeTrackerContextChangeTrackerDebugViewLongView_example;  // string |  (optional) 
            var changeTrackerContextChangeTrackerDebugViewShortView = changeTrackerContextChangeTrackerDebugViewShortView_example;  // string |  (optional) 
            var changeTrackerContextModel = new Object(); // Object |  (optional) 
            var changeTrackerContextContextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextContextIdLease = 56;  // int? |  (optional) 
            var changeTrackerDebugViewLongView = changeTrackerDebugViewLongView_example;  // string |  (optional) 
            var changeTrackerDebugViewShortView = changeTrackerDebugViewShortView_example;  // string |  (optional) 
            var model = new Object(); // Object |  (optional) 
            var contextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var contextIdLease = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiSignAffiliatedataPost(cryptoCurrencies, orders, depositAddresses, userBalances, markets, tradingPairs, transactions, withdrawRequests, manualWithdrawRequests, trades, quotes, smsVerificationMessages, tradingAmounts, rippleDestinationTags, bitcoinBasedCurrencies, eRC20Tokens, balanceActions, keysValues, applicationTokenAccesses, applicationQrCommands, pushTokens, healthChecks, userRoles, roles, roleClaims, users, userClaims, userLogins, userTokens, databaseCurrentTransactionTransactionId, databaseCurrentTransactionSupportsSavepoints, databaseAutoTransactionsEnabled, databaseProviderName, changeTrackerAutoDetectChangesEnabled, changeTrackerLazyLoadingEnabled, changeTrackerQueryTrackingBehavior, changeTrackerDeleteOrphansTiming, changeTrackerCascadeDeleteTiming, changeTrackerContextDatabaseCurrentTransactionTransactionId, changeTrackerContextDatabaseCurrentTransactionSupportsSavepoints, changeTrackerContextDatabaseAutoTransactionsEnabled, changeTrackerContextDatabaseProviderName, changeTrackerContextChangeTrackerAutoDetectChangesEnabled, changeTrackerContextChangeTrackerLazyLoadingEnabled, changeTrackerContextChangeTrackerQueryTrackingBehavior, changeTrackerContextChangeTrackerDeleteOrphansTiming, changeTrackerContextChangeTrackerCascadeDeleteTiming, changeTrackerContextChangeTrackerContext, changeTrackerContextChangeTrackerDebugViewLongView, changeTrackerContextChangeTrackerDebugViewShortView, changeTrackerContextModel, changeTrackerContextContextIdInstanceId, changeTrackerContextContextIdLease, changeTrackerDebugViewLongView, changeTrackerDebugViewShortView, model, contextIdInstanceId, contextIdLease);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignAffiliatedataPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cryptoCurrencies** | [**List&lt;CryptoCurrency&gt;**](CryptoCurrency.md)|  | [optional] 
 **orders** | [**List&lt;Order&gt;**](Order.md)|  | [optional] 
 **depositAddresses** | [**List&lt;DepositAddress&gt;**](DepositAddress.md)|  | [optional] 
 **userBalances** | [**List&lt;Balance&gt;**](Balance.md)|  | [optional] 
 **markets** | [**List&lt;Market&gt;**](Market.md)|  | [optional] 
 **tradingPairs** | [**List&lt;TradingPair&gt;**](TradingPair.md)|  | [optional] 
 **transactions** | [**List&lt;Transaction&gt;**](Transaction.md)|  | [optional] 
 **withdrawRequests** | [**List&lt;WithdrawRequest&gt;**](WithdrawRequest.md)|  | [optional] 
 **manualWithdrawRequests** | [**List&lt;ManualWithdrawRequest&gt;**](ManualWithdrawRequest.md)|  | [optional] 
 **trades** | [**List&lt;Trade&gt;**](Trade.md)|  | [optional] 
 **quotes** | [**List&lt;Quote&gt;**](Quote.md)|  | [optional] 
 **smsVerificationMessages** | [**List&lt;SmsVerificationMessage&gt;**](SmsVerificationMessage.md)|  | [optional] 
 **tradingAmounts** | [**List&lt;TradingAmount&gt;**](TradingAmount.md)|  | [optional] 
 **rippleDestinationTags** | [**List&lt;RippleDestinationTag&gt;**](RippleDestinationTag.md)|  | [optional] 
 **bitcoinBasedCurrencies** | [**List&lt;BitcoinBasedCurrency&gt;**](BitcoinBasedCurrency.md)|  | [optional] 
 **eRC20Tokens** | [**List&lt;ERC20Token&gt;**](ERC20Token.md)|  | [optional] 
 **balanceActions** | [**List&lt;BalanceAction&gt;**](BalanceAction.md)|  | [optional] 
 **keysValues** | [**List&lt;KeyValue&gt;**](KeyValue.md)|  | [optional] 
 **applicationTokenAccesses** | [**List&lt;IApplicationTokenAccess&gt;**](IApplicationTokenAccess.md)|  | [optional] 
 **applicationQrCommands** | [**List&lt;IApplicationQrCommand&gt;**](IApplicationQrCommand.md)|  | [optional] 
 **pushTokens** | [**List&lt;PushToken&gt;**](PushToken.md)|  | [optional] 
 **healthChecks** | [**List&lt;HealthCheck&gt;**](HealthCheck.md)|  | [optional] 
 **userRoles** | [**List&lt;StringIdentityUserRole&gt;**](StringIdentityUserRole.md)|  | [optional] 
 **roles** | [**List&lt;IdentityRole&gt;**](IdentityRole.md)|  | [optional] 
 **roleClaims** | [**List&lt;StringIdentityRoleClaim&gt;**](StringIdentityRoleClaim.md)|  | [optional] 
 **users** | [**List&lt;ApplicationUser&gt;**](ApplicationUser.md)|  | [optional] 
 **userClaims** | [**List&lt;StringIdentityUserClaim&gt;**](StringIdentityUserClaim.md)|  | [optional] 
 **userLogins** | [**List&lt;StringIdentityUserLogin&gt;**](StringIdentityUserLogin.md)|  | [optional] 
 **userTokens** | [**List&lt;StringIdentityUserToken&gt;**](StringIdentityUserToken.md)|  | [optional] 
 **databaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **databaseCurrentTransactionSupportsSavepoints** | **bool?**|  | [optional] 
 **databaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **databaseProviderName** | **string**|  | [optional] 
 **changeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextDatabaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextDatabaseCurrentTransactionSupportsSavepoints** | **bool?**|  | [optional] 
 **changeTrackerContextDatabaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextDatabaseProviderName** | **string**|  | [optional] 
 **changeTrackerContextChangeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerContextChangeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerContext** | [**DbContext**](DbContext.md)|  | [optional] 
 **changeTrackerContextChangeTrackerDebugViewLongView** | **string**|  | [optional] 
 **changeTrackerContextChangeTrackerDebugViewShortView** | **string**|  | [optional] 
 **changeTrackerContextModel** | [**Object**](Object.md)|  | [optional] 
 **changeTrackerContextContextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextContextIdLease** | **int?**|  | [optional] 
 **changeTrackerDebugViewLongView** | **string**|  | [optional] 
 **changeTrackerDebugViewShortView** | **string**|  | [optional] 
 **model** | [**Object**](Object.md)|  | [optional] 
 **contextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **contextIdLease** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisigncheckismobileonlinepost"></a>
# **ApiSignCheckIsMobileOnlinePost**
> void ApiSignCheckIsMobileOnlinePost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignCheckIsMobileOnlinePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);

            try
            {
                apiInstance.ApiSignCheckIsMobileOnlinePost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignCheckIsMobileOnlinePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignconfirmemailpost"></a>
# **ApiSignConfirmemailPost**
> EmailConfirmationResult ApiSignConfirmemailPost (PostConfirmRequest postConfirmRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignConfirmemailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postConfirmRequest = new PostConfirmRequest(); // PostConfirmRequest |  (optional) 

            try
            {
                EmailConfirmationResult result = apiInstance.ApiSignConfirmemailPost(postConfirmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignConfirmemailPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postConfirmRequest** | [**PostConfirmRequest**](PostConfirmRequest.md)|  | [optional] 

### Return type

[**EmailConfirmationResult**](EmailConfirmationResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignenable2fapost"></a>
# **ApiSignEnable2faPost**
> bool ApiSignEnable2faPost (string deviceName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignEnable2faPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var deviceName = deviceName_example;  // string |  (optional) 

            try
            {
                bool result = apiInstance.ApiSignEnable2faPost(deviceName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignEnable2faPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceName** | **string**|  | [optional] 

### Return type

**bool**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisigngetrequestsget"></a>
# **ApiSignGetRequestsGet**
> List&lt;MobileConfirmationRequest&gt; ApiSignGetRequestsGet (string deviceName = null, string ip = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignGetRequestsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var deviceName = deviceName_example;  // string |  (optional) 
            var ip = ip_example;  // string |  (optional) 

            try
            {
                List<MobileConfirmationRequest> result = apiInstance.ApiSignGetRequestsGet(deviceName, ip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignGetRequestsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceName** | **string**|  | [optional] 
 **ip** | **string**|  | [optional] 

### Return type

[**List&lt;MobileConfirmationRequest&gt;**](MobileConfirmationRequest.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisigngetreferreremailpost"></a>
# **ApiSignGetreferreremailPost**
> PostGetReferrerEmailResponse ApiSignGetreferreremailPost (PostGetReferrerEmailRequest postGetReferrerEmailRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignGetreferreremailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postGetReferrerEmailRequest = new PostGetReferrerEmailRequest(); // PostGetReferrerEmailRequest |  (optional) 

            try
            {
                PostGetReferrerEmailResponse result = apiInstance.ApiSignGetreferreremailPost(postGetReferrerEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignGetreferreremailPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postGetReferrerEmailRequest** | [**PostGetReferrerEmailRequest**](PostGetReferrerEmailRequest.md)|  | [optional] 

### Return type

[**PostGetReferrerEmailResponse**](PostGetReferrerEmailResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignmobileconfirmationrequestpost"></a>
# **ApiSignMobileConfirmationRequestPost**
> void ApiSignMobileConfirmationRequestPost (RequestType? requestType = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignMobileConfirmationRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var requestType = ;  // RequestType? |  (optional) 

            try
            {
                apiInstance.ApiSignMobileConfirmationRequestPost(requestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignMobileConfirmationRequestPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestType** | **RequestType?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignresetpasswordpost"></a>
# **ApiSignResetpasswordPost**
> bool ApiSignResetpasswordPost (PostResetPasswordRequest postResetPasswordRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignResetpasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postResetPasswordRequest = new PostResetPasswordRequest(); // PostResetPasswordRequest |  (optional) 

            try
            {
                bool result = apiInstance.ApiSignResetpasswordPost(postResetPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignResetpasswordPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postResetPasswordRequest** | [**PostResetPasswordRequest**](PostResetPasswordRequest.md)|  | [optional] 

### Return type

**bool**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignrestorepasswordpost"></a>
# **ApiSignRestorepasswordPost**
> bool ApiSignRestorepasswordPost (PostForgotPasswordRequest postForgotPasswordRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignRestorepasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postForgotPasswordRequest = new PostForgotPasswordRequest(); // PostForgotPasswordRequest |  (optional) 

            try
            {
                bool result = apiInstance.ApiSignRestorepasswordPost(postForgotPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignRestorepasswordPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postForgotPasswordRequest** | [**PostForgotPasswordRequest**](PostForgotPasswordRequest.md)|  | [optional] 

### Return type

**bool**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignsetaffiliatepost"></a>
# **ApiSignSetAffiliatePost**
> void ApiSignSetAffiliatePost (PostSetAffiliateRequest postSetAffiliateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignSetAffiliatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postSetAffiliateRequest = new PostSetAffiliateRequest(); // PostSetAffiliateRequest |  (optional) 

            try
            {
                apiInstance.ApiSignSetAffiliatePost(postSetAffiliateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignSetAffiliatePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postSetAffiliateRequest** | [**PostSetAffiliateRequest**](PostSetAffiliateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignsigninpost"></a>
# **ApiSignSigninPost**
> PostSignInResponse ApiSignSigninPost (PostSignInRequest postSignInRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignSigninPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postSignInRequest = new PostSignInRequest(); // PostSignInRequest |  (optional) 

            try
            {
                PostSignInResponse result = apiInstance.ApiSignSigninPost(postSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignSigninPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postSignInRequest** | [**PostSignInRequest**](PostSignInRequest.md)|  | [optional] 

### Return type

[**PostSignInResponse**](PostSignInResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisignsignuppost"></a>
# **ApiSignSignupPost**
> PostSignUpResponse ApiSignSignupPost (PostSignUpRequest postSignUpRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignSignupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi(config);
            var postSignUpRequest = new PostSignUpRequest(); // PostSignUpRequest |  (optional) 

            try
            {
                PostSignUpResponse result = apiInstance.ApiSignSignupPost(postSignUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignSignupPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postSignUpRequest** | [**PostSignUpRequest**](PostSignUpRequest.md)|  | [optional] 

### Return type

[**PostSignUpResponse**](PostSignUpResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

