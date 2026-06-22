# PDFGeneratorAPI.Client.Api.ConversionApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConvertHTML2PDF**](ConversionApi.md#converthtml2pdf) | **POST** /conversion/html2pdf | HTML to PDF |
| [**ConvertPDF2Image**](ConversionApi.md#convertpdf2image) | **POST** /conversion/pdf2image | PDF to Image |
| [**ConvertURL2PDF**](ConversionApi.md#converturl2pdf) | **POST** /conversion/url2pdf | URL to PDF |

<a id="converthtml2pdf"></a>
# **ConvertHTML2PDF**
> InlineObject9 ConvertHTML2PDF (ConvertHTML2PDFRequest convertHTML2PDFRequest)

HTML to PDF

Converts HTML content to PDF


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convertHTML2PDFRequest** | [**ConvertHTML2PDFRequest**](ConvertHTML2PDFRequest.md) |  |  |

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

<a id="convertpdf2image"></a>
# **ConvertPDF2Image**
> InlineObject10 ConvertPDF2Image (ConvertPDF2ImageRequest convertPDF2ImageRequest)

PDF to Image

Converts PDF document to images. Provide either a base64 encoded PDF or a public URL to a PDF file.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convertPDF2ImageRequest** | [**ConvertPDF2ImageRequest**](ConvertPDF2ImageRequest.md) |  |  |

### Return type

[**InlineObject10**](InlineObject10.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | PDF to image conversion result |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="converturl2pdf"></a>
# **ConvertURL2PDF**
> InlineObject9 ConvertURL2PDF (ConvertURL2PDFRequest convertURL2PDFRequest)

URL to PDF

Converts public URL to PDF


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convertURL2PDFRequest** | [**ConvertURL2PDFRequest**](ConvertURL2PDFRequest.md) |  |  |

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

