# Org.OpenAPITools.Api.OrdersApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiOrdersCancelPost**](OrdersApi.md#apiorderscancelpost) | **POST** /api/Orders/cancel | 
[**ApiOrdersPairNameGet**](OrdersApi.md#apiorderspairnameget) | **GET** /api/Orders/{pairName} | 
[**ApiOrdersPost**](OrdersApi.md#apiorderspost) | **POST** /api/Orders | 


<a name="apiorderscancelpost"></a>
# **ApiOrdersCancelPost**
> OrderCancelResult ApiOrdersCancelPost (string orderId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiOrdersCancelPostExample
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
                OrderCancelResult result = apiInstance.ApiOrdersCancelPost(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ApiOrdersCancelPost: " + e.Message );
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

[**OrderCancelResult**](OrderCancelResult.md)

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

<a name="apiorderspairnameget"></a>
# **ApiOrdersPairNameGet**
> void ApiOrdersPairNameGet (string pairName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiOrdersPairNameGetExample
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
                apiInstance.ApiOrdersPairNameGet(pairName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ApiOrdersPairNameGet: " + e.Message );
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

<a name="apiorderspost"></a>
# **ApiOrdersPost**
> OrderCreateResult ApiOrdersPost (PostOrdersRequest postOrdersRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiOrdersPostExample
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
            var postOrdersRequest = new PostOrdersRequest(); // PostOrdersRequest |  (optional) 

            try
            {
                OrderCreateResult result = apiInstance.ApiOrdersPost(postOrdersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ApiOrdersPost: " + e.Message );
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
 **postOrdersRequest** | [**PostOrdersRequest**](PostOrdersRequest.md)|  | [optional] 

### Return type

[**OrderCreateResult**](OrderCreateResult.md)

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

