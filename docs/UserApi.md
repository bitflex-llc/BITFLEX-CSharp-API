# Org.OpenAPITools.Api.UserApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUserBalanceactionsGet**](UserApi.md#apiuserbalanceactionsget) | **GET** /api/User/balanceactions | 
[**ApiUserBalancesGet**](UserApi.md#apiuserbalancesget) | **GET** /api/User/balances | 
[**ApiUserBalanceslistGet**](UserApi.md#apiuserbalanceslistget) | **GET** /api/User/balanceslist | 
[**ApiUserDepositsGet**](UserApi.md#apiuserdepositsget) | **GET** /api/User/deposits | 
[**ApiUserFinishTier1VerificationPost**](UserApi.md#apiuserfinishtier1verificationpost) | **POST** /api/User/FinishTier1Verification | 
[**ApiUserGetVerificationLevelGet**](UserApi.md#apiusergetverificationlevelget) | **GET** /api/User/GetVerificationLevel | 
[**ApiUserOrdersGet**](UserApi.md#apiuserordersget) | **GET** /api/User/orders | 
[**ApiUserSetPhoneNumberPost**](UserApi.md#apiusersetphonenumberpost) | **POST** /api/User/SetPhoneNumber | 
[**ApiUserTradehistoryGet**](UserApi.md#apiusertradehistoryget) | **GET** /api/User/tradehistory | 
[**ApiUserVerificationsGet**](UserApi.md#apiuserverificationsget) | **GET** /api/User/verifications | 
[**ApiUserVerifyPhoneNumberPost**](UserApi.md#apiuserverifyphonenumberpost) | **POST** /api/User/VerifyPhoneNumber | 
[**ApiUserWithdrawalsGet**](UserApi.md#apiuserwithdrawalsget) | **GET** /api/User/withdrawals | 


<a name="apiuserbalanceactionsget"></a>
# **ApiUserBalanceactionsGet**
> GetBalanceActionsResponse ApiUserBalanceactionsGet (int? page = null, int? size = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserBalanceactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var page = 56;  // int? |  (optional) 
            var size = 56;  // int? |  (optional) 

            try
            {
                GetBalanceActionsResponse result = apiInstance.ApiUserBalanceactionsGet(page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserBalanceactionsGet: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **size** | **int?**|  | [optional] 

### Return type

[**GetBalanceActionsResponse**](GetBalanceActionsResponse.md)

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

<a name="apiuserbalancesget"></a>
# **ApiUserBalancesGet**
> Dictionary&lt;string, double&gt; ApiUserBalancesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserBalancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                Dictionary<string, double> result = apiInstance.ApiUserBalancesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserBalancesGet: " + e.Message );
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

**Dictionary<string, double>**

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

<a name="apiuserbalanceslistget"></a>
# **ApiUserBalanceslistGet**
> GetBalancesListResponse ApiUserBalanceslistGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserBalanceslistGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                GetBalancesListResponse result = apiInstance.ApiUserBalanceslistGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserBalanceslistGet: " + e.Message );
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

[**GetBalancesListResponse**](GetBalancesListResponse.md)

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

<a name="apiuserdepositsget"></a>
# **ApiUserDepositsGet**
> List&lt;ApiGetDepositsWitdrawals&gt; ApiUserDepositsGet (string currency = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserDepositsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var currency = currency_example;  // string |  (optional) 

            try
            {
                List<ApiGetDepositsWitdrawals> result = apiInstance.ApiUserDepositsGet(currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserDepositsGet: " + e.Message );
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
 **currency** | **string**|  | [optional] 

### Return type

[**List&lt;ApiGetDepositsWitdrawals&gt;**](ApiGetDepositsWitdrawals.md)

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

<a name="apiuserfinishtier1verificationpost"></a>
# **ApiUserFinishTier1VerificationPost**
> bool ApiUserFinishTier1VerificationPost (FinishTier1VerificationModel finishTier1VerificationModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserFinishTier1VerificationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var finishTier1VerificationModel = new FinishTier1VerificationModel(); // FinishTier1VerificationModel |  (optional) 

            try
            {
                bool result = apiInstance.ApiUserFinishTier1VerificationPost(finishTier1VerificationModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserFinishTier1VerificationPost: " + e.Message );
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
 **finishTier1VerificationModel** | [**FinishTier1VerificationModel**](FinishTier1VerificationModel.md)|  | [optional] 

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

<a name="apiusergetverificationlevelget"></a>
# **ApiUserGetVerificationLevelGet**
> GetVerificationLevelResponse ApiUserGetVerificationLevelGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserGetVerificationLevelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                GetVerificationLevelResponse result = apiInstance.ApiUserGetVerificationLevelGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserGetVerificationLevelGet: " + e.Message );
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

[**GetVerificationLevelResponse**](GetVerificationLevelResponse.md)

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

<a name="apiuserordersget"></a>
# **ApiUserOrdersGet**
> GetOrdersResponse ApiUserOrdersGet (string pair = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var pair = pair_example;  // string |  (optional) 

            try
            {
                GetOrdersResponse result = apiInstance.ApiUserOrdersGet(pair);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserOrdersGet: " + e.Message );
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
 **pair** | **string**|  | [optional] 

### Return type

[**GetOrdersResponse**](GetOrdersResponse.md)

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

<a name="apiusersetphonenumberpost"></a>
# **ApiUserSetPhoneNumberPost**
> VerificationResource ApiUserSetPhoneNumberPost (string phoneNumber = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserSetPhoneNumberPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var phoneNumber = phoneNumber_example;  // string |  (optional) 

            try
            {
                VerificationResource result = apiInstance.ApiUserSetPhoneNumberPost(phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserSetPhoneNumberPost: " + e.Message );
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
 **phoneNumber** | **string**|  | [optional] 

### Return type

[**VerificationResource**](VerificationResource.md)

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

<a name="apiusertradehistoryget"></a>
# **ApiUserTradehistoryGet**
> GetUserTradeHistoryResponse ApiUserTradehistoryGet (int? page = null, int? size = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserTradehistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var page = 56;  // int? |  (optional) 
            var size = 56;  // int? |  (optional) 

            try
            {
                GetUserTradeHistoryResponse result = apiInstance.ApiUserTradehistoryGet(page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserTradehistoryGet: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **size** | **int?**|  | [optional] 

### Return type

[**GetUserTradeHistoryResponse**](GetUserTradeHistoryResponse.md)

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

<a name="apiuserverificationsget"></a>
# **ApiUserVerificationsGet**
> void ApiUserVerificationsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserVerificationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                apiInstance.ApiUserVerificationsGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserVerificationsGet: " + e.Message );
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

<a name="apiuserverifyphonenumberpost"></a>
# **ApiUserVerifyPhoneNumberPost**
> SmsVefiryResult ApiUserVerifyPhoneNumberPost (PostVefirySms postVefirySms = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserVerifyPhoneNumberPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var postVefirySms = new PostVefirySms(); // PostVefirySms |  (optional) 

            try
            {
                SmsVefiryResult result = apiInstance.ApiUserVerifyPhoneNumberPost(postVefirySms);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserVerifyPhoneNumberPost: " + e.Message );
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
 **postVefirySms** | [**PostVefirySms**](PostVefirySms.md)|  | [optional] 

### Return type

[**SmsVefiryResult**](SmsVefiryResult.md)

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

<a name="apiuserwithdrawalsget"></a>
# **ApiUserWithdrawalsGet**
> List&lt;ApiGetDepositsWitdrawals&gt; ApiUserWithdrawalsGet (string currency = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserWithdrawalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var currency = currency_example;  // string |  (optional) 

            try
            {
                List<ApiGetDepositsWitdrawals> result = apiInstance.ApiUserWithdrawalsGet(currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserWithdrawalsGet: " + e.Message );
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
 **currency** | **string**|  | [optional] 

### Return type

[**List&lt;ApiGetDepositsWitdrawals&gt;**](ApiGetDepositsWitdrawals.md)

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

