# PDFGeneratorAPI.Client.Api.WorkspacesApi

All URIs are relative to *https://us1.pdfgeneratorapi.com/api/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWorkspace**](WorkspacesApi.md#createworkspace) | **POST** /workspaces | Create workspace |
| [**DeleteWorkspace**](WorkspacesApi.md#deleteworkspace) | **DELETE** /workspaces/{workspaceIdentifier} | Delete workspace |
| [**GetWorkspace**](WorkspacesApi.md#getworkspace) | **GET** /workspaces/{workspaceIdentifier} | Get workspace |
| [**GetWorkspaces**](WorkspacesApi.md#getworkspaces) | **GET** /workspaces | Get workspaces |

<a id="createworkspace"></a>
# **CreateWorkspace**
> InlineObject8 CreateWorkspace (CreateWorkspaceRequest createWorkspaceRequest = null)

Create workspace

Creates a regular workspace with identifier specified in the request.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWorkspaceRequest** | [**CreateWorkspaceRequest**](CreateWorkspaceRequest.md) |  | [optional]  |

### Return type

[**InlineObject8**](InlineObject8.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Workspace information |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteworkspace"></a>
# **DeleteWorkspace**
> void DeleteWorkspace (string workspaceIdentifier)

Delete workspace

Delete workspace. Only regular workspaces can be deleted.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceIdentifier** | **string** | Workspace identifier |  |

### Return type

void (empty response body)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was deleted successfully. |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getworkspace"></a>
# **GetWorkspace**
> InlineObject8 GetWorkspace (string workspaceIdentifier)

Get workspace

Returns workspace information for the workspace identifier specified in the request.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceIdentifier** | **string** | Workspace identifier |  |

### Return type

[**InlineObject8**](InlineObject8.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Workspace information |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getworkspaces"></a>
# **GetWorkspaces**
> InlineObject5 GetWorkspaces (int page = null, int perPage = null)

Get workspaces

Returns all workspaces in the organization


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Pagination: page to return | [optional] [default to 1] |
| **perPage** | **int** | Pagination: How many records to return per page | [optional] [default to 15] |

### Return type

[**InlineObject5**](InlineObject5.md)

### Authorization

[JSONWebTokenAuth](../README.md#JSONWebTokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of workspace objects |  -  |
| **401** | Unauthorized |  -  |
| **402** | Account Suspended |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

