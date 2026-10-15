# PDFGeneratorAPI.Client.Model.ConvertURL2PDFRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Public URL | [optional] 
**PaperSize** | **string** | PDF page size | [optional] [default to PaperSizeEnum.A4]
**Orientation** | **string** |  | [optional] [default to OrientationEnum.Portrait]
**Output** | **string** | Output | [optional] [default to OutputEnum.Base64]
**Filename** | **string** | Document name | [optional] 
**WaitForCss** | **string** | CSS selector of an element to wait for before the page is printed; see &#x60;wait_for_css_state&#x60; | [optional] 
**WaitForCssState** | **string** | How &#x60;wait_for_css&#x60; matches. &#x60;present&#x60; waits until the element exists, even if it is empty or hidden (e.g. a &#x60;&lt;div id&#x3D;\&quot;report-ready\&quot;&gt;&lt;/div&gt;&#x60; marker); &#x60;visible&#x60; waits until it is also visible with a non-empty size (e.g. a chart that appears when data has loaded). | [optional] [default to WaitForCssStateEnum.Present]
**WaitForJs** | **string** | JavaScript expression evaluated in the page every 100ms; the page is printed once it is truthy. Promises are awaited, and an expression that throws counts as not ready yet. | [optional] 
**WaitTimeout** | **int** | Seconds to wait for &#x60;wait_for_css&#x60; / &#x60;wait_for_js&#x60; before applying &#x60;on_wait_timeout&#x60; | [optional] [default to 30]
**OnWaitTimeout** | **string** | What to do when the wait signal is not met within &#x60;wait_timeout&#x60;. &#x60;error&#x60; returns a 422 response; &#x60;print&#x60; prints the page as it is. | [optional] [default to OnWaitTimeoutEnum.Error]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

