# PDFGeneratorAPI.Client.Api.AssetsApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateQRCode**](AssetsApi.md#generateqrcode) | **POST** /assets/qrcode | Generate QR Code |

<a id="generateqrcode"></a>
# **GenerateQRCode**
> GenerateQRCode201Response GenerateQRCode (GenerateQRCodeRequest generateQRCodeRequest)

Generate QR Code

Creates a QR code based on the configuration


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateQRCodeRequest** | [**GenerateQRCodeRequest**](GenerateQRCodeRequest.md) | QR Code configuration |  |

### Return type

[**GenerateQRCode201Response**](GenerateQRCode201Response.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | QR code response |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

