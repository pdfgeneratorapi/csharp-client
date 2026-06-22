# PDFGeneratorAPI.Client.Model.GenerateDocumentAsynchronousRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | [**TemplateParam**](TemplateParam.md) |  | [optional] 
**Callback** | [**CallbackParam**](CallbackParam.md) |  | [optional] 
**Format** | **FormatParam** |  | [optional] 
**Output** | **AsyncOutputParam** |  | [optional] 
**Name** | **string** | Generated document name (optional) | [optional] [default to ""]
**Testing** | **bool** | When set to true the generation is not counted as merge (monthly usage), but a large PREVIEW stamp is added. | [optional] [default to false]
**MakeAccessible** | **bool** | Enables semantic document tagging. When enabled, a separate Make Accessible action is executed, which consumes additional credits. | [optional] [default to false]
**Metadata** | [**MetadataParam**](MetadataParam.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

