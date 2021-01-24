# Org.OpenAPITools.Api.ApplicationApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiApplicationDisableGoogle2stepPost**](ApplicationApi.md#apiapplicationdisablegoogle2steppost) | **POST** /api/Application/DisableGoogle2step | 
[**ApiApplicationEnableGoogle2stepPost**](ApplicationApi.md#apiapplicationenablegoogle2steppost) | **POST** /api/Application/EnableGoogle2step | 
[**ApiApplicationProcessFaceImagePost**](ApplicationApi.md#apiapplicationprocessfaceimagepost) | **POST** /api/Application/ProcessFaceImage | 
[**ApiApplicationSetpushtokenPost**](ApplicationApi.md#apiapplicationsetpushtokenpost) | **POST** /api/Application/setpushtoken | 
[**ApiApplicationValidatePinPost**](ApplicationApi.md#apiapplicationvalidatepinpost) | **POST** /api/Application/validatePin | 
[**ApiApplicationValidateapptokenPost**](ApplicationApi.md#apiapplicationvalidateapptokenpost) | **POST** /api/Application/validateapptoken | 
[**ApiApplicationVerifyfacesPost**](ApplicationApi.md#apiapplicationverifyfacespost) | **POST** /api/Application/verifyfaces | 


<a name="apiapplicationdisablegoogle2steppost"></a>
# **ApiApplicationDisableGoogle2stepPost**
> void ApiApplicationDisableGoogle2stepPost (string clientCode, string pincode, string backupCode)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationDisableGoogle2stepPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var clientCode = clientCode_example;  // string | 
            var pincode = pincode_example;  // string | 
            var backupCode = backupCode_example;  // string | 

            try
            {
                apiInstance.ApiApplicationDisableGoogle2stepPost(clientCode, pincode, backupCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationDisableGoogle2stepPost: " + e.Message );
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
 **clientCode** | **string**|  | 
 **pincode** | **string**|  | 
 **backupCode** | **string**|  | 

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

<a name="apiapplicationenablegoogle2steppost"></a>
# **ApiApplicationEnableGoogle2stepPost**
> void ApiApplicationEnableGoogle2stepPost (string clientCode, string pincode, string backupCode)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationEnableGoogle2stepPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var clientCode = clientCode_example;  // string | 
            var pincode = pincode_example;  // string | 
            var backupCode = backupCode_example;  // string | 

            try
            {
                apiInstance.ApiApplicationEnableGoogle2stepPost(clientCode, pincode, backupCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationEnableGoogle2stepPost: " + e.Message );
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
 **clientCode** | **string**|  | 
 **pincode** | **string**|  | 
 **backupCode** | **string**|  | 

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

<a name="apiapplicationprocessfaceimagepost"></a>
# **ApiApplicationProcessFaceImagePost**
> string ApiApplicationProcessFaceImagePost (string containerUUID = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationProcessFaceImagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var containerUUID = containerUUID_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiApplicationProcessFaceImagePost(containerUUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationProcessFaceImagePost: " + e.Message );
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
 **containerUUID** | **string**|  | [optional] 

### Return type

**string**

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

<a name="apiapplicationsetpushtokenpost"></a>
# **ApiApplicationSetpushtokenPost**
> bool ApiApplicationSetpushtokenPost (string pushToken = null, string description = null, DeviceType? device = null, string bitflexDeviceId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationSetpushtokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var pushToken = pushToken_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var device = ;  // DeviceType? |  (optional) 
            var bitflexDeviceId = bitflexDeviceId_example;  // string |  (optional) 

            try
            {
                bool result = apiInstance.ApiApplicationSetpushtokenPost(pushToken, description, device, bitflexDeviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationSetpushtokenPost: " + e.Message );
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
 **pushToken** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **device** | **DeviceType?**|  | [optional] 
 **bitflexDeviceId** | **string**|  | [optional] 

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

<a name="apiapplicationvalidatepinpost"></a>
# **ApiApplicationValidatePinPost**
> bool ApiApplicationValidatePinPost (string pinCode = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationValidatePinPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var pinCode = pinCode_example;  // string |  (optional) 

            try
            {
                bool result = apiInstance.ApiApplicationValidatePinPost(pinCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationValidatePinPost: " + e.Message );
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
 **pinCode** | **string**|  | [optional] 

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

<a name="apiapplicationvalidateapptokenpost"></a>
# **ApiApplicationValidateapptokenPost**
> void ApiApplicationValidateapptokenPost (string deviceInfo = null, string pushToken = null, string token = null, string deviceId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationValidateapptokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var deviceInfo = deviceInfo_example;  // string |  (optional) 
            var pushToken = pushToken_example;  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var deviceId = deviceId_example;  // string |  (optional) 

            try
            {
                apiInstance.ApiApplicationValidateapptokenPost(deviceInfo, pushToken, token, deviceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationValidateapptokenPost: " + e.Message );
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
 **deviceInfo** | **string**|  | [optional] 
 **pushToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **deviceId** | **string**|  | [optional] 

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

<a name="apiapplicationverifyfacespost"></a>
# **ApiApplicationVerifyfacesPost**
> VerifyResult ApiApplicationVerifyfacesPost (string faceId1 = null, string faceId2 = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationVerifyfacesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://172.16.1.20:5001";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var faceId1 = faceId1_example;  // string |  (optional) 
            var faceId2 = faceId2_example;  // string |  (optional) 

            try
            {
                VerifyResult result = apiInstance.ApiApplicationVerifyfacesPost(faceId1, faceId2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationVerifyfacesPost: " + e.Message );
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
 **faceId1** | **string**|  | [optional] 
 **faceId2** | **string**|  | [optional] 

### Return type

[**VerifyResult**](VerifyResult.md)

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

