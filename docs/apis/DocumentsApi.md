# PDFGeneratorAPI.Client.Api.DocumentsApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteDocument**](DocumentsApi.md#deletedocument) | **DELETE** /documents/{publicId} | Delete document |
| [**GenerateDocument**](DocumentsApi.md#generatedocument) | **POST** /documents/generate | Generate document |
| [**GenerateDocumentAsynchronous**](DocumentsApi.md#generatedocumentasynchronous) | **POST** /documents/generate/async | Generate document (async) |
| [**GenerateDocumentBatch**](DocumentsApi.md#generatedocumentbatch) | **POST** /documents/generate/batch | Generate document (batch) |
| [**GenerateDocumentBatchAsynchronous**](DocumentsApi.md#generatedocumentbatchasynchronous) | **POST** /documents/generate/batch/async | Generate document (batch + async) |
| [**GetAsyncJobStatus**](DocumentsApi.md#getasyncjobstatus) | **GET** /documents/async/{jobId} | Get job status |
| [**GetDocument**](DocumentsApi.md#getdocument) | **GET** /documents/{publicId} | Get document |
| [**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /documents | Get documents |
| [**StoreDocument**](DocumentsApi.md#storedocument) | **POST** /documents | Store document |

<a id="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (string publicId)

Delete document

Delete document from the Document Storage


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicId** | **string** | Resource public id |  |

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

<a id="generatedocument"></a>
# **GenerateDocument**
> InlineObject9 GenerateDocument (GenerateDocumentRequest generateDocumentRequest)

Generate document

Merges template with data and returns base64 encoded document or a public URL to a document. NB! When the public URL option is used, the document is stored for 30 days and automatically deleted.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateDocumentRequest** | [**GenerateDocumentRequest**](GenerateDocumentRequest.md) | Request parameters, including template id, data and formats. |  |

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

<a id="generatedocumentasynchronous"></a>
# **GenerateDocumentAsynchronous**
> InlineObject20 GenerateDocumentAsynchronous (GenerateDocumentAsynchronousRequest generateDocumentAsynchronousRequest)

Generate document (async)

Merges template with data as asynchronous job and makes POST request to callback URL defined in the request. Request uses the same format as response of synchronous generation endpoint. The job id is also added to the callback request as header PDF-API-Job-Id  *Example response from callback URL:* ``` {   \"response\": \"https://us1.pdfgeneratorapi.com/share/12821/VBERi0xLjcKJeLjz9MKNyAwIG9i\",   \"meta\": {     \"name\": \"a2bd25b8921f3dc7a440fd7f427f90a4.pdf\",     \"display_name\": \"a2bd25b8921f3dc7a440fd7f427f90a4\",     \"encoding\": \"binary\",     \"content-type\": \"application/pdf\"   } } ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateDocumentAsynchronousRequest** | [**GenerateDocumentAsynchronousRequest**](GenerateDocumentAsynchronousRequest.md) | Request parameters, including template id, data and formats. |  |

### Return type

[**InlineObject20**](InlineObject20.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Async job response |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generatedocumentbatch"></a>
# **GenerateDocumentBatch**
> InlineObject9 GenerateDocumentBatch (GenerateDocumentBatchRequest generateDocumentBatchRequest)

Generate document (batch)

Allows to merge multiple templates with data and returns base64 encoded document or public URL to a document. NB! When the public URL option is used, the document is stored for 30 days and automatically deleted.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateDocumentBatchRequest** | [**GenerateDocumentBatchRequest**](GenerateDocumentBatchRequest.md) | Request parameters, including template id, data and formats. |  |

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

<a id="generatedocumentbatchasynchronous"></a>
# **GenerateDocumentBatchAsynchronous**
> InlineObject20 GenerateDocumentBatchAsynchronous (GenerateDocumentBatchAsynchronousRequest generateDocumentBatchAsynchronousRequest)

Generate document (batch + async)

Merges template with data as asynchronous job and makes POST request to callback URL defined in the request. Request uses the same format as response of synchronous generation endpoint. The job id is also added to the callback request as header PDF-API-Job-Id  *Example response from callback URL:* ``` {   \"response\": \"https://us1.pdfgeneratorapi.com/share/12821/VBERi0xLjcKJeLjz9MKNyAwIG9i\",   \"meta\": {     \"name\": \"a2bd25b8921f3dc7a440fd7f427f90a4.pdf\",     \"display_name\": \"a2bd25b8921f3dc7a440fd7f427f90a4\",     \"encoding\": \"binary\",     \"content-type\": \"application/pdf\"   } } ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateDocumentBatchAsynchronousRequest** | [**GenerateDocumentBatchAsynchronousRequest**](GenerateDocumentBatchAsynchronousRequest.md) | Request parameters, including template id, data and formats. |  |

### Return type

[**InlineObject20**](InlineObject20.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Async job response |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getasyncjobstatus"></a>
# **GetAsyncJobStatus**
> InlineObject13 GetAsyncJobStatus (string jobId)

Get job status

Returns status of an async job


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** | Job id |  |

### Return type

[**InlineObject13**](InlineObject13.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Async job status |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdocument"></a>
# **GetDocument**
> InlineObject11 GetDocument (string publicId)

Get document

Returns document stored in the Document Storage


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicId** | **string** | Resource public id |  |

### Return type

[**InlineObject11**](InlineObject11.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdocuments"></a>
# **GetDocuments**
> InlineObject15 GetDocuments (int templateId = null, string startDate = null, string endDate = null, int page = null, int perPage = null)

Get documents

Returns a list of generated documents created by authorized workspace and stored in PDF Generator API. If master user is specified as workspace in JWT then all documents created in the organization are returned. NB! This endpoint returns only documents generated using the output=url option.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Template unique identifier | [optional]  |
| **startDate** | **string** | Start date. Format: Y-m-d H:i:s | [optional]  |
| **endDate** | **string** | End date. Format: Y-m-d H:i:s. Defaults to current timestamp | [optional]  |
| **page** | **int** | Pagination: page to return | [optional] [default to 1] |
| **perPage** | **int** | Pagination: How many records to return per page | [optional] [default to 15] |

### Return type

[**InlineObject15**](InlineObject15.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of generated documents |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="storedocument"></a>
# **StoreDocument**
> InlineObject11 StoreDocument (StoreDocumentRequest storeDocumentRequest)

Store document

Uploads a PDF as a URL or a base64 encoded string.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeDocumentRequest** | [**StoreDocumentRequest**](StoreDocumentRequest.md) | Document source and optional metadata. Exactly one of &#x60;file_base64&#x60; or &#x60;file_url&#x60; is required. |  |

### Return type

[**InlineObject11**](InlineObject11.md)

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

