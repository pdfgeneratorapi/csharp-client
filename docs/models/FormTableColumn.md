# PDFGeneratorAPI.Client.Model.FormTableColumn
Table column definition. Column names must be unique within the table.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Column label displayed in the form | 
**Name** | **string** | Data field name of the column | 
**Type** | **string** | Column type. &#x60;select&#x60; columns require &#x60;subRows&#x60; with options and a &#x60;default&#x60; value. | 
**Required** | **bool** | Specifies if the column is required or not | 
**Default** | **string** | Value pre-filled in the column. Required for &#x60;select&#x60; columns and must be one of the options. | [optional] 
**SubRows** | [**List&lt;FormFieldOptions&gt;**](FormFieldOptions.md) | Options for &#x60;select&#x60; columns (a single object). Not used by other column types. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

