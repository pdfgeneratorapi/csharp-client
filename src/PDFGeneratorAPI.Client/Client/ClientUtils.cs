/*
 * PDF Generator API
 *
 * # Introduction [PDF Generator API](https://pdfgeneratorapi.com) allows you easily generate transactional PDF documents and reduce the development and support costs by enabling your users to create and manage their document templates using a browser-based drag-and-drop document editor.  The PDF Generator API features a web API architecture, allowing you to code in the language of your choice. This API supports the JSON media type, and uses UTF-8 character encoding.  ## Base URL The base URL for all the API endpoints is `https://us1.pdfgeneratorapi.com/api/v4`  For example * `https://us1.pdfgeneratorapi.com/api/v4/templates` * `https://us1.pdfgeneratorapi.com/api/v4/workspaces` * `https://us1.pdfgeneratorapi.com/api/v4/templates/123123`  ## Editor PDF Generator API comes with a powerful drag & drop editor that allows to create any kind of document templates, from barcode labels to invoices, quotes and reports. You can find tutorials and videos from our [Support Portal](https://support.pdfgeneratorapi.com). * [Component specification](https://support.pdfgeneratorapi.com/en/category/components-1ffseaj/) * [Expression Language documentation](https://support.pdfgeneratorapi.com/en/category/expression-language-q203pa/) * [Frequently asked questions and answers](https://support.pdfgeneratorapi.com/en/category/qanda-1ov519d/)  ## Definitions  ### Organization Organization is a group of workspaces owned by your account.  ### Workspace Workspace contains templates. Each workspace has access to their own templates and organization default templates.  ### Master Workspace Master Workspace is the main/default workspace of your Organization. The Master Workspace identifier is the email you signed up with.  ### Default Template Default template is a template that is available for all workspaces by default. You can set the template access type under Page Setup. If template has \"Organization\" access then your users can use them from the \"New\" menu in the Editor.  ### Data Field Data Field is a placeholder for the specific data in your JSON data set. In this example JSON you can access the buyer name using Data Field `{paymentDetails::buyerName}`. The separator between depth levels is :: (two colons). When designing the template you don’t have to know every Data Field, our editor automatically extracts all the available fields from your data set and provides an easy way to insert them into the template. ``` {     \"documentNumber\": 1,     \"paymentDetails\": {         \"method\": \"Credit Card\",         \"buyerName\": \"John Smith\"     },     \"items\": [         {             \"id\": 1,             \"name\": \"Item one\"         }     ] } ```  ## Rate limiting Our API endpoints use IP-based rate limiting and allow you to make up to 2 requests per second and 60 requests per minute. If you make more requests, you will receive a response with HTTP code 429.  Response headers contain additional values:  | Header   | Description                    | |- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | X-RateLimit-Limit    | Maximum requests per minute                   | | X-RateLimit-Remaining    | The requests remaining in the current minute               | | Retry-After     | How many seconds you need to wait until you are allowed to make requests |  *  *  *  *  *  # Libraries and SDKs ## Postman Collection We have created a [Postman Collection](https://www.postman.com/pdfgeneratorapi/workspace/pdf-generator-api-public-workspace/overview) so you can easily test all the API endpoints without developing and code.   ## Client Libraries All our Client Libraries are auto-generated using [OpenAPI Generator](https://openapi-generator.tech/) which uses the OpenAPI v3 specification to automatically generate a client library in specific programming language.  * [PHP Client](https://github.com/pdfgeneratorapi/php-client) * [Java Client](https://github.com/pdfgeneratorapi/java-client) * [Ruby Client](https://github.com/pdfgeneratorapi/ruby-client) * [Python Client](https://github.com/pdfgeneratorapi/python-client) * [Javascript Client](https://github.com/pdfgeneratorapi/javascript-client)  We have validated the generated libraries, but let us know if you find any anomalies in the client code.  ## Model Context Protocol (MCP) Server Integrate document generation directly into your AI agents and LLM applications using our official Model Context Protocol (MCP) Server.  The MCP server provides a standardized interface that allows AI assistants (like Claude Desktop and other MCP-compatible clients) to securely interact with the PDF Generator API. With it, your AI applications can automatically fetch workspaces, retrieve templates, merge data, and generate PDF documents on the fly.  [Get PDF Generator API MCP Server](https://github.com/pdfgeneratorapi/mcp-server) *  *  *  *  *   # Authentication The PDF Generator API uses __JSON Web Tokens (JWT)__ to authenticate all API requests. These tokens offer a method to establish secure server-to-server authentication by transferring a compact JSON object with a signed payload of your account’s API Key and Secret. When authenticating to the PDF Generator API, a JWT should be generated uniquely by a __server-side application__ and included as a __Bearer Token__ in the header of each request.   <SecurityDefinitions />  ## Accessing your API Key and Secret You can find your __API Key__ and __API Secret__ from the __Account Settings__ page after you login to PDF Generator API [here](https://pdfgeneratorapi.com/login).  ## Creating a JWT JSON Web Tokens are composed of three sections: a header, a payload (containing a claim set), and a signature. The header and payload are JSON objects, which are serialized to UTF-8 bytes, then encoded using base64url encoding.  The JWT's header, payload, and signature are concatenated with periods (.). As a result, a JWT typically takes the following form: ``` {Base64url encoded header}.{Base64url encoded payload}.{Base64url encoded signature} ```  We recommend and support libraries provided on [jwt.io](https://jwt.io/). While other libraries can create JWT, these recommended libraries are the most robust.  ### Header Property `alg` defines which signing algorithm is being used. PDF Generator API users HS256. Property `typ` defines the type of token and it is always JWT. ``` {   \"alg\": \"HS256\",   \"typ\": \"JWT\" } ```  ### Payload The second part of the token is the payload, which contains the claims  or the pieces of information being passed about the user and any metadata required. It is mandatory to specify the following claims: * issuer (`iss`): Your API key * subject (`sub`): Workspace identifier * expiration time (`exp`): Timestamp (unix epoch time) until the token is valid. It is highly recommended to set the exp timestamp for a short period, i.e. a matter of seconds. This way, if a token is intercepted or shared, the token will only be valid for a short period of time.  ``` {   \"iss\": \"ad54aaff89ffdfeff178bb8a8f359b29fcb20edb56250b9f584aa2cb0162ed4a\",   \"sub\": \"demo.example@actualreports.com\",   \"exp\": 1586112639 } ```  ### Payload for Partners Our partners can send their unique identifier (provided by us) in JWT's partner_id claim. If the `partner_id` value is specified in the JWT, the organization making the request is automatically connected to the partner account. * Partner ID (`partner_id`): Unique identifier provide by PDF Generator API team  ``` {   \"iss\": \"ad54aaff89ffdfeff178bb8a8f359b29fcb20edb56250b9f584aa2cb0162ed4a\",   \"sub\": \"demo.example@actualreports.com\",   \"partner_id\": \"my-partner-identifier\",   \"exp\": 1586112639 } ```  ### Signature To create the signature part you have to take the encoded header, the encoded payload, a secret, the algorithm specified in the header, and sign that. The signature is used to verify the message wasn't changed along the way, and, in the case of tokens signed with a private key, it can also verify that the sender of the JWT is who it says it is. ``` HMACSHA256(     base64UrlEncode(header) + \".\" +     base64UrlEncode(payload),     API_SECRET) ```  ### Putting all together The output is three Base64-URL strings separated by dots. The following shows a JWT that has the previous header and payload encoded, and it is signed with a secret. ``` eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJhZDU0YWFmZjg5ZmZkZmVmZjE3OGJiOGE4ZjM1OWIyOWZjYjIwZWRiNTYyNTBiOWY1ODRhYTJjYjAxNjJlZDRhIiwic3ViIjoiZGVtby5leGFtcGxlQGFjdHVhbHJlcG9ydHMuY29tIn0.SxO-H7UYYYsclS8RGWO1qf0z1cB1m73wF9FLl9RCc1Q  // Base64 encoded header: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9 // Base64 encoded payload: eyJpc3MiOiJhZDU0YWFmZjg5ZmZkZmVmZjE3OGJiOGE4ZjM1OWIyOWZjYjIwZWRiNTYyNTBiOWY1ODRhYTJjYjAxNjJlZDRhIiwic3ViIjoiZGVtby5leGFtcGxlQGFjdHVhbHJlcG9ydHMuY29tIn0 // Signature: SxO-H7UYYYsclS8RGWO1qf0z1cB1m73wF9FLl9RCc1Q ```  ## Temporary JWTs You can create a temporary token in [Account Settings](https://pdfgeneratorapi.com/account/organization) page after you login to PDF Generator API. The generated token uses your email address as the subject (`sub`) value and is valid for __15 minutes__. You can also use [jwt.io](https://jwt.io/) to generate test tokens for your API calls. These test tokens should never be used in production applications. *  *  *  *  *  # Error codes  | Code   | Description                    | |- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | 401    | Unauthorized                   | | 402    | Payment Required               | | 403    | Forbidden                      | | 404    | Not Found                      | | 422    | Unprocessable Entity           | | 429    | Too Many Requests              | | 500    | Internal Server Error          |  ## 401 Unauthorized | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Authentication failed: request expired                                  | | Authentication failed: workspace missing                                | | Authentication failed: key missing                                      | | Authentication failed: property 'iss' (issuer) missing in JWT           | | Authentication failed: property 'sub' (subject) missing in JWT          | | Authentication failed: property 'exp' (expiration time) missing in JWT  | | Authentication failed: incorrect signature                              |  ## 402 Payment Required | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Your account is suspended, please upgrade your account                  |  ## 403 Forbidden | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Your account has exceeded the monthly document generation limit.        | | Access not granted: You cannot delete master workspace via API          | | Access not granted: Template is not accessible by this organization     | | Your session has expired, please close and reopen the editor.           |  ## 404 Entity not found | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Entity not found                                                        | | Resource not found                                                      | | None of the templates is available for the workspace.                   |  ## 422 Unprocessable Entity | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Unable to parse JSON, please check formatting                           | | Required parameter missing                                              | | Required parameter missing: template definition not defined             | | Required parameter missing: template not defined                        |  ## 429 Too Many Requests | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | You can make up to 2 requests per second and 60 requests per minute.   |  *  *  *  *  * 
 *
 * The version of the OpenAPI document: 4.0.26
 * Contact: support@pdfgeneratorapi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using PDFGeneratorAPI.Client.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PDFGeneratorAPI.Client.Test")]

namespace PDFGeneratorAPI.Client.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static partial class ClientUtils
    {

        /// <summary>
        /// A delegate for events.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void EventHandler<T>(object sender, T e) where T : EventArgs;

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(string json, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(json, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(ref Utf8JsonReader reader, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(ref reader, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="format">The DateTime serialization format.</param>
        /// <returns>Formatted string.</returns>
        public static string? ParameterToString(object? obj, string? format = ISO8601_DATETIME_FORMAT)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString(format);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString(format);
            if (obj is DateOnly dateOnly)
                return dateOnly.ToString(format);
            if (obj is bool boolean)
                return boolean
                    ? "true"
                    : "false";
            if (obj is AccessibilityOption accessibilityOption)
                return AccessibilityOptionValueConverter.ToJsonValue(accessibilityOption);
            if (obj is AsyncOutputParam asyncOutputParam)
                return AsyncOutputParamValueConverter.ToJsonValue(asyncOutputParam);
            if (obj is Component.ClsEnum componentClsEnum)
                return Component.ClsEnumToJsonValue(componentClsEnum);
            if (obj is ConvertHTML2PDFRequest.PaperSizeEnum convertHTML2PDFRequestPaperSizeEnum)
                return ConvertHTML2PDFRequest.PaperSizeEnumToJsonValue(convertHTML2PDFRequestPaperSizeEnum);
            if (obj is ConvertHTML2PDFRequest.OrientationEnum convertHTML2PDFRequestOrientationEnum)
                return ConvertHTML2PDFRequest.OrientationEnumToJsonValue(convertHTML2PDFRequestOrientationEnum);
            if (obj is ConvertHTML2PDFRequest.OutputEnum convertHTML2PDFRequestOutputEnum)
                return ConvertHTML2PDFRequest.OutputEnumToJsonValue(convertHTML2PDFRequestOutputEnum);
            if (obj is ConvertPDF2ImageRequest.FormatEnum convertPDF2ImageRequestFormatEnum)
                return ConvertPDF2ImageRequest.FormatEnumToJsonValue(convertPDF2ImageRequestFormatEnum);
            if (obj is ConvertPDF2ImageRequest.OutputEnum convertPDF2ImageRequestOutputEnum)
                return ConvertPDF2ImageRequest.OutputEnumToJsonValue(convertPDF2ImageRequestOutputEnum);
            if (obj is ConvertURL2PDFRequest.PaperSizeEnum convertURL2PDFRequestPaperSizeEnum)
                return ConvertURL2PDFRequest.PaperSizeEnumToJsonValue(convertURL2PDFRequestPaperSizeEnum);
            if (obj is ConvertURL2PDFRequest.OrientationEnum convertURL2PDFRequestOrientationEnum)
                return ConvertURL2PDFRequest.OrientationEnumToJsonValue(convertURL2PDFRequestOrientationEnum);
            if (obj is ConvertURL2PDFRequest.OutputEnum convertURL2PDFRequestOutputEnum)
                return ConvertURL2PDFRequest.OutputEnumToJsonValue(convertURL2PDFRequestOutputEnum);
            if (obj is CreateEInvoiceRequest.TypeEnum createEInvoiceRequestTypeEnum)
                return CreateEInvoiceRequest.TypeEnumToJsonValue(createEInvoiceRequestTypeEnum);
            if (obj is CreateEInvoiceRequest.OutputEnum createEInvoiceRequestOutputEnum)
                return CreateEInvoiceRequest.OutputEnumToJsonValue(createEInvoiceRequestOutputEnum);
            if (obj is CreateFacturXEInvoiceRequest.ProfileEnum createFacturXEInvoiceRequestProfileEnum)
                return CreateFacturXEInvoiceRequest.ProfileEnumToJsonValue(createFacturXEInvoiceRequestProfileEnum);
            if (obj is DocumentAction.ActionEnum documentActionActionEnum)
                return DocumentAction.ActionEnumToJsonValue(documentActionActionEnum);
            if (obj is EncryptAndDecryptBase64.OutputEnum encryptAndDecryptBase64OutputEnum)
                return EncryptAndDecryptBase64.OutputEnumToJsonValue(encryptAndDecryptBase64OutputEnum);
            if (obj is EncryptAndDecryptUrl.OutputEnum encryptAndDecryptUrlOutputEnum)
                return EncryptAndDecryptUrl.OutputEnumToJsonValue(encryptAndDecryptUrlOutputEnum);
            if (obj is FormFieldsInner.TypeEnum formFieldsInnerTypeEnum)
                return FormFieldsInner.TypeEnumToJsonValue(formFieldsInnerTypeEnum);
            if (obj is FormFillBase64.OutputEnum formFillBase64OutputEnum)
                return FormFillBase64.OutputEnumToJsonValue(formFillBase64OutputEnum);
            if (obj is FormFillUrl.OutputEnum formFillUrlOutputEnum)
                return FormFillUrl.OutputEnumToJsonValue(formFillUrlOutputEnum);
            if (obj is FormatParam formatParam)
                return FormatParamValueConverter.ToJsonValue(formatParam);
            if (obj is GenerateQRCodeRequest.OutputEnum generateQRCodeRequestOutputEnum)
                return GenerateQRCodeRequest.OutputEnumToJsonValue(generateQRCodeRequestOutputEnum);
            if (obj is InlineObject13.StatusEnum inlineObject13StatusEnum)
                return InlineObject13.StatusEnumToJsonValue(inlineObject13StatusEnum);
            if (obj is InlineObject14ResponseValue.TypeEnum inlineObject14ResponseValueTypeEnum)
                return InlineObject14ResponseValue.TypeEnumToJsonValue(inlineObject14ResponseValueTypeEnum);
            if (obj is InlineObject23.MessageEnum inlineObject23MessageEnum)
                return InlineObject23.MessageEnumToJsonValue(inlineObject23MessageEnum);
            if (obj is InlineObject24.MessageEnum inlineObject24MessageEnum)
                return InlineObject24.MessageEnumToJsonValue(inlineObject24MessageEnum);
            if (obj is InlineObject25.MessageEnum inlineObject25MessageEnum)
                return InlineObject25.MessageEnumToJsonValue(inlineObject25MessageEnum);
            if (obj is InlineObject26.MessageEnum inlineObject26MessageEnum)
                return InlineObject26.MessageEnumToJsonValue(inlineObject26MessageEnum);
            if (obj is KeyFieldParam keyFieldParam)
                return KeyFieldParamValueConverter.ToJsonValue(keyFieldParam);
            if (obj is MakeAccessibleBase64.OutputEnum makeAccessibleBase64OutputEnum)
                return MakeAccessibleBase64.OutputEnumToJsonValue(makeAccessibleBase64OutputEnum);
            if (obj is MakeAccessibleUrl.OutputEnum makeAccessibleUrlOutputEnum)
                return MakeAccessibleUrl.OutputEnumToJsonValue(makeAccessibleUrlOutputEnum);
            if (obj is OpenEditorRequest.LanguageEnum openEditorRequestLanguageEnum)
                return OpenEditorRequest.LanguageEnumToJsonValue(openEditorRequestLanguageEnum);
            if (obj is OptimizeBase64.OutputEnum optimizeBase64OutputEnum)
                return OptimizeBase64.OutputEnumToJsonValue(optimizeBase64OutputEnum);
            if (obj is OptimizeUrl.OutputEnum optimizeUrlOutputEnum)
                return OptimizeUrl.OutputEnumToJsonValue(optimizeUrlOutputEnum);
            if (obj is OutputParam outputParam)
                return OutputParamValueConverter.ToJsonValue(outputParam);
            if (obj is StatusParam statusParam)
                return StatusParamValueConverter.ToJsonValue(statusParam);
            if (obj is StoreDocumentRequest.OutputEnum storeDocumentRequestOutputEnum)
                return StoreDocumentRequest.OutputEnumToJsonValue(storeDocumentRequestOutputEnum);
            if (obj is TemplateDefinitionNewLayout.FormatEnum templateDefinitionNewLayoutFormatEnum)
                return TemplateDefinitionNewLayout.FormatEnumToJsonValue(templateDefinitionNewLayoutFormatEnum);
            if (obj is TemplateDefinitionNewLayout.UnitEnum templateDefinitionNewLayoutUnitEnum)
                return TemplateDefinitionNewLayout.UnitEnumToJsonValue(templateDefinitionNewLayoutUnitEnum);
            if (obj is TemplateDefinitionNewLayout.OrientationEnum templateDefinitionNewLayoutOrientationEnum)
                return TemplateDefinitionNewLayout.OrientationEnumToJsonValue(templateDefinitionNewLayoutOrientationEnum);
            if (obj is TemplateDefinitionNewLayout.RotationEnum templateDefinitionNewLayoutRotationEnum)
                return TemplateDefinitionNewLayout.RotationEnumToJsonValue(templateDefinitionNewLayoutRotationEnum).ToString();
            if (obj is TemplateDefinitionNewLayoutRepeatLayout.FormatEnum templateDefinitionNewLayoutRepeatLayoutFormatEnum)
                return TemplateDefinitionNewLayoutRepeatLayout.FormatEnumToJsonValue(templateDefinitionNewLayoutRepeatLayoutFormatEnum);
            if (obj is WatermarkBase64.OutputEnum watermarkBase64OutputEnum)
                return WatermarkBase64.OutputEnumToJsonValue(watermarkBase64OutputEnum);
            if (obj is WatermarkFileUrl.OutputEnum watermarkFileUrlOutputEnum)
                return WatermarkFileUrl.OutputEnumToJsonValue(watermarkFileUrlOutputEnum);
            if (obj is WatermarkPosition watermarkPosition)
                return WatermarkPositionValueConverter.ToJsonValue(watermarkPosition);
            if (obj is ICollection collection)
            {
                List<string?> entries = new();
                foreach (var entry in collection)
                    entries.Add(ParameterToString(entry));
                return string.Join(",", entries);
            }

            return Convert.ToString(obj, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">string to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string? SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string? SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        [GeneratedRegex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$")]
        private static partial Regex JsonRegex();

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex().IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// Get the discriminator
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="discriminator"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public static string? GetDiscriminator(Utf8JsonReader utf8JsonReader, string discriminator)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    if (localVarJsonPropertyName != null && localVarJsonPropertyName.Equals(discriminator))
                        return utf8JsonReader.GetString();
                }
            }

            throw new JsonException("The specified discriminator was not found.");
        }

        /// <summary>
        /// The base path of the API
        /// </summary>
        public const string BASE_ADDRESS = "https://us1.pdfgeneratorapi.com/api/v4";

        /// <summary>
        /// The scheme of the API
        /// </summary>
        public const string SCHEME = "https";

        /// <summary>
        /// The context path of the API
        /// </summary>
        public const string CONTEXT_PATH = "/api/v4";

        /// <summary>
        /// The host of the API
        /// </summary>
        public const string HOST = "us1.pdfgeneratorapi.com";

        /// <summary>
        /// The format to use for DateTime serialization
        /// </summary>
        public const string ISO8601_DATETIME_FORMAT = "o";
    }
}
