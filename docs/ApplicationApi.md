# Org.OpenAPITools.Api.ApplicationApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiApplicationDisableGoogle2stepPost**](ApplicationApi.md#apiapplicationdisablegoogle2steppost) | **POST** /api/Application/DisableGoogle2step | 
[**ApiApplicationEnableGoogle2stepPost**](ApplicationApi.md#apiapplicationenablegoogle2steppost) | **POST** /api/Application/EnableGoogle2step | 
[**ApiApplicationProcessFaceImagePost**](ApplicationApi.md#apiapplicationprocessfaceimagepost) | **POST** /api/Application/ProcessFaceImage | 
[**ApiApplicationProcessPassportImagePost**](ApplicationApi.md#apiapplicationprocesspassportimagepost) | **POST** /api/Application/ProcessPassportImage | 
[**ApiApplicationSetpushtokenPost**](ApplicationApi.md#apiapplicationsetpushtokenpost) | **POST** /api/Application/setpushtoken | 
[**ApiApplicationValidatePinPost**](ApplicationApi.md#apiapplicationvalidatepinpost) | **POST** /api/Application/validatePin | 
[**ApiApplicationValidateapptokenPost**](ApplicationApi.md#apiapplicationvalidateapptokenpost) | **POST** /api/Application/validateapptoken | 
[**ApiApplicationVerifyfacesPost**](ApplicationApi.md#apiapplicationverifyfacespost) | **POST** /api/Application/verifyfaces | 


<a name="apiapplicationdisablegoogle2steppost"></a>
# **ApiApplicationDisableGoogle2stepPost**
> void ApiApplicationDisableGoogle2stepPost (EnableDisable2Fa enableDisable2Fa = null)



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
            var enableDisable2Fa = new EnableDisable2Fa(); // EnableDisable2Fa |  (optional) 

            try
            {
                apiInstance.ApiApplicationDisableGoogle2stepPost(enableDisable2Fa);
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
 **enableDisable2Fa** | [**EnableDisable2Fa**](EnableDisable2Fa.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiapplicationenablegoogle2steppost"></a>
# **ApiApplicationEnableGoogle2stepPost**
> void ApiApplicationEnableGoogle2stepPost (EnableDisable2Fa enableDisable2Fa = null)



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
            var enableDisable2Fa = new EnableDisable2Fa(); // EnableDisable2Fa |  (optional) 

            try
            {
                apiInstance.ApiApplicationEnableGoogle2stepPost(enableDisable2Fa);
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
 **enableDisable2Fa** | [**EnableDisable2Fa**](EnableDisable2Fa.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiapplicationprocessfaceimagepost"></a>
# **ApiApplicationProcessFaceImagePost**
> string ApiApplicationProcessFaceImagePost (ProcessFaceImageRequest processFaceImageRequest = null)



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
            var processFaceImageRequest = new ProcessFaceImageRequest(); // ProcessFaceImageRequest |  (optional) 

            try
            {
                string result = apiInstance.ApiApplicationProcessFaceImagePost(processFaceImageRequest);
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
 **processFaceImageRequest** | [**ProcessFaceImageRequest**](ProcessFaceImageRequest.md)|  | [optional] 

### Return type

**string**

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

<a name="apiapplicationprocesspassportimagepost"></a>
# **ApiApplicationProcessPassportImagePost**
> string ApiApplicationProcessPassportImagePost (ProcessFaceImageRequest processFaceImageRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiApplicationProcessPassportImagePostExample
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
            var processFaceImageRequest = new ProcessFaceImageRequest(); // ProcessFaceImageRequest |  (optional) 

            try
            {
                string result = apiInstance.ApiApplicationProcessPassportImagePost(processFaceImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationProcessPassportImagePost: " + e.Message );
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
 **processFaceImageRequest** | [**ProcessFaceImageRequest**](ProcessFaceImageRequest.md)|  | [optional] 

### Return type

**string**

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

<a name="apiapplicationsetpushtokenpost"></a>
# **ApiApplicationSetpushtokenPost**
> bool ApiApplicationSetpushtokenPost (SetPushTokenRequest setPushTokenRequest = null)



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
            var setPushTokenRequest = new SetPushTokenRequest(); // SetPushTokenRequest |  (optional) 

            try
            {
                bool result = apiInstance.ApiApplicationSetpushtokenPost(setPushTokenRequest);
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
 **setPushTokenRequest** | [**SetPushTokenRequest**](SetPushTokenRequest.md)|  | [optional] 

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

<a name="apiapplicationvalidatepinpost"></a>
# **ApiApplicationValidatePinPost**
> bool ApiApplicationValidatePinPost (ValidatePinPostRequest validatePinPostRequest = null)



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
            var validatePinPostRequest = new ValidatePinPostRequest(); // ValidatePinPostRequest |  (optional) 

            try
            {
                bool result = apiInstance.ApiApplicationValidatePinPost(validatePinPostRequest);
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
 **validatePinPostRequest** | [**ValidatePinPostRequest**](ValidatePinPostRequest.md)|  | [optional] 

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

<a name="apiapplicationvalidateapptokenpost"></a>
# **ApiApplicationValidateapptokenPost**
> void ApiApplicationValidateapptokenPost (ValidateAppTokenRequest validateAppTokenRequest = null)



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
            var validateAppTokenRequest = new ValidateAppTokenRequest(); // ValidateAppTokenRequest |  (optional) 

            try
            {
                apiInstance.ApiApplicationValidateapptokenPost(validateAppTokenRequest);
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
 **validateAppTokenRequest** | [**ValidateAppTokenRequest**](ValidateAppTokenRequest.md)|  | [optional] 

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

<a name="apiapplicationverifyfacespost"></a>
# **ApiApplicationVerifyfacesPost**
> VerifyResult ApiApplicationVerifyfacesPost (VerifyFaceData verifyFaceData = null)



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
            var verifyFaceData = new VerifyFaceData(); // VerifyFaceData |  (optional) 

            try
            {
                VerifyResult result = apiInstance.ApiApplicationVerifyfacesPost(verifyFaceData);
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
 **verifyFaceData** | [**VerifyFaceData**](VerifyFaceData.md)|  | [optional] 

### Return type

[**VerifyResult**](VerifyResult.md)

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

