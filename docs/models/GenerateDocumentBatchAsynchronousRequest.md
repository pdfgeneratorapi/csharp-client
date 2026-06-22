# PDFGeneratorAPI.Client.Model.GenerateDocumentBatchAsynchronousRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | [**List&lt;TemplateParam&gt;**](TemplateParam.md) |  | [optional] 
**Callback** | [**CallbackParam**](CallbackParam.md) |  | [optional] 
**Format** | **FormatParam** |  | [optional] 
**Output** | **AsyncOutputParam** |  | [optional] 
**Name** | **string** | Generated document name (optional) | [optional] [default to ""]
**Testing** | **bool** | When set to true the generation is not counted as merge (monthly usage), but a large PREVIEW stamp is added. | [optional] [default to false]
**Metadata** | [**MetadataParam**](MetadataParam.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

