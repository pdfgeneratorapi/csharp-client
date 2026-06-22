# PDFGeneratorAPI.Client.Api.ServicesApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddWatermark**](ServicesApi.md#addwatermark) | **POST** /pdfservices/watermark | Add watermark |
| [**DecryptDocument**](ServicesApi.md#decryptdocument) | **POST** /pdfservices/decrypt | Decrypt document |
| [**EncryptDocument**](ServicesApi.md#encryptdocument) | **POST** /pdfservices/encrypt | Encrypt document |
| [**ExtractFormFields**](ServicesApi.md#extractformfields) | **POST** /pdfservices/form/fields | Extract form fields |
| [**FillFormFields**](ServicesApi.md#fillformfields) | **POST** /pdfservices/form/fill | Fill form fields |
| [**MakeAccessible**](ServicesApi.md#makeaccessible) | **POST** /pdfservices/make-accessible | Make accessible |
| [**OptimizeDocument**](ServicesApi.md#optimizedocument) | **POST** /pdfservices/optimize | Optimize document |

<a id="addwatermark"></a>
# **AddWatermark**
> InlineObject9 AddWatermark (AddWatermarkRequest addWatermarkRequest)

Add watermark

Adds a text or an image watermark to PDF document from base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addWatermarkRequest** | [**AddWatermarkRequest**](AddWatermarkRequest.md) |  |  |

### Return type

[**InlineObject9**](InlineObject9.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="decryptdocument"></a>
# **DecryptDocument**
> InlineObject9 DecryptDocument (EncryptDocumentRequest encryptDocumentRequest)

Decrypt document

Decrypts an encrypted PDF document from base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **encryptDocumentRequest** | [**EncryptDocumentRequest**](EncryptDocumentRequest.md) |  |  |

### Return type

[**InlineObject9**](InlineObject9.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="encryptdocument"></a>
# **EncryptDocument**
> InlineObject9 EncryptDocument (EncryptDocumentRequest encryptDocumentRequest)

Encrypt document

Encrypts a PDF document from base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **encryptDocumentRequest** | [**EncryptDocumentRequest**](EncryptDocumentRequest.md) |  |  |

### Return type

[**InlineObject9**](InlineObject9.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="extractformfields"></a>
# **ExtractFormFields**
> InlineObject14 ExtractFormFields (ExtractFormFieldsRequest extractFormFieldsRequest)

Extract form fields

Extracts form fields and their metadata from a PDF document using base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **extractFormFieldsRequest** | [**ExtractFormFieldsRequest**](ExtractFormFieldsRequest.md) |  |  |

### Return type

[**InlineObject14**](InlineObject14.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Form fields data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="fillformfields"></a>
# **FillFormFields**
> InlineObject9 FillFormFields (FillFormFieldsRequest fillFormFieldsRequest)

Fill form fields

Fills form fields in a PDF document with provided data from base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fillFormFieldsRequest** | [**FillFormFieldsRequest**](FillFormFieldsRequest.md) |  |  |

### Return type

[**InlineObject9**](InlineObject9.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="makeaccessible"></a>
# **MakeAccessible**
> InlineObject9 MakeAccessible (MakeAccessibleRequest makeAccessibleRequest)

Make accessible

Tags a PDF document for accessibility from base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **makeAccessibleRequest** | [**MakeAccessibleRequest**](MakeAccessibleRequest.md) |  |  |

### Return type

[**InlineObject9**](InlineObject9.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="optimizedocument"></a>
# **OptimizeDocument**
> InlineObject12 OptimizeDocument (OptimizeDocumentRequest optimizeDocumentRequest)

Optimize document

Optimizes the size of a PDF document from base64 string or a remote URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optimizeDocumentRequest** | [**OptimizeDocumentRequest**](OptimizeDocumentRequest.md) |  |  |

### Return type

[**InlineObject12**](InlineObject12.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

