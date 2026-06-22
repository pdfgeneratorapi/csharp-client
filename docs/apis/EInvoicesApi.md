# PDFGeneratorAPI.Client.Api.EInvoicesApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEInvoice**](EInvoicesApi.md#createeinvoice) | **POST** /einvoice | Create eInvoice |
| [**CreateFacturXEInvoice**](EInvoicesApi.md#createfacturxeinvoice) | **POST** /einvoice/facturx | Create Factur-X eInvoice |
| [**CreateXRechnungEInvoice**](EInvoicesApi.md#createxrechnungeinvoice) | **POST** /einvoice/xrechnung | Create XRechnung eInvoice |
| [**GetEInvoiceSchema**](EInvoicesApi.md#geteinvoiceschema) | **GET** /einvoice/schema | Get schema |

<a id="createeinvoice"></a>
# **CreateEInvoice**
> InlineObject CreateEInvoice (CreateEInvoiceRequest createEInvoiceRequest)

Create eInvoice

This endpoint transforms a JSON payload into an XML-based e-invoice that is fully compliant with the European EN 16931 standard. The generated output can be formatted in either UBL (Universal Business Language) or CII (Cross-Industry Invoice) syntax, ensuring interoperability across B2B and B2G platforms. The JSON payload follows Peppol BIS Billing 3.0 UBL Invoice described here: https://docs.peppol.eu/poacc/billing/3.0/


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEInvoiceRequest** | [**CreateEInvoiceRequest**](CreateEInvoiceRequest.md) | eInvoice conversion |  |

### Return type

[**InlineObject**](InlineObject.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | XML-based e-invoice response |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createfacturxeinvoice"></a>
# **CreateFacturXEInvoice**
> InlineObject9 CreateFacturXEInvoice (CreateFacturXEInvoiceRequest createFacturXEInvoiceRequest)

Create Factur-X eInvoice

This endpoint transforms a JSON payload a Factur-X e-invoice that is fully compliant with the European EN 16931 standard. The generated output is always a PDF document, embedding a structured CII (Cross-Industry Invoice) XML according to the Factur-X format into a human-readable invoice, ensuring interoperability across B2B and B2G platforms. The JSON payload follows Peppol BIS Billing 3.0 UBL Invoice described here: https://docs.peppol.eu/poacc/billing/3.0/


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFacturXEInvoiceRequest** | [**CreateFacturXEInvoiceRequest**](CreateFacturXEInvoiceRequest.md) | eInvoice conversion |  |

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

<a id="createxrechnungeinvoice"></a>
# **CreateXRechnungEInvoice**
> InlineObject CreateXRechnungEInvoice (CreateEInvoiceRequest createEInvoiceRequest)

Create XRechnung eInvoice

This endpoint transforms a JSON payload into an XML-based XRechnung e-invoice that is fully compliant with the European EN 16931 standard. The generated output follows the XRechnung format and can be formatted in either UBL (Universal Business Language) or CII (Cross-Industry Invoice) syntax, ensuring interoperability across B2B and B2G platforms. The JSON payload follows Peppol BIS Billing 3.0 UBL Invoice described here: https://docs.peppol.eu/poacc/billing/3.0/


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEInvoiceRequest** | [**CreateEInvoiceRequest**](CreateEInvoiceRequest.md) | eInvoice conversion |  |

### Return type

[**InlineObject**](InlineObject.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | XML-based e-invoice response |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteinvoiceschema"></a>
# **GetEInvoiceSchema**
> Object GetEInvoiceSchema ()

Get schema

Returns e-invoice JSON schema which defines the structure of the e-invoice.


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

