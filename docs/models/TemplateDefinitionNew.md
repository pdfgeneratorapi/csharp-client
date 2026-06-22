# PDFGeneratorAPI.Client.Model.TemplateDefinitionNew
Template configuration. Use the Get schema endpoint to see the detailed payload structure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Template name | 
**Tags** | **List&lt;string&gt;** | A list of tags assigned to a template | [optional] 
**IsDraft** | **bool** | Indicates if the template is a draft or published. | [optional] 
**Layout** | [**TemplateDefinitionNewLayout**](TemplateDefinitionNewLayout.md) |  | [optional] 
**Pages** | [**List&lt;TemplateDefinitionNewPagesInner&gt;**](TemplateDefinitionNewPagesInner.md) | Defines page or label size, margins and components on page or label | [optional] 
**DataSettings** | [**TemplateDefinitionNewDataSettings**](TemplateDefinitionNewDataSettings.md) |  | [optional] 
**Editor** | [**TemplateDefinitionNewEditor**](TemplateDefinitionNewEditor.md) |  | [optional] 
**FontSubsetting** | **bool** | If font-subsetting is applied to document when generated | [optional] [default to false]
**BarcodeAsImage** | **bool** | Defines if barcodes are rendered as raster images instead of vector graphics. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

