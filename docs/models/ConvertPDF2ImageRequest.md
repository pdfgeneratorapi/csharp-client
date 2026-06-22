# PDFGeneratorAPI.Client.Model.ConvertPDF2ImageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileBase64** | **string** | Base64 encoded PDF file. Required if file_url is not provided. | [optional] 
**FileUrl** | **string** | Public HTTPS URL to a PDF file. Required if file_base64 is not provided. | [optional] 
**Format** | **string** | Output image format | [optional] [default to FormatEnum.Png]
**Quality** | **int** | Image quality (1-100) | [optional] [default to 85]
**Resolution** | **int** | Image resolution in DPI (72-600) | [optional] [default to 150]
**Pages** | **string** | Page number or range to convert. Use a single number (e.g. \&quot;1\&quot;) or a range (e.g. \&quot;1-4\&quot;). Defaults to all pages. | [optional] [default to "all"]
**Output** | **string** | Output format | [optional] [default to OutputEnum.Base64]
**Name** | **string** | Document name (max 120 characters). Auto-generated if not provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

