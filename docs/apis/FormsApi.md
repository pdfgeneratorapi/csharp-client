# PDFGeneratorAPI.Client.Api.FormsApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateForm**](FormsApi.md#createform) | **POST** /forms | Create form |
| [**DeleteForm**](FormsApi.md#deleteform) | **DELETE** /forms/{formId} | Delete form |
| [**GetForm**](FormsApi.md#getform) | **GET** /forms/{formId} | Get form |
| [**GetForms**](FormsApi.md#getforms) | **GET** /forms | Get forms |
| [**ImportForm**](FormsApi.md#importform) | **POST** /forms/import | Import Form |
| [**OpenFormBuilder**](FormsApi.md#openformbuilder) | **POST** /forms/open | Open new form builder |
| [**OpenFormBuilderForExistingForm**](FormsApi.md#openformbuilderforexistingform) | **POST** /forms/{formId}/open | Open existing form builder |
| [**ShareForm**](FormsApi.md#shareform) | **POST** /forms/{formId}/share | Share form |
| [**UpdateForm**](FormsApi.md#updateform) | **PUT** /forms/{formId} | Update form |

<a id="createform"></a>
# **CreateForm**
> InlineObject17 CreateForm (FormConfigurationNew formConfigurationNew)

Create form

Creates a new form based on the configuration sent in the request body.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formConfigurationNew** | [**FormConfigurationNew**](FormConfigurationNew.md) | Form configuration |  |

### Return type

[**InlineObject17**](InlineObject17.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Form configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteform"></a>
# **DeleteForm**
> void DeleteForm (int formId)

Delete form

Deletes the form with specified id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formId** | **int** | Form unique identifier |  |

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

<a id="getform"></a>
# **GetForm**
> InlineObject17 GetForm (int formId)

Get form

Returns form configuration


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formId** | **int** | Form unique identifier |  |

### Return type

[**InlineObject17**](InlineObject17.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Form configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getforms"></a>
# **GetForms**
> InlineObject6 GetForms (int page = null, int perPage = null)

Get forms

Returns a list of forms available for the organization


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Pagination: page to return | [optional] [default to 1] |
| **perPage** | **int** | Pagination: How many records to return per page | [optional] [default to 15] |

### Return type

[**InlineObject6**](InlineObject6.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of form objects |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importform"></a>
# **ImportForm**
> InlineObject17 ImportForm (ImportFormRequest importFormRequest)

Import Form

Creates a new form based on editable PDF


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importFormRequest** | [**ImportFormRequest**](ImportFormRequest.md) | Import editable PDF via URL or base64 string as form |  |

### Return type

[**InlineObject17**](InlineObject17.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Form configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="openformbuilder"></a>
# **OpenFormBuilder**
> InlineObject19 OpenFormBuilder ()

Open new form builder

Creates a new Form Builder session and returns a URL that can be used to open the embeddable Form Builder for creating a new form.


### Parameters
This endpoint does not need any parameter.
### Return type

[**InlineObject19**](InlineObject19.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Form Builder URL |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="openformbuilderforexistingform"></a>
# **OpenFormBuilderForExistingForm**
> InlineObject19 OpenFormBuilderForExistingForm (int formId)

Open existing form builder

Creates a Form Builder session for editing an existing form and returns a URL that can be used to open the embeddable Form Builder.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formId** | **int** | Form unique identifier |  |

### Return type

[**InlineObject19**](InlineObject19.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Form Builder URL |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="shareform"></a>
# **ShareForm**
> InlineObject18 ShareForm (int formId)

Share form

Creates an unique sharing URL to collect form data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formId** | **int** | Form unique identifier |  |

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
| **201** | Form sharing URL |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateform"></a>
# **UpdateForm**
> InlineObject17 UpdateForm (int formId, FormConfigurationNew formConfigurationNew)

Update form

Updates the form configuration. The form configuration must be complete as the entire configuration is replaced and not merged.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formId** | **int** | Form unique identifier |  |
| **formConfigurationNew** | [**FormConfigurationNew**](FormConfigurationNew.md) | Form configuration |  |

### Return type

[**InlineObject17**](InlineObject17.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Form configuration |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

