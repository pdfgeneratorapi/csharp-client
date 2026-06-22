# PDFGeneratorAPI.Client.Model.StoreDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileBase64** | **string** | Base64 encoded PDF file. Required if file_url is not provided. | [optional] 
**FileUrl** | **string** | Public HTTPS URL to a PDF file. Required if file_base64 is not provided. | [optional] 
**Name** | **string** | Generated document name (optional) | [optional] [default to ""]
**Output** | **string** | Response format. &#x60;url&#x60; returns a public URL to the stored document; &#x60;viewer&#x60; returns a public URL to the PDF viewer. | [optional] [default to OutputEnum.Url]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

