# Org.OpenAPITools.Api.SignApi

All URIs are relative to *http://172.16.1.20:5001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiSignAskForPermissionPost**](SignApi.md#apisignaskforpermissionpost) | **POST** /api/Sign/AskForPermission | 
[**ApiSignAskPermissionSignInPost**](SignApi.md#apisignaskpermissionsigninpost) | **POST** /api/Sign/AskPermissionSignIn | 
[**ApiSignCheck2StepVerificationStatusGet**](SignApi.md#apisigncheck2stepverificationstatusget) | **GET** /api/Sign/Check2StepVerificationStatus | 
[**ApiSignConfirmPermissionSignInPost**](SignApi.md#apisignconfirmpermissionsigninpost) | **POST** /api/Sign/ConfirmPermissionSignIn | 
[**ApiSignConfirmemailPost**](SignApi.md#apisignconfirmemailpost) | **POST** /api/Sign/confirmemail | 
[**ApiSignGetPermissionDetailsGet**](SignApi.md#apisigngetpermissiondetailsget) | **GET** /api/Sign/GetPermissionDetails | 
[**ApiSignGetreferreremailPost**](SignApi.md#apisigngetreferreremailpost) | **POST** /api/Sign/getreferreremail | 
[**ApiSignIsAnyDeviceOnlinePost**](SignApi.md#apisignisanydeviceonlinepost) | **POST** /api/Sign/IsAnyDeviceOnline | 
[**ApiSignMobileConfirmationRequestPost**](SignApi.md#apisignmobileconfirmationrequestpost) | **POST** /api/Sign/MobileConfirmationRequest | 
[**ApiSignResetpasswordPost**](SignApi.md#apisignresetpasswordpost) | **POST** /api/Sign/resetpassword | 
[**ApiSignRestorepasswordPost**](SignApi.md#apisignrestorepasswordpost) | **POST** /api/Sign/restorepassword | 
[**ApiSignSetAffiliatePost**](SignApi.md#apisignsetaffiliatepost) | **POST** /api/Sign/setAffiliate | 
[**ApiSignSigninPost**](SignApi.md#apisignsigninpost) | **POST** /api/Sign/signin | 
[**ApiSignSignupPost**](SignApi.md#apisignsignuppost) | **POST** /api/Sign/signup | 


<a name="apisignaskforpermissionpost"></a>
# **ApiSignAskForPermissionPost**
> bool ApiSignAskForPermissionPost (AskForPermissionRequestModel askForPermissionRequestModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignAskForPermissionPostExample
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
            var askForPermissionRequestModel = new AskForPermissionRequestModel(); // AskForPermissionRequestModel |  (optional) 

            try
            {
                bool result = apiInstance.ApiSignAskForPermissionPost(askForPermissionRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignAskForPermissionPost: " + e.Message );
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
 **askForPermissionRequestModel** | [**AskForPermissionRequestModel**](AskForPermissionRequestModel.md)|  | [optional] 

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

<a name="apisignaskpermissionsigninpost"></a>
# **ApiSignAskPermissionSignInPost**
> bool ApiSignAskPermissionSignInPost (AskForPermissionRequestModel askForPermissionRequestModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignAskPermissionSignInPostExample
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
            var askForPermissionRequestModel = new AskForPermissionRequestModel(); // AskForPermissionRequestModel |  (optional) 

            try
            {
                bool result = apiInstance.ApiSignAskPermissionSignInPost(askForPermissionRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignAskPermissionSignInPost: " + e.Message );
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
 **askForPermissionRequestModel** | [**AskForPermissionRequestModel**](AskForPermissionRequestModel.md)|  | [optional] 

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

<a name="apisigncheck2stepverificationstatusget"></a>
# **ApiSignCheck2StepVerificationStatusGet**
> Check2StepVerificationStatusResponse ApiSignCheck2StepVerificationStatusGet (string bitflexDeviceId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignCheck2StepVerificationStatusGetExample
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
            var bitflexDeviceId = bitflexDeviceId_example;  // string |  (optional) 

            try
            {
                Check2StepVerificationStatusResponse result = apiInstance.ApiSignCheck2StepVerificationStatusGet(bitflexDeviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignCheck2StepVerificationStatusGet: " + e.Message );
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
 **bitflexDeviceId** | **string**|  | [optional] 

### Return type

[**Check2StepVerificationStatusResponse**](Check2StepVerificationStatusResponse.md)

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

<a name="apisignconfirmpermissionsigninpost"></a>
# **ApiSignConfirmPermissionSignInPost**
> bool ApiSignConfirmPermissionSignInPost (ConfirmPermissionSignInRequest confirmPermissionSignInRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignConfirmPermissionSignInPostExample
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
            var confirmPermissionSignInRequest = new ConfirmPermissionSignInRequest(); // ConfirmPermissionSignInRequest |  (optional) 

            try
            {
                bool result = apiInstance.ApiSignConfirmPermissionSignInPost(confirmPermissionSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignConfirmPermissionSignInPost: " + e.Message );
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
 **confirmPermissionSignInRequest** | [**ConfirmPermissionSignInRequest**](ConfirmPermissionSignInRequest.md)|  | [optional] 

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

<a name="apisigngetpermissiondetailsget"></a>
# **ApiSignGetPermissionDetailsGet**
> SignInPermissionModel ApiSignGetPermissionDetailsGet (string id = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignGetPermissionDetailsGetExample
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
            var id = id_example;  // string |  (optional) 

            try
            {
                SignInPermissionModel result = apiInstance.ApiSignGetPermissionDetailsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignGetPermissionDetailsGet: " + e.Message );
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
 **id** | **string**|  | [optional] 

### Return type

[**SignInPermissionModel**](SignInPermissionModel.md)

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

<a name="apisignisanydeviceonlinepost"></a>
# **ApiSignIsAnyDeviceOnlinePost**
> void ApiSignIsAnyDeviceOnlinePost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSignIsAnyDeviceOnlinePostExample
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
                apiInstance.ApiSignIsAnyDeviceOnlinePost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignApi.ApiSignIsAnyDeviceOnlinePost: " + e.Message );
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

<a name="apisignmobileconfirmationrequestpost"></a>
# **ApiSignMobileConfirmationRequestPost**
> void ApiSignMobileConfirmationRequestPost (PostMobileConfirmationRequestModel postMobileConfirmationRequestModel = null)



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
            var postMobileConfirmationRequestModel = new PostMobileConfirmationRequestModel(); // PostMobileConfirmationRequestModel |  (optional) 

            try
            {
                apiInstance.ApiSignMobileConfirmationRequestPost(postMobileConfirmationRequestModel);
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
 **postMobileConfirmationRequestModel** | [**PostMobileConfirmationRequestModel**](PostMobileConfirmationRequestModel.md)|  | [optional] 

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

