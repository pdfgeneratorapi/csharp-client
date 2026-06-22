# PDFGeneratorAPI.Client.Api.TemplateLibraryApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTemplateLibrary**](TemplateLibraryApi.md#gettemplatelibrary) | **GET** /templates/library | Get template library |
| [**GetTemplateLibraryItem**](TemplateLibraryApi.md#gettemplatelibraryitem) | **GET** /templates/library/{publicId} | Open template from the library |

<a id="gettemplatelibrary"></a>
# **GetTemplateLibrary**
> GetTemplateLibrary200Response GetTemplateLibrary (string tags = null)

Get template library

Returns a list of publicly available templates from the template library. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tags** | **string** | Filter template by tags | [optional]  |

### Return type

[**GetTemplateLibrary200Response**](GetTemplateLibrary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of public templates |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplatelibraryitem"></a>
# **GetTemplateLibraryItem**
> InlineObject16 GetTemplateLibraryItem (string publicId)

Open template from the library

Returns the template definition for a public template identified by its `public_id`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicId** | **string** | Resource public id |  |

### Return type

[**InlineObject16**](InlineObject16.md)

### Authorization

No authorization required

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
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

