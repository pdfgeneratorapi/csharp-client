# PDFGeneratorAPI.Client.Model.FormConfigurationNew

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Form name | 
**Actions** | [**List&lt;FormConfigurationNewActionsInner&gt;**](FormConfigurationNewActionsInner.md) | Array of action configurations. Each action is a separate object with a single key; leave an action out to disable it. | 
**Fields** | [**List&lt;FormField&gt;**](FormField.md) | Input fields shown on the form, in display order. Field names must be unique within the form. | 
**TemplateId** | **int** | Template ID which is connected to the form | [optional] 
**VarConfiguration** | [**FormConfiguration**](FormConfiguration.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

