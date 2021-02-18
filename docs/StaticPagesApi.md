# Org.OpenAPITools.Api.StaticPagesApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiStaticPagesAffiliateGet**](StaticPagesApi.md#apistaticpagesaffiliateget) | **GET** /api/StaticPages/affiliate | 
[**ApiStaticPagesStatusGet**](StaticPagesApi.md#apistaticpagesstatusget) | **GET** /api/StaticPages/status | 


<a name="apistaticpagesaffiliateget"></a>
# **ApiStaticPagesAffiliateGet**
> void ApiStaticPagesAffiliateGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiStaticPagesAffiliateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StaticPagesApi(config);

            try
            {
                apiInstance.ApiStaticPagesAffiliateGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticPagesApi.ApiStaticPagesAffiliateGet: " + e.Message );
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

<a name="apistaticpagesstatusget"></a>
# **ApiStaticPagesStatusGet**
> void ApiStaticPagesStatusGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiStaticPagesStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StaticPagesApi(config);

            try
            {
                apiInstance.ApiStaticPagesStatusGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticPagesApi.ApiStaticPagesStatusGet: " + e.Message );
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

