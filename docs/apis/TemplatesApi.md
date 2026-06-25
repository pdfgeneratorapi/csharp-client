# PDFGeneratorAPI.Client.Api.TemplatesApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopyTemplate**](TemplatesApi.md#copytemplate) | **POST** /templates/{templateId}/copy | Copy template |
| [**CreateTemplate**](TemplatesApi.md#createtemplate) | **POST** /templates | Create template |
| [**DeleteTemplate**](TemplatesApi.md#deletetemplate) | **DELETE** /templates/{templateId} | Delete template |
| [**GetTemplate**](TemplatesApi.md#gettemplate) | **GET** /templates/{templateId} | Get template |
| [**GetTemplateData**](TemplatesApi.md#gettemplatedata) | **GET** /templates/{templateId}/data | Get template data fields |
| [**GetTemplateSchema**](TemplatesApi.md#gettemplateschema) | **GET** /templates/schema | Get schema |
| [**GetTemplates**](TemplatesApi.md#gettemplates) | **GET** /templates | Get templates |
| [**ImportTemplate**](TemplatesApi.md#importtemplate) | **POST** /templates/import | Import template |
| [**OpenEditor**](TemplatesApi.md#openeditor) | **POST** /templates/{templateId}/editor | Open editor |
| [**UpdateTemplate**](TemplatesApi.md#updatetemplate) | **PUT** /templates/{templateId} | Update template |
| [**ValidateTemplate**](TemplatesApi.md#validatetemplate) | **POST** /templates/validate | Validate template |

<a id="copytemplate"></a>
# **CopyTemplate**
> InlineObject18 CopyTemplate (int templateId, CopyTemplateRequest copyTemplateRequest = null)

Copy template

Creates a copy of a template to the workspace specified in authentication parameters.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **copyTemplateRequest** | [**CopyTemplateRequest**](CopyTemplateRequest.md) |  | [optional]  |

### Return type

[**InlineObject18**](InlineObject18.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Template configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createtemplate"></a>
# **CreateTemplate**
> InlineObject18 CreateTemplate (TemplateDefinitionNew templateDefinitionNew)

Create template

Creates a new template. If template configuration is not specified in the request body then an empty template is created. Template is placed to the workspace specified in authentication params. Template configuration must be sent in the request body.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateDefinitionNew** | [**TemplateDefinitionNew**](TemplateDefinitionNew.md) | Template configuration |  |

### Return type

[**InlineObject18**](InlineObject18.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Template configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetemplate"></a>
# **DeleteTemplate**
> void DeleteTemplate (int templateId)

Delete template

Deletes the template from workspace


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |

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
| **204** | The resource was deleted successfully. |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplate"></a>
# **GetTemplate**
> InlineObject18 GetTemplate (int templateId)

Get template

Returns template configuration


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |

### Return type

[**InlineObject18**](InlineObject18.md)

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
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplatedata"></a>
# **GetTemplateData**
> InlineObject2 GetTemplateData (int templateId)

Get template data fields

Returns all data fields used in the template. Returns structured JSON data that can be used to check which data fields are used in template or autogenerate sample data. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |

### Return type

[**InlineObject2**](InlineObject2.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Template data structure |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplateschema"></a>
# **GetTemplateSchema**
> Object GetTemplateSchema ()

Get schema

Returns Template JSON Schema which defines the structure of the Template Definition.


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Template JSON Schema |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplates"></a>
# **GetTemplates**
> InlineObject4 GetTemplates (string name = null, string tags = null, string access = null, int page = null, int perPage = null)

Get templates

Returns a list of templates available for the authenticated workspace


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter template by name | [optional]  |
| **tags** | **string** | Filter template by tags | [optional]  |
| **access** | **string** | Filter template by access type. No values returns all templates. private - returns only private templates, organization - returns only organization templates. | [optional]  |
| **page** | **int** | Pagination: page to return | [optional] [default to 1] |
| **perPage** | **int** | Pagination: How many records to return per page | [optional] [default to 15] |

### Return type

[**InlineObject4**](InlineObject4.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of template objects |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importtemplate"></a>
# **ImportTemplate**
> InlineObject18 ImportTemplate (ImportTemplateRequest importTemplateRequest)

Import template

Creates a template from existing PDF


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importTemplateRequest** | [**ImportTemplateRequest**](ImportTemplateRequest.md) | Import a PDF via URL or base64 string as template |  |

### Return type

[**InlineObject18**](InlineObject18.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Template configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="openeditor"></a>
# **OpenEditor**
> InlineObject3 OpenEditor (int templateId, OpenEditorRequest openEditorRequest)

Open editor

Returns an unique URL which you can use to redirect your user to the editor from your application or use the generated URL as iframe source to show the editor within your application. When using iframe, make sure that your browser allows third-party cookies. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **openEditorRequest** | [**OpenEditorRequest**](OpenEditorRequest.md) |  |  |

### Return type

[**InlineObject3**](InlineObject3.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an URL which you can use to redirect your user to the editor or use as iframe source |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> InlineObject18 UpdateTemplate (int templateId, TemplateDefinitionNew templateDefinitionNew)

Update template

Updates template configuration. The template configuration for pages and layout must be complete as the entire configuration is replaced and not merged.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier |  |
| **templateDefinitionNew** | [**TemplateDefinitionNew**](TemplateDefinitionNew.md) | Template configuration |  |

### Return type

[**InlineObject18**](InlineObject18.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Template configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="validatetemplate"></a>
# **ValidateTemplate**
> InlineObject1 ValidateTemplate (TemplateDefinitionNew templateDefinitionNew)

Validate template

Validates if the provided template configuration matches the template JSON schema.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateDefinitionNew** | [**TemplateDefinitionNew**](TemplateDefinitionNew.md) | Template configuration |  |

### Return type

[**InlineObject1**](InlineObject1.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Template validation response |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

