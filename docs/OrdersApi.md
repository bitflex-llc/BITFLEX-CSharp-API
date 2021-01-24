# Org.OpenAPITools.Api.OrdersApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrdersCancelPost**](OrdersApi.md#orderscancelpost) | **POST** /Orders/cancel | 
[**OrdersPairNameGet**](OrdersApi.md#orderspairnameget) | **GET** /Orders/{pairName} | 
[**OrdersPost**](OrdersApi.md#orderspost) | **POST** /Orders | 


<a name="orderscancelpost"></a>
# **OrdersCancelPost**
> bool OrdersCancelPost (string orderId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrdersCancelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi(config);
            var orderId = orderId_example;  // string |  (optional) 

            try
            {
                bool result = apiInstance.OrdersCancelPost(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCancelPost: " + e.Message );
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
 **orderId** | **string**|  | [optional] 

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

<a name="orderspairnameget"></a>
# **OrdersPairNameGet**
> void OrdersPairNameGet (string pairName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrdersPairNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi(config);
            var pairName = pairName_example;  // string | 

            try
            {
                apiInstance.OrdersPairNameGet(pairName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersPairNameGet: " + e.Message );
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
 **pairName** | **string**|  | 

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

<a name="orderspost"></a>
# **OrdersPost**
> OrderCreateResult OrdersPost (double? amount = null, double? price = null, TradeType? tradeType = null, string pairId = null, OrderTypes? orderType = null, bool? isMargin = null, int? leverage = null, double? initialAmount = null, double? initialPrice = null, double? stopLossPrice = null, double? takeProfitPrice = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrdersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrdersApi(config);
            var amount = 1.2D;  // double? |  (optional) 
            var price = 1.2D;  // double? |  (optional) 
            var tradeType = ;  // TradeType? |  (optional) 
            var pairId = pairId_example;  // string |  (optional) 
            var orderType = ;  // OrderTypes? |  (optional) 
            var isMargin = true;  // bool? |  (optional) 
            var leverage = 56;  // int? |  (optional) 
            var initialAmount = 1.2D;  // double? |  (optional) 
            var initialPrice = 1.2D;  // double? |  (optional) 
            var stopLossPrice = 1.2D;  // double? |  (optional) 
            var takeProfitPrice = 1.2D;  // double? |  (optional) 

            try
            {
                OrderCreateResult result = apiInstance.OrdersPost(amount, price, tradeType, pairId, orderType, isMargin, leverage, initialAmount, initialPrice, stopLossPrice, takeProfitPrice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersPost: " + e.Message );
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
 **amount** | **double?**|  | [optional] 
 **price** | **double?**|  | [optional] 
 **tradeType** | **TradeType?**|  | [optional] 
 **pairId** | **string**|  | [optional] 
 **orderType** | **OrderTypes?**|  | [optional] 
 **isMargin** | **bool?**|  | [optional] 
 **leverage** | **int?**|  | [optional] 
 **initialAmount** | **double?**|  | [optional] 
 **initialPrice** | **double?**|  | [optional] 
 **stopLossPrice** | **double?**|  | [optional] 
 **takeProfitPrice** | **double?**|  | [optional] 

### Return type

[**OrderCreateResult**](OrderCreateResult.md)

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

