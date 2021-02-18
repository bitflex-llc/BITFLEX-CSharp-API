# Org.OpenAPITools.Api.BalanceApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiBalanceCurrencyGet**](BalanceApi.md#apibalancecurrencyget) | **GET** /api/Balance/{currency} | 
[**ApiBalanceDepositCurrencyAddressGet**](BalanceApi.md#apibalancedepositcurrencyaddressget) | **GET** /api/Balance/deposit/{currency}/address | 
[**ApiBalanceDepositCurrencyAddressPost**](BalanceApi.md#apibalancedepositcurrencyaddresspost) | **POST** /api/Balance/deposit/{currency}/address | 
[**ApiBalanceGet**](BalanceApi.md#apibalanceget) | **GET** /api/Balance | 
[**ApiBalanceWithdrawCurrencyPageGet**](BalanceApi.md#apibalancewithdrawcurrencypageget) | **GET** /api/Balance/withdraw/{currency}/page | 
[**ApiBalanceWithdrawCurrencyPost**](BalanceApi.md#apibalancewithdrawcurrencypost) | **POST** /api/Balance/withdraw/{currency} | 


<a name="apibalancecurrencyget"></a>
# **ApiBalanceCurrencyGet**
> GetBalanceRequestModel ApiBalanceCurrencyGet (string currency)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBalanceCurrencyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BalanceApi(config);
            var currency = currency_example;  // string | 

            try
            {
                GetBalanceRequestModel result = apiInstance.ApiBalanceCurrencyGet(currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalanceApi.ApiBalanceCurrencyGet: " + e.Message );
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
 **currency** | **string**|  | 

### Return type

[**GetBalanceRequestModel**](GetBalanceRequestModel.md)

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

<a name="apibalancedepositcurrencyaddressget"></a>
# **ApiBalanceDepositCurrencyAddressGet**
> GetAddressResponse ApiBalanceDepositCurrencyAddressGet (string currency)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBalanceDepositCurrencyAddressGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BalanceApi(config);
            var currency = currency_example;  // string | 

            try
            {
                GetAddressResponse result = apiInstance.ApiBalanceDepositCurrencyAddressGet(currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalanceApi.ApiBalanceDepositCurrencyAddressGet: " + e.Message );
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
 **currency** | **string**|  | 

### Return type

[**GetAddressResponse**](GetAddressResponse.md)

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

<a name="apibalancedepositcurrencyaddresspost"></a>
# **ApiBalanceDepositCurrencyAddressPost**
> GenerateAddressResult ApiBalanceDepositCurrencyAddressPost (string currency)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBalanceDepositCurrencyAddressPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BalanceApi(config);
            var currency = currency_example;  // string | 

            try
            {
                GenerateAddressResult result = apiInstance.ApiBalanceDepositCurrencyAddressPost(currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalanceApi.ApiBalanceDepositCurrencyAddressPost: " + e.Message );
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
 **currency** | **string**|  | 

### Return type

[**GenerateAddressResult**](GenerateAddressResult.md)

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

<a name="apibalanceget"></a>
# **ApiBalanceGet**
> GetBalancesListResponse ApiBalanceGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBalanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BalanceApi(config);

            try
            {
                GetBalancesListResponse result = apiInstance.ApiBalanceGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalanceApi.ApiBalanceGet: " + e.Message );
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

<a name="apibalancewithdrawcurrencypageget"></a>
# **ApiBalanceWithdrawCurrencyPageGet**
> GetWithdrawResponse ApiBalanceWithdrawCurrencyPageGet (string currency)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBalanceWithdrawCurrencyPageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BalanceApi(config);
            var currency = currency_example;  // string | 

            try
            {
                GetWithdrawResponse result = apiInstance.ApiBalanceWithdrawCurrencyPageGet(currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalanceApi.ApiBalanceWithdrawCurrencyPageGet: " + e.Message );
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
 **currency** | **string**|  | 

### Return type

[**GetWithdrawResponse**](GetWithdrawResponse.md)

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

<a name="apibalancewithdrawcurrencypost"></a>
# **ApiBalanceWithdrawCurrencyPost**
> PostWithdrawRequestResult ApiBalanceWithdrawCurrencyPost (string currency, PostWithdrawRequest postWithdrawRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBalanceWithdrawCurrencyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BalanceApi(config);
            var currency = currency_example;  // string | 
            var postWithdrawRequest = new PostWithdrawRequest(); // PostWithdrawRequest |  (optional) 

            try
            {
                PostWithdrawRequestResult result = apiInstance.ApiBalanceWithdrawCurrencyPost(currency, postWithdrawRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalanceApi.ApiBalanceWithdrawCurrencyPost: " + e.Message );
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
 **currency** | **string**|  | 
 **postWithdrawRequest** | [**PostWithdrawRequest**](PostWithdrawRequest.md)|  | [optional] 

### Return type

[**PostWithdrawRequestResult**](PostWithdrawRequestResult.md)

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

