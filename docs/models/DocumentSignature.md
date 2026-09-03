# PDFGeneratorAPI.Client.Model.DocumentSignature

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | Name of the signature field in the document. | [optional] 
**SignerName** | **string** | The name the signer signed under. | [optional] 
**Signer** | **string** | Subject of the certificate that sealed it — an organization, not a person. | [optional] 
**Issuer** | **string** | Subject of the certificate authority that issued it. | [optional] 
**SignedAt** | **string** | When a timestamp authority attested the signature (ISO-8601). This is the defensible time; the signer&#39;s own clock proves nothing.  | [optional] 
**ClaimedSignedAt** | **string** | The time the signer&#39;s own software recorded (ISO-8601). | [optional] 
**TimestampAuthority** | **string** | The timestamp authority that attested the signature. | [optional] 
**Intact** | **bool** | The bytes this signature covers are unchanged. | [optional] 
**Valid** | **bool** | The signature block itself adds up. On its own this does NOT mean the document is unchanged: a tampered file reports &#x60;valid&#x60; true with &#x60;intact&#x60; false, so a verdict needs intact AND valid AND trusted.  | [optional] 
**Trusted** | **bool** | The certificate chains to a trusted root. | [optional] 
**Coverage** | **string** | How much of the file this signature protects. | [optional] 
**AdesIndication** | **string** | The ETSI EN 319 102-1 indication, when the AdES engine could run. | [optional] 
**AdesSubIndication** | **string** | The AdES sub-indication, naming why an indication is not PASSED. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

