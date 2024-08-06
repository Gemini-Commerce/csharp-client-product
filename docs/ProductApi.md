# product.Api.ProductApi

All URIs are relative to *https://product.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMediaGalleryEntry**](ProductApi.md#addmediagalleryentry) | **POST** /product.Product/AddMediaGalleryEntry | Add Media Gallery Entry |
| [**BulkAddAssetsEntries**](ProductApi.md#bulkaddassetsentries) | **POST** /product.Product/BulkAddAssetsEntries | Bulk Add Assets Entries |
| [**BulkDeleteProducts**](ProductApi.md#bulkdeleteproducts) | **POST** /product.Product/BulkDeleteProducts | Bulk Delete Products |
| [**BulkEnhanceProductDataWithAI**](ProductApi.md#bulkenhanceproductdatawithai) | **POST** /product.Product/BulkEnhanceProductDataWithAI | Bulk Enhance Product Data With AI |
| [**BulkRemoveAssetsEntries**](ProductApi.md#bulkremoveassetsentries) | **POST** /product.Product/BulkRemoveAssetsEntries | Bulk Remove Assets Entries |
| [**BulkUpdateAssetsEntries**](ProductApi.md#bulkupdateassetsentries) | **POST** /product.Product/BulkUpdateAssetsEntries | Bulk Update Assets Entries |
| [**BulkUpdateV2**](ProductApi.md#bulkupdatev2) | **POST** /product.Product/BulkUpdateV2 | Bulk Update Products |
| [**CreateAttributeOptions**](ProductApi.md#createattributeoptions) | **POST** /product.Product/CreateAttributeOptions | Create Attribute Options |
| [**CreateEntity**](ProductApi.md#createentity) | **POST** /product.Product/CreateEntity | Create Entity |
| [**CreateOptionsList**](ProductApi.md#createoptionslist) | **POST** /product.Product/CreateOptionsList | Create Options List |
| [**CreateProductWithAI**](ProductApi.md#createproductwithai) | **POST** /product.Product/CreateProductWithAI | Create Product With AI |
| [**GetAttributeOption**](ProductApi.md#getattributeoption) | **POST** /product.Product/GetAttributeOption | Get Attribute Option |
| [**GetAttributeOptions**](ProductApi.md#getattributeoptions) | **POST** /product.Product/GetAttributeOptions | Get Attribute Options |
| [**GetEntity**](ProductApi.md#getentity) | **POST** /product.Product/GetEntity | Get Entity Details |
| [**GetOptionsList**](ProductApi.md#getoptionslist) | **POST** /product.Product/GetOptionsList | Get Options List |
| [**GetProduct**](ProductApi.md#getproduct) | **POST** /product.Product/GetProduct | Get Product |
| [**GetProductByCode**](ProductApi.md#getproductbycode) | **POST** /product.Product/GetProductByCode | Get Product By Code |
| [**GetProductByUrlKey**](ProductApi.md#getproductbyurlkey) | **POST** /product.Product/GetProductByUrlKey | Get Product By Url Key |
| [**GetProductDataInReview**](ProductApi.md#getproductdatainreview) | **POST** /product.Product/GetProductDataInReview | Get Product Data In Review |
| [**ListAttributeOptions**](ProductApi.md#listattributeoptions) | **POST** /product.Product/ListAttributeOptions | List Attribute Options |
| [**ListEntities**](ProductApi.md#listentities) | **POST** /product.Product/ListEntities | List Entities |
| [**ListOptionsLists**](ProductApi.md#listoptionslists) | **POST** /product.Product/ListOptionsLists | List Options Lists |
| [**ListProducts**](ProductApi.md#listproducts) | **POST** /product.Product/ListProducts | List Products |
| [**ListProductsByIds**](ProductApi.md#listproductsbyids) | **POST** /product.Product/ListProductsByIds | List Products By Ids |
| [**ListProductsBySku**](ProductApi.md#listproductsbysku) | **POST** /product.Product/ListProductsBySku | List Products By Sku |
| [**ListVariantsBySku**](ProductApi.md#listvariantsbysku) | **POST** /product.Product/ListVariantsBySku | List Product Variants By Sku |
| [**ProductBulkCreateAttribute**](ProductApi.md#productbulkcreateattribute) | **POST** /product.Product/BulkCreateAttribute |  |
| [**ProductBulkUpdate**](ProductApi.md#productbulkupdate) | **POST** /product.Product/BulkUpdate |  |
| [**ProductCreateAttributeGroup**](ProductApi.md#productcreateattributegroup) | **POST** /product.Product/CreateAttributeGroup |  |
| [**ProductCreateProduct**](ProductApi.md#productcreateproduct) | **POST** /product.Product/CreateProduct |  |
| [**ProductCreateProductV2**](ProductApi.md#productcreateproductv2) | **POST** /product.Product/CreateProductV2 |  |
| [**ProductDelete**](ProductApi.md#productdelete) | **POST** /product.Product/Delete |  |
| [**ProductDeleteAttribute**](ProductApi.md#productdeleteattribute) | **POST** /product.Product/DeleteAttribute |  |
| [**ProductDeleteProduct**](ProductApi.md#productdeleteproduct) | **POST** /product.Product/DeleteProduct |  |
| [**ProductGetAttributeGroup**](ProductApi.md#productgetattributegroup) | **POST** /product.Product/GetAttributeGroup |  |
| [**ProductListAttributeGroups**](ProductApi.md#productlistattributegroups) | **POST** /product.Product/ListAttributeGroups |  |
| [**ProductUpdateAttribute**](ProductApi.md#productupdateattribute) | **POST** /product.Product/UpdateAttribute |  |
| [**ProductUpdateAttributeGroup**](ProductApi.md#productupdateattributegroup) | **POST** /product.Product/UpdateAttributeGroup |  |
| [**ProductUpdateProduct**](ProductApi.md#productupdateproduct) | **POST** /product.Product/UpdateProduct |  |
| [**ProductUpdateProductV2**](ProductApi.md#productupdateproductv2) | **POST** /product.Product/UpdateProductV2 |  |
| [**RemoveMediaGalleryEntry**](ProductApi.md#removemediagalleryentry) | **POST** /product.Product/RemoveMediaGalleryEntry | Remove Media Gallery Entry |
| [**UpdateAttributeOptions**](ProductApi.md#updateattributeoptions) | **POST** /product.Product/UpdateAttributeOptions | Update Attribute Options |
| [**UpdateDataToBeReviewed**](ProductApi.md#updatedatatobereviewed) | **POST** /product.Product/GetEnhanceProductDataWithAIStatus | Get Enhance Product Data With AI Status |
| [**UpdateDataToBeReviewed_0**](ProductApi.md#updatedatatobereviewed_0) | **POST** /product.Product/UpdateDataToBeReviewed | Update Data To Be Reviewed |
| [**UpdateMediaGalleryEntry**](ProductApi.md#updatemediagalleryentry) | **POST** /product.Product/UpdateMediaGalleryEntry | Update Media Gallery Entry |
| [**UpdateOptionsList**](ProductApi.md#updateoptionslist) | **POST** /product.Product/UpdateOptionsList | Update Options List |
| [**UpdateProductWithAI**](ProductApi.md#updateproductwithai) | **POST** /product.Product/UpdateProductWithAI | Update Product With AI |

<a id="addmediagalleryentry"></a>
# **AddMediaGalleryEntry**
> ProductAddMediaGalleryEntryResponse AddMediaGalleryEntry (ProductAddMediaGalleryEntryRequest body)

Add Media Gallery Entry

The AddMediaGalleryEntry endpoint allows users to add a new media entry to the gallery of a specific product. To make a request to this endpoint, users need to provide the necessary information in the specified format. The request includes the tenant_id to specify the relevant tenant, the product_id to identify the target product, and the asset_grn which represents the globally unique identifier for the media asset being added. Additionally, the position field indicates the desired position of the media entry within the gallery, allowing users to control the order in which the media items are displayed. The metadata field, which is a repeated field, provides the option to include additional metadata associated with the media entry. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class AddMediaGalleryEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductAddMediaGalleryEntryRequest(); // ProductAddMediaGalleryEntryRequest | 

            try
            {
                // Add Media Gallery Entry
                ProductAddMediaGalleryEntryResponse result = apiInstance.AddMediaGalleryEntry(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.AddMediaGalleryEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMediaGalleryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Media Gallery Entry
    ApiResponse<ProductAddMediaGalleryEntryResponse> response = apiInstance.AddMediaGalleryEntryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.AddMediaGalleryEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductAddMediaGalleryEntryRequest**](ProductAddMediaGalleryEntryRequest.md) |  |  |

### Return type

[**ProductAddMediaGalleryEntryResponse**](ProductAddMediaGalleryEntryResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkaddassetsentries"></a>
# **BulkAddAssetsEntries**
> ProductBulkAddAssetsEntriesResponse BulkAddAssetsEntries (ProductBulkAddAssetsEntriesRequest body)

Bulk Add Assets Entries

The BulkAddAssetsEntries endpoint allows users to add assets. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class BulkAddAssetsEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkAddAssetsEntriesRequest(); // ProductBulkAddAssetsEntriesRequest | 

            try
            {
                // Bulk Add Assets Entries
                ProductBulkAddAssetsEntriesResponse result = apiInstance.BulkAddAssetsEntries(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BulkAddAssetsEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkAddAssetsEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Add Assets Entries
    ApiResponse<ProductBulkAddAssetsEntriesResponse> response = apiInstance.BulkAddAssetsEntriesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BulkAddAssetsEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkAddAssetsEntriesRequest**](ProductBulkAddAssetsEntriesRequest.md) |  |  |

### Return type

[**ProductBulkAddAssetsEntriesResponse**](ProductBulkAddAssetsEntriesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkdeleteproducts"></a>
# **BulkDeleteProducts**
> Object BulkDeleteProducts (ProductBulkDeleteProductsRequest body)

Bulk Delete Products

This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class BulkDeleteProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkDeleteProductsRequest(); // ProductBulkDeleteProductsRequest | 

            try
            {
                // Bulk Delete Products
                Object result = apiInstance.BulkDeleteProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BulkDeleteProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkDeleteProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Delete Products
    ApiResponse<Object> response = apiInstance.BulkDeleteProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BulkDeleteProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkDeleteProductsRequest**](ProductBulkDeleteProductsRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkenhanceproductdatawithai"></a>
# **BulkEnhanceProductDataWithAI**
> Object BulkEnhanceProductDataWithAI (ProductBulkEnhanceProductDataWithAIRequest body)

Bulk Enhance Product Data With AI

The BulkEnhanceProductDataWithAI endpoint allows users to enhance product data using artificial intelligence (AI) capabilities. By making a request to this endpoint and providing the necessary input data, users can leverage AI algorithms to enrich and optimize product information. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class BulkEnhanceProductDataWithAIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkEnhanceProductDataWithAIRequest(); // ProductBulkEnhanceProductDataWithAIRequest | 

            try
            {
                // Bulk Enhance Product Data With AI
                Object result = apiInstance.BulkEnhanceProductDataWithAI(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BulkEnhanceProductDataWithAI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkEnhanceProductDataWithAIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Enhance Product Data With AI
    ApiResponse<Object> response = apiInstance.BulkEnhanceProductDataWithAIWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BulkEnhanceProductDataWithAIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkEnhanceProductDataWithAIRequest**](ProductBulkEnhanceProductDataWithAIRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkremoveassetsentries"></a>
# **BulkRemoveAssetsEntries**
> Object BulkRemoveAssetsEntries (ProductBulkRemoveAssetsEntriesRequest body)

Bulk Remove Assets Entries

The BulkRemoveAssetsEntries endpoint allows users to remove assets. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class BulkRemoveAssetsEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkRemoveAssetsEntriesRequest(); // ProductBulkRemoveAssetsEntriesRequest | 

            try
            {
                // Bulk Remove Assets Entries
                Object result = apiInstance.BulkRemoveAssetsEntries(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BulkRemoveAssetsEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkRemoveAssetsEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Remove Assets Entries
    ApiResponse<Object> response = apiInstance.BulkRemoveAssetsEntriesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BulkRemoveAssetsEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkRemoveAssetsEntriesRequest**](ProductBulkRemoveAssetsEntriesRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkupdateassetsentries"></a>
# **BulkUpdateAssetsEntries**
> ProductBulkUpdateAssetsEntriesResponse BulkUpdateAssetsEntries (ProductBulkUpdateAssetsEntriesRequest body)

Bulk Update Assets Entries

The BulkUpdateAssetsEntries endpoint allows users to update assets. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class BulkUpdateAssetsEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkUpdateAssetsEntriesRequest(); // ProductBulkUpdateAssetsEntriesRequest | 

            try
            {
                // Bulk Update Assets Entries
                ProductBulkUpdateAssetsEntriesResponse result = apiInstance.BulkUpdateAssetsEntries(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BulkUpdateAssetsEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkUpdateAssetsEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Update Assets Entries
    ApiResponse<ProductBulkUpdateAssetsEntriesResponse> response = apiInstance.BulkUpdateAssetsEntriesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BulkUpdateAssetsEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkUpdateAssetsEntriesRequest**](ProductBulkUpdateAssetsEntriesRequest.md) |  |  |

### Return type

[**ProductBulkUpdateAssetsEntriesResponse**](ProductBulkUpdateAssetsEntriesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkupdatev2"></a>
# **BulkUpdateV2**
> ProductBulkUpdateResponse BulkUpdateV2 (ProductBulkUpdateRequestV2 body)

Bulk Update Products

Version 2 of bulk updates for product attributes with enhanced payload structure and response format. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class BulkUpdateV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkUpdateRequestV2(); // ProductBulkUpdateRequestV2 | 

            try
            {
                // Bulk Update Products
                ProductBulkUpdateResponse result = apiInstance.BulkUpdateV2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BulkUpdateV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkUpdateV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Update Products
    ApiResponse<ProductBulkUpdateResponse> response = apiInstance.BulkUpdateV2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BulkUpdateV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkUpdateRequestV2**](ProductBulkUpdateRequestV2.md) |  |  |

### Return type

[**ProductBulkUpdateResponse**](ProductBulkUpdateResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createattributeoptions"></a>
# **CreateAttributeOptions**
> EntitymanagerCreateAttributeOptionsResponse CreateAttributeOptions (EntitymanagerCreateAttributeOptionsRequest body)

Create Attribute Options

Create attribute options with specified codes, values, and swatches. Returns created options and any associated errors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class CreateAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerCreateAttributeOptionsRequest(); // EntitymanagerCreateAttributeOptionsRequest | 

            try
            {
                // Create Attribute Options
                EntitymanagerCreateAttributeOptionsResponse result = apiInstance.CreateAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.CreateAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Attribute Options
    ApiResponse<EntitymanagerCreateAttributeOptionsResponse> response = apiInstance.CreateAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.CreateAttributeOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerCreateAttributeOptionsRequest**](EntitymanagerCreateAttributeOptionsRequest.md) |  |  |

### Return type

[**EntitymanagerCreateAttributeOptionsResponse**](EntitymanagerCreateAttributeOptionsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createentity"></a>
# **CreateEntity**
> EntitymanagerCreateEntityResponse CreateEntity (EntitymanagerEntity body)

Create Entity

The CreateEntity endpoint allows users to define and create a new entity with custom attributes, providing a flexible way to represent and manage different data structures within the system. By making a request to this endpoint, users can create a new entity that serves as an abstraction of a product or any other domain-specific object. This endpoint empowers users to define the specific attributes that compose the entity, such as color, composition, technical details, or any other relevant properties. Utilize the CreateEntity endpoint to dynamically extend and adapt your system's data model to accommodate diverse business requirements and efficiently manage various types of entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class CreateEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerEntity(); // EntitymanagerEntity | 

            try
            {
                // Create Entity
                EntitymanagerCreateEntityResponse result = apiInstance.CreateEntity(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.CreateEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Entity
    ApiResponse<EntitymanagerCreateEntityResponse> response = apiInstance.CreateEntityWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.CreateEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerEntity**](EntitymanagerEntity.md) |  |  |

### Return type

[**EntitymanagerCreateEntityResponse**](EntitymanagerCreateEntityResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createoptionslist"></a>
# **CreateOptionsList**
> EntitymanagerCreateOptionsListResponse CreateOptionsList (EntitymanagerCreateOptionsListRequest body)

Create Options List

The CreateOptionsList endpoint allows users to create an OptionList, which represents a list of predefined options for assigning to an attribute. By making a request to this endpoint with the provided request format, users can create a new OptionList by specifying the relevant tenant ID and providing the OptionList object containing the predefined options. This functionality facilitates efficient management and assignment of predefined attribute values, ensuring consistency and flexibility within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class CreateOptionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerCreateOptionsListRequest(); // EntitymanagerCreateOptionsListRequest | 

            try
            {
                // Create Options List
                EntitymanagerCreateOptionsListResponse result = apiInstance.CreateOptionsList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.CreateOptionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOptionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Options List
    ApiResponse<EntitymanagerCreateOptionsListResponse> response = apiInstance.CreateOptionsListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.CreateOptionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerCreateOptionsListRequest**](EntitymanagerCreateOptionsListRequest.md) |  |  |

### Return type

[**EntitymanagerCreateOptionsListResponse**](EntitymanagerCreateOptionsListResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createproductwithai"></a>
# **CreateProductWithAI**
> ProductCreateProductWithAIResponse CreateProductWithAI (ProductCreateProductWithAIRequest body)

Create Product With AI

The CreateProductWithAI endpoint allows users to create a new product within the system using artificial intelligence (AI) capabilities. By sending a request to this endpoint and providing the necessary input data, users can leverage AI algorithms to enhance and optimize the product creation process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class CreateProductWithAIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductCreateProductWithAIRequest(); // ProductCreateProductWithAIRequest | 

            try
            {
                // Create Product With AI
                ProductCreateProductWithAIResponse result = apiInstance.CreateProductWithAI(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProductWithAI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductWithAIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Product With AI
    ApiResponse<ProductCreateProductWithAIResponse> response = apiInstance.CreateProductWithAIWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.CreateProductWithAIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductCreateProductWithAIRequest**](ProductCreateProductWithAIRequest.md) |  |  |

### Return type

[**ProductCreateProductWithAIResponse**](ProductCreateProductWithAIResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattributeoption"></a>
# **GetAttributeOption**
> EntitymanagerGetAttributeOptionResponse GetAttributeOption (EntitymanagerGetAttributeOptionRequest body)

Get Attribute Option

Retrieve attribute option details by providing the tenant ID, list code, and option ID. Returns the specified attribute option.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetAttributeOptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetAttributeOptionRequest(); // EntitymanagerGetAttributeOptionRequest | 

            try
            {
                // Get Attribute Option
                EntitymanagerGetAttributeOptionResponse result = apiInstance.GetAttributeOption(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetAttributeOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributeOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Attribute Option
    ApiResponse<EntitymanagerGetAttributeOptionResponse> response = apiInstance.GetAttributeOptionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetAttributeOptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerGetAttributeOptionRequest**](EntitymanagerGetAttributeOptionRequest.md) |  |  |

### Return type

[**EntitymanagerGetAttributeOptionResponse**](EntitymanagerGetAttributeOptionResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattributeoptions"></a>
# **GetAttributeOptions**
> EntitymanagerGetAttributeOptionsResponse GetAttributeOptions (EntitymanagerGetAttributeOptionsRequest body)

Get Attribute Options

Retrieve a list of attribute options based on the provided tenant ID and list code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetAttributeOptionsRequest(); // EntitymanagerGetAttributeOptionsRequest | 

            try
            {
                // Get Attribute Options
                EntitymanagerGetAttributeOptionsResponse result = apiInstance.GetAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Attribute Options
    ApiResponse<EntitymanagerGetAttributeOptionsResponse> response = apiInstance.GetAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetAttributeOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerGetAttributeOptionsRequest**](EntitymanagerGetAttributeOptionsRequest.md) |  |  |

### Return type

[**EntitymanagerGetAttributeOptionsResponse**](EntitymanagerGetAttributeOptionsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getentity"></a>
# **GetEntity**
> EntitymanagerEntity GetEntity (EntitymanagerEntityRequest body)

Get Entity Details

Retrieve details of an entity by providing the tenant ID and either entity data or entity ID. Returns information including ID, type, code, label, relationships, and attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerEntityRequest(); // EntitymanagerEntityRequest | 

            try
            {
                // Get Entity Details
                EntitymanagerEntity result = apiInstance.GetEntity(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Entity Details
    ApiResponse<EntitymanagerEntity> response = apiInstance.GetEntityWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerEntityRequest**](EntitymanagerEntityRequest.md) |  |  |

### Return type

[**EntitymanagerEntity**](EntitymanagerEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoptionslist"></a>
# **GetOptionsList**
> EntitymanagerGetOptionsListResponse GetOptionsList (EntitymanagerGetOptionsListRequest body)

Get Options List

Retrieve option lists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetOptionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetOptionsListRequest(); // EntitymanagerGetOptionsListRequest | 

            try
            {
                // Get Options List
                EntitymanagerGetOptionsListResponse result = apiInstance.GetOptionsList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetOptionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOptionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Options List
    ApiResponse<EntitymanagerGetOptionsListResponse> response = apiInstance.GetOptionsListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetOptionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerGetOptionsListRequest**](EntitymanagerGetOptionsListRequest.md) |  |  |

### Return type

[**EntitymanagerGetOptionsListResponse**](EntitymanagerGetOptionsListResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproduct"></a>
# **GetProduct**
> ProductGetProductResponse GetProduct (ProductGetProductRequest body)

Get Product

The GetProduct endpoint enables users to retrieve a product from the system. By sending a request to this endpoint, users can retrieve a product by providing its unique identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductRequest(); // ProductGetProductRequest | 

            try
            {
                // Get Product
                ProductGetProductResponse result = apiInstance.GetProduct(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product
    ApiResponse<ProductGetProductResponse> response = apiInstance.GetProductWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductGetProductRequest**](ProductGetProductRequest.md) |  |  |

### Return type

[**ProductGetProductResponse**](ProductGetProductResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductbycode"></a>
# **GetProductByCode**
> ProductGetProductByCodeResponse GetProductByCode (ProductGetProductByCodeRequest body)

Get Product By Code

The GetProductByCode endpoint enables users to retrieve a product from the system. By sending a request to this endpoint, users can retrieve a product by providing its unique code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetProductByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductByCodeRequest(); // ProductGetProductByCodeRequest | 

            try
            {
                // Get Product By Code
                ProductGetProductByCodeResponse result = apiInstance.GetProductByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product By Code
    ApiResponse<ProductGetProductByCodeResponse> response = apiInstance.GetProductByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetProductByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductGetProductByCodeRequest**](ProductGetProductByCodeRequest.md) |  |  |

### Return type

[**ProductGetProductByCodeResponse**](ProductGetProductByCodeResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductbyurlkey"></a>
# **GetProductByUrlKey**
> ProductGetProductByUrlKeyResponse GetProductByUrlKey (ProductGetProductByUrlKeyRequest body)

Get Product By Url Key

The GetProductByUrlKey endpoint enables users to retrieve a product from the system. By sending a request to this endpoint, users can retrieve a product by providing its unique url key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetProductByUrlKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductByUrlKeyRequest(); // ProductGetProductByUrlKeyRequest | 

            try
            {
                // Get Product By Url Key
                ProductGetProductByUrlKeyResponse result = apiInstance.GetProductByUrlKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductByUrlKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductByUrlKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product By Url Key
    ApiResponse<ProductGetProductByUrlKeyResponse> response = apiInstance.GetProductByUrlKeyWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetProductByUrlKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductGetProductByUrlKeyRequest**](ProductGetProductByUrlKeyRequest.md) |  |  |

### Return type

[**ProductGetProductByUrlKeyResponse**](ProductGetProductByUrlKeyResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductdatainreview"></a>
# **GetProductDataInReview**
> ProductGetProductDataInReviewResponse GetProductDataInReview (ProductGetProductDataInReviewRequest body)

Get Product Data In Review

The GetProductDataInReview endpoint allows users to retrieve product data that is currently under review. By making a request to this endpoint, users can access detailed information about the product data that is pending approval or review by authorized personnel. This functionality provides transparency and visibility into the product data review process, enabling users to track the status and progress of product data submissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class GetProductDataInReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductDataInReviewRequest(); // ProductGetProductDataInReviewRequest | 

            try
            {
                // Get Product Data In Review
                ProductGetProductDataInReviewResponse result = apiInstance.GetProductDataInReview(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductDataInReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductDataInReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product Data In Review
    ApiResponse<ProductGetProductDataInReviewResponse> response = apiInstance.GetProductDataInReviewWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetProductDataInReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductGetProductDataInReviewRequest**](ProductGetProductDataInReviewRequest.md) |  |  |

### Return type

[**ProductGetProductDataInReviewResponse**](ProductGetProductDataInReviewResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listattributeoptions"></a>
# **ListAttributeOptions**
> EntitymanagerListAttributeOptionsResponse ListAttributeOptions (EntitymanagerListAttributeOptionsRequest body)

List Attribute Options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListAttributeOptionsRequest(); // EntitymanagerListAttributeOptionsRequest | 

            try
            {
                // List Attribute Options
                EntitymanagerListAttributeOptionsResponse result = apiInstance.ListAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Attribute Options
    ApiResponse<EntitymanagerListAttributeOptionsResponse> response = apiInstance.ListAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListAttributeOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerListAttributeOptionsRequest**](EntitymanagerListAttributeOptionsRequest.md) |  |  |

### Return type

[**EntitymanagerListAttributeOptionsResponse**](EntitymanagerListAttributeOptionsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listentities"></a>
# **ListEntities**
> EntitymanagerListEntitiesResponse ListEntities (EntitymanagerListEntitiesRequest body)

List Entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListEntitiesRequest(); // EntitymanagerListEntitiesRequest | 

            try
            {
                // List Entities
                EntitymanagerListEntitiesResponse result = apiInstance.ListEntities(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Entities
    ApiResponse<EntitymanagerListEntitiesResponse> response = apiInstance.ListEntitiesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerListEntitiesRequest**](EntitymanagerListEntitiesRequest.md) |  |  |

### Return type

[**EntitymanagerListEntitiesResponse**](EntitymanagerListEntitiesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listoptionslists"></a>
# **ListOptionsLists**
> EntitymanagerListOptionsListsResponse ListOptionsLists (EntitymanagerListOptionsListsRequest body)

List Options Lists

The ListOptionsLists endpoint allows users to retrieve a list of OptionLists available in the system. By making a request to this endpoint with the provided request format, users can obtain all the OptionLists associated with the specified tenant. This functionality enables users to access and manage the predefined options available for various attributes within the system. Utilizing the ListOptionsLists endpoint provides a convenient way to retrieve and work with OptionLists, facilitating efficient management of attribute options and ensuring consistency in attribute values throughout the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListOptionsListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListOptionsListsRequest(); // EntitymanagerListOptionsListsRequest | 

            try
            {
                // List Options Lists
                EntitymanagerListOptionsListsResponse result = apiInstance.ListOptionsLists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListOptionsLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOptionsListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Options Lists
    ApiResponse<EntitymanagerListOptionsListsResponse> response = apiInstance.ListOptionsListsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListOptionsListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerListOptionsListsRequest**](EntitymanagerListOptionsListsRequest.md) |  |  |

### Return type

[**EntitymanagerListOptionsListsResponse**](EntitymanagerListOptionsListsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproducts"></a>
# **ListProducts**
> ProductListProductsResponse ListProducts (ProductListProductsRequest body)

List Products

The ListProducts endpoint provides users with the ability to retrieve a filtered list of products based on specific criteria. By including filter parameters in the request, users can customize the response to only include products that meet certain conditions, such as price range, category, availability, or any other relevant attributes. This endpoint empowers users to efficiently narrow down the product selection and retrieve tailored results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductListProductsRequest(); // ProductListProductsRequest | 

            try
            {
                // List Products
                ProductListProductsResponse result = apiInstance.ListProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Products
    ApiResponse<ProductListProductsResponse> response = apiInstance.ListProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductListProductsRequest**](ProductListProductsRequest.md) |  |  |

### Return type

[**ProductListProductsResponse**](ProductListProductsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductsbyids"></a>
# **ListProductsByIds**
> ProductListProductsByIdsResponse ListProductsByIds (ProductListProductsByIdsRequest body)

List Products By Ids

The ListProductsByIds endpoint allows users to retrieve a list of products based on provided IDs. By making a request to this endpoint and specifying a set of product IDs, users can retrieve detailed information about the corresponding products. This endpoint facilitates efficient retrieval of specific products, enabling applications to display accurate and targeted product information to users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListProductsByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductListProductsByIdsRequest(); // ProductListProductsByIdsRequest | 

            try
            {
                // List Products By Ids
                ProductListProductsByIdsResponse result = apiInstance.ListProductsByIds(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListProductsByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductsByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Products By Ids
    ApiResponse<ProductListProductsByIdsResponse> response = apiInstance.ListProductsByIdsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListProductsByIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductListProductsByIdsRequest**](ProductListProductsByIdsRequest.md) |  |  |

### Return type

[**ProductListProductsByIdsResponse**](ProductListProductsByIdsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductsbysku"></a>
# **ListProductsBySku**
> ProductListProductsBySkuResponse ListProductsBySku (ProductListProductsBySkuRequest body)

List Products By Sku

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListProductsBySkuExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductListProductsBySkuRequest(); // ProductListProductsBySkuRequest | 

            try
            {
                // List Products By Sku
                ProductListProductsBySkuResponse result = apiInstance.ListProductsBySku(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListProductsBySku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductsBySkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Products By Sku
    ApiResponse<ProductListProductsBySkuResponse> response = apiInstance.ListProductsBySkuWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListProductsBySkuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductListProductsBySkuRequest**](ProductListProductsBySkuRequest.md) |  |  |

### Return type

[**ProductListProductsBySkuResponse**](ProductListProductsBySkuResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvariantsbysku"></a>
# **ListVariantsBySku**
> ProductListVariantsBySkuResponse ListVariantsBySku (ProductListVariantsBySkuRequest body)

List Product Variants By Sku

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ListVariantsBySkuExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductListVariantsBySkuRequest(); // ProductListVariantsBySkuRequest | 

            try
            {
                // List Product Variants By Sku
                ProductListVariantsBySkuResponse result = apiInstance.ListVariantsBySku(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListVariantsBySku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListVariantsBySkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Product Variants By Sku
    ApiResponse<ProductListVariantsBySkuResponse> response = apiInstance.ListVariantsBySkuWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListVariantsBySkuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductListVariantsBySkuRequest**](ProductListVariantsBySkuRequest.md) |  |  |

### Return type

[**ProductListVariantsBySkuResponse**](ProductListVariantsBySkuResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkcreateattribute"></a>
# **ProductBulkCreateAttribute**
> EntitymanagerBulkCreateAttributeResponse ProductBulkCreateAttribute (EntitymanagerBulkCreateAttributeRequest body)



Allow creation of multiple attributes. If any attribute is invalid, an error will be returned with more details, and in the response body, the attributes created will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkCreateAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerBulkCreateAttributeRequest(); // EntitymanagerBulkCreateAttributeRequest | 

            try
            {
                EntitymanagerBulkCreateAttributeResponse result = apiInstance.ProductBulkCreateAttribute(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkCreateAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkCreateAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerBulkCreateAttributeResponse> response = apiInstance.ProductBulkCreateAttributeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkCreateAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerBulkCreateAttributeRequest**](EntitymanagerBulkCreateAttributeRequest.md) |  |  |

### Return type

[**EntitymanagerBulkCreateAttributeResponse**](EntitymanagerBulkCreateAttributeResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkupdate"></a>
# **ProductBulkUpdate**
> ProductBulkUpdateResponse ProductBulkUpdate (ProductBulkUpdateRequest body)



This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductBulkUpdateRequest(); // ProductBulkUpdateRequest | 

            try
            {
                ProductBulkUpdateResponse result = apiInstance.ProductBulkUpdate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductBulkUpdateResponse> response = apiInstance.ProductBulkUpdateWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkUpdateRequest**](ProductBulkUpdateRequest.md) |  |  |

### Return type

[**ProductBulkUpdateResponse**](ProductBulkUpdateResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productcreateattributegroup"></a>
# **ProductCreateAttributeGroup**
> EntitymanagerAttributeGroup ProductCreateAttributeGroup (EntitymanagerCreateAttributeGroupRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductCreateAttributeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerCreateAttributeGroupRequest(); // EntitymanagerCreateAttributeGroupRequest | 

            try
            {
                EntitymanagerAttributeGroup result = apiInstance.ProductCreateAttributeGroup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCreateAttributeGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCreateAttributeGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerAttributeGroup> response = apiInstance.ProductCreateAttributeGroupWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCreateAttributeGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerCreateAttributeGroupRequest**](EntitymanagerCreateAttributeGroupRequest.md) |  |  |

### Return type

[**EntitymanagerAttributeGroup**](EntitymanagerAttributeGroup.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productcreateproduct"></a>
# **ProductCreateProduct**
> ProductCreateProductResponse ProductCreateProduct (ProductCreateProductRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductCreateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductCreateProductRequest(); // ProductCreateProductRequest | The CreateProductRequest message is used to create a new product within the system. It contains various fields that allow specifying the details and attributes of the product.

            try
            {
                ProductCreateProductResponse result = apiInstance.ProductCreateProduct(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCreateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCreateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductCreateProductResponse> response = apiInstance.ProductCreateProductWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCreateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductCreateProductRequest**](ProductCreateProductRequest.md) | The CreateProductRequest message is used to create a new product within the system. It contains various fields that allow specifying the details and attributes of the product. |  |

### Return type

[**ProductCreateProductResponse**](ProductCreateProductResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productcreateproductv2"></a>
# **ProductCreateProductV2**
> ProductCreateProductResponseV2 ProductCreateProductV2 (ProductCreateProductRequestV2 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductCreateProductV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductCreateProductRequestV2(); // ProductCreateProductRequestV2 | 

            try
            {
                ProductCreateProductResponseV2 result = apiInstance.ProductCreateProductV2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCreateProductV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCreateProductV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductCreateProductResponseV2> response = apiInstance.ProductCreateProductV2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCreateProductV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductCreateProductRequestV2**](ProductCreateProductRequestV2.md) |  |  |

### Return type

[**ProductCreateProductResponseV2**](ProductCreateProductResponseV2.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productdelete"></a>
# **ProductDelete**
> ProductDeleteResponse ProductDelete (ProductDeleteRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductDeleteRequest(); // ProductDeleteRequest | 

            try
            {
                ProductDeleteResponse result = apiInstance.ProductDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductDeleteResponse> response = apiInstance.ProductDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductDeleteRequest**](ProductDeleteRequest.md) |  |  |

### Return type

[**ProductDeleteResponse**](ProductDeleteResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productdeleteattribute"></a>
# **ProductDeleteAttribute**
> Object ProductDeleteAttribute (EntitymanagerDeleteAttributeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductDeleteAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerDeleteAttributeRequest(); // EntitymanagerDeleteAttributeRequest | 

            try
            {
                Object result = apiInstance.ProductDeleteAttribute(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductDeleteAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductDeleteAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductDeleteAttributeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductDeleteAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerDeleteAttributeRequest**](EntitymanagerDeleteAttributeRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productdeleteproduct"></a>
# **ProductDeleteProduct**
> Object ProductDeleteProduct (ProductDeleteProductRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductDeleteProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductDeleteProductRequest(); // ProductDeleteProductRequest | 

            try
            {
                Object result = apiInstance.ProductDeleteProduct(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductDeleteProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductDeleteProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductDeleteProductWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductDeleteProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductDeleteProductRequest**](ProductDeleteProductRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetattributegroup"></a>
# **ProductGetAttributeGroup**
> EntitymanagerAttributeGroup ProductGetAttributeGroup (EntitymanagerGetAttributeGroupRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetAttributeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetAttributeGroupRequest(); // EntitymanagerGetAttributeGroupRequest | 

            try
            {
                EntitymanagerAttributeGroup result = apiInstance.ProductGetAttributeGroup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetAttributeGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetAttributeGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerAttributeGroup> response = apiInstance.ProductGetAttributeGroupWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetAttributeGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerGetAttributeGroupRequest**](EntitymanagerGetAttributeGroupRequest.md) |  |  |

### Return type

[**EntitymanagerAttributeGroup**](EntitymanagerAttributeGroup.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistattributegroups"></a>
# **ProductListAttributeGroups**
> EntitymanagerListAttributeGroupsResponse ProductListAttributeGroups (EntitymanagerListAttributeGroupsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListAttributeGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListAttributeGroupsRequest(); // EntitymanagerListAttributeGroupsRequest | 

            try
            {
                EntitymanagerListAttributeGroupsResponse result = apiInstance.ProductListAttributeGroups(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListAttributeGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListAttributeGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerListAttributeGroupsResponse> response = apiInstance.ProductListAttributeGroupsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListAttributeGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerListAttributeGroupsRequest**](EntitymanagerListAttributeGroupsRequest.md) |  |  |

### Return type

[**EntitymanagerListAttributeGroupsResponse**](EntitymanagerListAttributeGroupsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdateattribute"></a>
# **ProductUpdateAttribute**
> EntitymanagerAttribute ProductUpdateAttribute (EntitymanagerUpdateAttributeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerUpdateAttributeRequest(); // EntitymanagerUpdateAttributeRequest | 

            try
            {
                EntitymanagerAttribute result = apiInstance.ProductUpdateAttribute(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerAttribute> response = apiInstance.ProductUpdateAttributeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerUpdateAttributeRequest**](EntitymanagerUpdateAttributeRequest.md) |  |  |

### Return type

[**EntitymanagerAttribute**](EntitymanagerAttribute.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdateattributegroup"></a>
# **ProductUpdateAttributeGroup**
> EntitymanagerAttributeGroup ProductUpdateAttributeGroup (EntitymanagerUpdateAttributeGroupRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateAttributeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerUpdateAttributeGroupRequest(); // EntitymanagerUpdateAttributeGroupRequest | 

            try
            {
                EntitymanagerAttributeGroup result = apiInstance.ProductUpdateAttributeGroup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateAttributeGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateAttributeGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerAttributeGroup> response = apiInstance.ProductUpdateAttributeGroupWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateAttributeGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerUpdateAttributeGroupRequest**](EntitymanagerUpdateAttributeGroupRequest.md) |  |  |

### Return type

[**EntitymanagerAttributeGroup**](EntitymanagerAttributeGroup.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdateproduct"></a>
# **ProductUpdateProduct**
> ProductUpdateProductResponse ProductUpdateProduct (ProductUpdateProductRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductUpdateProductRequest(); // ProductUpdateProductRequest | 

            try
            {
                ProductUpdateProductResponse result = apiInstance.ProductUpdateProduct(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductUpdateProductResponse> response = apiInstance.ProductUpdateProductWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductUpdateProductRequest**](ProductUpdateProductRequest.md) |  |  |

### Return type

[**ProductUpdateProductResponse**](ProductUpdateProductResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdateproductv2"></a>
# **ProductUpdateProductV2**
> Object ProductUpdateProductV2 (ProductUpdateProductRequestV2 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateProductV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductUpdateProductRequestV2(); // ProductUpdateProductRequestV2 | 

            try
            {
                Object result = apiInstance.ProductUpdateProductV2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateProductV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateProductV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductUpdateProductV2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateProductV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductUpdateProductRequestV2**](ProductUpdateProductRequestV2.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removemediagalleryentry"></a>
# **RemoveMediaGalleryEntry**
> Object RemoveMediaGalleryEntry (ProductRemoveMediaGalleryEntryRequest body)

Remove Media Gallery Entry

The RemoveMediaGalleryEntry endpoint allows users to remove a specific media entry from a product's gallery. By making a request to this endpoint and providing the tenant ID, product ID, and the unique identifier of the media entry, users can easily manage and update the visual content of a product's gallery. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class RemoveMediaGalleryEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductRemoveMediaGalleryEntryRequest(); // ProductRemoveMediaGalleryEntryRequest | 

            try
            {
                // Remove Media Gallery Entry
                Object result = apiInstance.RemoveMediaGalleryEntry(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveMediaGalleryEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMediaGalleryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Media Gallery Entry
    ApiResponse<Object> response = apiInstance.RemoveMediaGalleryEntryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.RemoveMediaGalleryEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductRemoveMediaGalleryEntryRequest**](ProductRemoveMediaGalleryEntryRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateattributeoptions"></a>
# **UpdateAttributeOptions**
> EntitymanagerUpdateAttributeOptionsResponse UpdateAttributeOptions (EntitymanagerUpdateAttributeOptionsRequest body)

Update Attribute Options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class UpdateAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerUpdateAttributeOptionsRequest(); // EntitymanagerUpdateAttributeOptionsRequest | 

            try
            {
                // Update Attribute Options
                EntitymanagerUpdateAttributeOptionsResponse result = apiInstance.UpdateAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Attribute Options
    ApiResponse<EntitymanagerUpdateAttributeOptionsResponse> response = apiInstance.UpdateAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateAttributeOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerUpdateAttributeOptionsRequest**](EntitymanagerUpdateAttributeOptionsRequest.md) |  |  |

### Return type

[**EntitymanagerUpdateAttributeOptionsResponse**](EntitymanagerUpdateAttributeOptionsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedatatobereviewed"></a>
# **UpdateDataToBeReviewed**
> ProductGetEnhanceProductDataWithAIStatusResponse UpdateDataToBeReviewed (ProductGetEnhanceProductDataWithAIStatusRequest body)

Get Enhance Product Data With AI Status

The GetEnhanceProductDataWithAIStatus endpoint allows users to retrieve the status of a product data enhancement process using artificial intelligence (AI) capabilities. By making a request to this endpoint and providing the necessary input data, users can check the progress and completion status of the AI-driven product data enhancement operation. This functionality provides visibility and transparency into the AI processing of product data, enabling users to monitor and track the status of the enhancement process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class UpdateDataToBeReviewedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductGetEnhanceProductDataWithAIStatusRequest(); // ProductGetEnhanceProductDataWithAIStatusRequest | 

            try
            {
                // Get Enhance Product Data With AI Status
                ProductGetEnhanceProductDataWithAIStatusResponse result = apiInstance.UpdateDataToBeReviewed(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateDataToBeReviewed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataToBeReviewedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Enhance Product Data With AI Status
    ApiResponse<ProductGetEnhanceProductDataWithAIStatusResponse> response = apiInstance.UpdateDataToBeReviewedWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateDataToBeReviewedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductGetEnhanceProductDataWithAIStatusRequest**](ProductGetEnhanceProductDataWithAIStatusRequest.md) |  |  |

### Return type

[**ProductGetEnhanceProductDataWithAIStatusResponse**](ProductGetEnhanceProductDataWithAIStatusResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedatatobereviewed_0"></a>
# **UpdateDataToBeReviewed_0**
> Object UpdateDataToBeReviewed_0 (ProductUpdateDataToBeReviewedRequest body)

Update Data To Be Reviewed

The UpdateDataToBeReviewed endpoint allows users to update product data that is pending review. By sending a request to this endpoint and providing the necessary input data, users can modify and enhance the product information that is currently under review. This functionality enables users to make changes to product data submissions and ensure that the information is accurate and up-to-date before final approval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class UpdateDataToBeReviewed_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductUpdateDataToBeReviewedRequest(); // ProductUpdateDataToBeReviewedRequest | 

            try
            {
                // Update Data To Be Reviewed
                Object result = apiInstance.UpdateDataToBeReviewed_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateDataToBeReviewed_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataToBeReviewed_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Data To Be Reviewed
    ApiResponse<Object> response = apiInstance.UpdateDataToBeReviewed_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateDataToBeReviewed_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductUpdateDataToBeReviewedRequest**](ProductUpdateDataToBeReviewedRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemediagalleryentry"></a>
# **UpdateMediaGalleryEntry**
> Object UpdateMediaGalleryEntry (ProductUpdateMediaGalleryEntryRequest body)

Update Media Gallery Entry

The UpdateMediaGalleryEntry endpoint allows users to modify and update a specific media entry within a product's gallery. By sending a request to this endpoint and providing the necessary information, users can efficiently update the media asset, position, and metadata associated with the entry. This operation is asynchronous and may complete after the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class UpdateMediaGalleryEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductUpdateMediaGalleryEntryRequest(); // ProductUpdateMediaGalleryEntryRequest | 

            try
            {
                // Update Media Gallery Entry
                Object result = apiInstance.UpdateMediaGalleryEntry(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateMediaGalleryEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMediaGalleryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Media Gallery Entry
    ApiResponse<Object> response = apiInstance.UpdateMediaGalleryEntryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateMediaGalleryEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductUpdateMediaGalleryEntryRequest**](ProductUpdateMediaGalleryEntryRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateoptionslist"></a>
# **UpdateOptionsList**
> EntitymanagerUpdateOptionsListResponse UpdateOptionsList (EntitymanagerUpdateOptionsListRequest body)

Update Options List

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class UpdateOptionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerUpdateOptionsListRequest(); // EntitymanagerUpdateOptionsListRequest | 

            try
            {
                // Update Options List
                EntitymanagerUpdateOptionsListResponse result = apiInstance.UpdateOptionsList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateOptionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOptionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Options List
    ApiResponse<EntitymanagerUpdateOptionsListResponse> response = apiInstance.UpdateOptionsListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateOptionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**EntitymanagerUpdateOptionsListRequest**](EntitymanagerUpdateOptionsListRequest.md) |  |  |

### Return type

[**EntitymanagerUpdateOptionsListResponse**](EntitymanagerUpdateOptionsListResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproductwithai"></a>
# **UpdateProductWithAI**
> ProductUpdateProductWithAIResponse UpdateProductWithAI (ProductUpdateProductWithAIRequest body)

Update Product With AI

The UpdateProductWithAI endpoint allows users to update an existing product within the system using artificial intelligence (AI) capabilities. By sending a request to this endpoint and providing the necessary input data, users can leverage AI algorithms to enhance and optimize the product update process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class UpdateProductWithAIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductApi(config);
            var body = new ProductUpdateProductWithAIRequest(); // ProductUpdateProductWithAIRequest | 

            try
            {
                // Update Product With AI
                ProductUpdateProductWithAIResponse result = apiInstance.UpdateProductWithAI(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductWithAI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductWithAIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Product With AI
    ApiResponse<ProductUpdateProductWithAIResponse> response = apiInstance.UpdateProductWithAIWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateProductWithAIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductUpdateProductWithAIRequest**](ProductUpdateProductWithAIRequest.md) |  |  |

### Return type

[**ProductUpdateProductWithAIResponse**](ProductUpdateProductWithAIResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

