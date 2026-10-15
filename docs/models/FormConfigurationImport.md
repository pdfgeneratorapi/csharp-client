# PDFGeneratorAPI.Client.Model.FormConfigurationImport
Optional form settings applied to the imported form. Form fields are created from the editable fields of the PDF.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **int** | Template ID which is connected to the form | [optional] 
**Name** | **string** | Form name | [optional] 
**Actions** | [**List&lt;FormConfigurationNewActionsInner&gt;**](FormConfigurationNewActionsInner.md) | Array of action configurations. Each action is a separate object with a single key; leave an action out to disable it. | [optional] 
**VarConfiguration** | [**FormConfiguration**](FormConfiguration.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

