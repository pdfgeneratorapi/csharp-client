# PDFGeneratorAPI.Client.Model.TemplateDefinitionNewLayout
Defines template layout (e.g page format, margins).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | Defines template page size | [optional] [default to FormatEnum.A4]
**Width** | **decimal** | Page width in units | [optional] 
**Height** | **decimal** | Page height in units | [optional] 
**Unit** | **string** | Measure unit | [optional] [default to UnitEnum.Cm]
**Orientation** | **string** | Page orientation | [optional] 
**Rotation** | **int** | Page rotation in degrees | [optional] 
**Margins** | [**TemplateDefinitionNewLayoutMargins**](TemplateDefinitionNewLayoutMargins.md) |  | [optional] 
**RepeatLayout** | [**TemplateDefinitionNewLayoutRepeatLayout**](TemplateDefinitionNewLayoutRepeatLayout.md) |  | [optional] 
**EmptyLabels** | **int** | Specifies how many blank lables to add to sheet label. | [optional] [default to 0]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

