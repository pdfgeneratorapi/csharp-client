# PDFGeneratorAPI.Client.Api.TemplateVersionsApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTemplateVersion**](TemplateVersionsApi.md#deletetemplateversion) | **DELETE** /templates/{templateId}/versions/{templateVersion} | Delete template version |
| [**GetTemplateVersion**](TemplateVersionsApi.md#gettemplateversion) | **GET** /templates/{templateId}/versions/{templateVersion} | Get template version |
| [**ListTemplateVersions**](TemplateVersionsApi.md#listtemplateversions) | **GET** /templates/{templateId}/versions | List template versions |
| [**PromoteTemplateVersion**](TemplateVersionsApi.md#promotetemplateversion) | **PUT** /templates/{templateId}/versions/{templateVersion}/promote | Promote template version |

<a id="deletetemplateversion"></a>
# **DeleteTemplateVersion**
> void DeleteTemplateVersion (int templateId, int templateVersion)

Delete template version

Deletes the specified template version. Production versions cannot be deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **templateVersion** | **int** | Unique ID of the template version. |  |

### Return type

void (empty response body)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Template version deleted successfully |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplateversion"></a>
# **GetTemplateVersion**
> InlineObject16 GetTemplateVersion (int templateId, int templateVersion)

Get template version

Returns the template definition of the specified version. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **templateVersion** | **int** | Unique ID of the template version. |  |

### Return type

[**InlineObject16**](InlineObject16.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Template configuration |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Cannot delete production template version |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtemplateversions"></a>
# **ListTemplateVersions**
> TemplateVersionCollection ListTemplateVersions (int templateId, int perPage = null, int page = null)

List template versions

Returns a paginated list of template versions for the specified template. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **perPage** | **int** | Number of items per page. | [optional]  |
| **page** | **int** | Page number to return. | [optional]  |

### Return type

[**TemplateVersionCollection**](TemplateVersionCollection.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of template versions |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="promotetemplateversion"></a>
# **PromoteTemplateVersion**
> PromoteTemplateVersion200Response PromoteTemplateVersion (int templateId, int templateVersion)

Promote template version

Promotes the specified template version to production. Only one version can be production at a time. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **templateVersion** | **int** | Unique ID of the template version. |  |

### Return type

[**PromoteTemplateVersion200Response**](PromoteTemplateVersion200Response.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Template version promoted successfully |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

