# PDFGeneratorAPI.Client.Model.DocumentSignatures

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The one-line answer, reduced from every signature worst case first. &#x60;unavailable&#x60; means signature validation is not enabled on this deployment — it says nothing about the document.  | [optional] 
**StatusLabel** | **string** | The status in words, ready to display. | [optional] 
**HasLongTermValidation** | **bool** | The document carries the certificate and revocation data needed to verify it after the signing certificates expire.  | [optional] 
**CoversWholeDocument** | **bool** | The last signature covers every byte, so nothing was appended after it. | [optional] 
**DocumentTimestamps** | **int** | Timestamp-only signatures, counted rather than listed: they are machinery, not people, and would double every signer.  | [optional] 
**Signatures** | [**List&lt;DocumentSignature&gt;**](DocumentSignature.md) | One entry per signature, excluding document timestamps. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

