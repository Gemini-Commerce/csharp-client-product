# product.Api.ProductApi

All URIs are relative to *https://product.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductAddMediaGalleryEntry**](ProductApi.md#productaddmediagalleryentry) | **POST** /product.Product/AddMediaGalleryEntry |  |
| [**ProductBulkAddAssetsEntries**](ProductApi.md#productbulkaddassetsentries) | **POST** /product.Product/BulkAddAssetsEntries | Assets endpoints |
| [**ProductBulkCreateAttribute**](ProductApi.md#productbulkcreateattribute) | **POST** /product.Product/BulkCreateAttribute |  |
| [**ProductBulkDeleteProducts**](ProductApi.md#productbulkdeleteproducts) | **POST** /product.Product/BulkDeleteProducts |  |
| [**ProductBulkRemoveAssetsEntries**](ProductApi.md#productbulkremoveassetsentries) | **POST** /product.Product/BulkRemoveAssetsEntries |  |
| [**ProductBulkUpdate**](ProductApi.md#productbulkupdate) | **POST** /product.Product/BulkUpdate |  |
| [**ProductBulkUpdateAssetsEntries**](ProductApi.md#productbulkupdateassetsentries) | **POST** /product.Product/BulkUpdateAssetsEntries |  |
| [**ProductBulkUpdateV2**](ProductApi.md#productbulkupdatev2) | **POST** /product.Product/BulkUpdateV2 |  |
| [**ProductCreateAttributeGroup**](ProductApi.md#productcreateattributegroup) | **POST** /product.Product/CreateAttributeGroup |  |
| [**ProductCreateAttributeOptions**](ProductApi.md#productcreateattributeoptions) | **POST** /product.Product/CreateAttributeOptions |  |
| [**ProductCreateEntity**](ProductApi.md#productcreateentity) | **POST** /product.Product/CreateEntity |  |
| [**ProductCreateOptionsList**](ProductApi.md#productcreateoptionslist) | **POST** /product.Product/CreateOptionsList |  |
| [**ProductCreateProduct**](ProductApi.md#productcreateproduct) | **POST** /product.Product/CreateProduct |  |
| [**ProductCreateProductV2**](ProductApi.md#productcreateproductv2) | **POST** /product.Product/CreateProductV2 |  |
| [**ProductDelete**](ProductApi.md#productdelete) | **POST** /product.Product/Delete |  |
| [**ProductDeleteAttribute**](ProductApi.md#productdeleteattribute) | **POST** /product.Product/DeleteAttribute |  |
| [**ProductDeleteProduct**](ProductApi.md#productdeleteproduct) | **POST** /product.Product/DeleteProduct |  |
| [**ProductGetAttributeGroup**](ProductApi.md#productgetattributegroup) | **POST** /product.Product/GetAttributeGroup |  |
| [**ProductGetAttributeOption**](ProductApi.md#productgetattributeoption) | **POST** /product.Product/GetAttributeOption |  |
| [**ProductGetAttributeOptions**](ProductApi.md#productgetattributeoptions) | **POST** /product.Product/GetAttributeOptions |  |
| [**ProductGetEntity**](ProductApi.md#productgetentity) | **POST** /product.Product/GetEntity |  |
| [**ProductGetOptionsList**](ProductApi.md#productgetoptionslist) | **POST** /product.Product/GetOptionsList |  |
| [**ProductGetProduct**](ProductApi.md#productgetproduct) | **POST** /product.Product/GetProduct |  |
| [**ProductGetProductByCode**](ProductApi.md#productgetproductbycode) | **POST** /product.Product/GetProductByCode |  |
| [**ProductGetProductByUrlKey**](ProductApi.md#productgetproductbyurlkey) | **POST** /product.Product/GetProductByUrlKey |  |
| [**ProductListAttributeGroups**](ProductApi.md#productlistattributegroups) | **POST** /product.Product/ListAttributeGroups | Attribute Groups endpoints |
| [**ProductListAttributeOptions**](ProductApi.md#productlistattributeoptions) | **POST** /product.Product/ListAttributeOptions |  |
| [**ProductListEntities**](ProductApi.md#productlistentities) | **POST** /product.Product/ListEntities |  |
| [**ProductListOptionsLists**](ProductApi.md#productlistoptionslists) | **POST** /product.Product/ListOptionsLists |  |
| [**ProductListProducts**](ProductApi.md#productlistproducts) | **POST** /product.Product/ListProducts |  |
| [**ProductListProductsByIds**](ProductApi.md#productlistproductsbyids) | **POST** /product.Product/ListProductsByIds |  |
| [**ProductListProductsBySku**](ProductApi.md#productlistproductsbysku) | **POST** /product.Product/ListProductsBySku |  |
| [**ProductListVariantsBySku**](ProductApi.md#productlistvariantsbysku) | **POST** /product.Product/ListVariantsBySku |  |
| [**ProductRemoveMediaGalleryEntry**](ProductApi.md#productremovemediagalleryentry) | **POST** /product.Product/RemoveMediaGalleryEntry |  |
| [**ProductUpdateAttribute**](ProductApi.md#productupdateattribute) | **POST** /product.Product/UpdateAttribute |  |
| [**ProductUpdateAttributeGroup**](ProductApi.md#productupdateattributegroup) | **POST** /product.Product/UpdateAttributeGroup |  |
| [**ProductUpdateAttributeOptions**](ProductApi.md#productupdateattributeoptions) | **POST** /product.Product/UpdateAttributeOptions | rpc GetAttributeOptionByCode (product.entitymanager.GetAttributeOptionByCodeRequest) returns (product.entitymanager.GetAttributeOptionByCodeResponse) {} |
| [**ProductUpdateMediaGalleryEntry**](ProductApi.md#productupdatemediagalleryentry) | **POST** /product.Product/UpdateMediaGalleryEntry |  |
| [**ProductUpdateOptionsList**](ProductApi.md#productupdateoptionslist) | **POST** /product.Product/UpdateOptionsList |  |
| [**ProductUpdateProduct**](ProductApi.md#productupdateproduct) | **POST** /product.Product/UpdateProduct |  |
| [**ProductUpdateProductV2**](ProductApi.md#productupdateproductv2) | **POST** /product.Product/UpdateProductV2 |  |

<a id="productaddmediagalleryentry"></a>
# **ProductAddMediaGalleryEntry**
> ProductAddMediaGalleryEntryResponse ProductAddMediaGalleryEntry (ProductAddMediaGalleryEntryRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductAddMediaGalleryEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductAddMediaGalleryEntryRequest(); // ProductAddMediaGalleryEntryRequest | 

            try
            {
                ProductAddMediaGalleryEntryResponse result = apiInstance.ProductAddMediaGalleryEntry(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAddMediaGalleryEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAddMediaGalleryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductAddMediaGalleryEntryResponse> response = apiInstance.ProductAddMediaGalleryEntryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAddMediaGalleryEntryWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkaddassetsentries"></a>
# **ProductBulkAddAssetsEntries**
> ProductBulkAddAssetsEntriesResponse ProductBulkAddAssetsEntries (ProductBulkAddAssetsEntriesRequest body)

Assets endpoints

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkAddAssetsEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductBulkAddAssetsEntriesRequest(); // ProductBulkAddAssetsEntriesRequest | 

            try
            {
                // Assets endpoints
                ProductBulkAddAssetsEntriesResponse result = apiInstance.ProductBulkAddAssetsEntries(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkAddAssetsEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkAddAssetsEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assets endpoints
    ApiResponse<ProductBulkAddAssetsEntriesResponse> response = apiInstance.ProductBulkAddAssetsEntriesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkAddAssetsEntriesWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkcreateattribute"></a>
# **ProductBulkCreateAttribute**
> EntitymanagerBulkCreateAttributeResponse ProductBulkCreateAttribute (EntitymanagerBulkCreateAttributeRequest body)



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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkdeleteproducts"></a>
# **ProductBulkDeleteProducts**
> Object ProductBulkDeleteProducts (ProductBulkDeleteProductsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkDeleteProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductBulkDeleteProductsRequest(); // ProductBulkDeleteProductsRequest | 

            try
            {
                Object result = apiInstance.ProductBulkDeleteProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkDeleteProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkDeleteProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductBulkDeleteProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkDeleteProductsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkremoveassetsentries"></a>
# **ProductBulkRemoveAssetsEntries**
> Object ProductBulkRemoveAssetsEntries (ProductBulkRemoveAssetsEntriesRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkRemoveAssetsEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductBulkRemoveAssetsEntriesRequest(); // ProductBulkRemoveAssetsEntriesRequest | 

            try
            {
                Object result = apiInstance.ProductBulkRemoveAssetsEntries(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkRemoveAssetsEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkRemoveAssetsEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductBulkRemoveAssetsEntriesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkRemoveAssetsEntriesWithHttpInfo: " + e.Message);
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

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkupdateassetsentries"></a>
# **ProductBulkUpdateAssetsEntries**
> ProductBulkUpdateAssetsEntriesResponse ProductBulkUpdateAssetsEntries (ProductBulkUpdateAssetsEntriesRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkUpdateAssetsEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductBulkUpdateAssetsEntriesRequest(); // ProductBulkUpdateAssetsEntriesRequest | 

            try
            {
                ProductBulkUpdateAssetsEntriesResponse result = apiInstance.ProductBulkUpdateAssetsEntries(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkUpdateAssetsEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkUpdateAssetsEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductBulkUpdateAssetsEntriesResponse> response = apiInstance.ProductBulkUpdateAssetsEntriesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkUpdateAssetsEntriesWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productbulkupdatev2"></a>
# **ProductBulkUpdateV2**
> ProductBulkUpdateResponseV2 ProductBulkUpdateV2 (ProductBulkUpdateRequestV2 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductBulkUpdateV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductBulkUpdateRequestV2(); // ProductBulkUpdateRequestV2 | 

            try
            {
                ProductBulkUpdateResponseV2 result = apiInstance.ProductBulkUpdateV2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBulkUpdateV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBulkUpdateV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductBulkUpdateResponseV2> response = apiInstance.ProductBulkUpdateV2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBulkUpdateV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductBulkUpdateRequestV2**](ProductBulkUpdateRequestV2.md) |  |  |

### Return type

[**ProductBulkUpdateResponseV2**](ProductBulkUpdateResponseV2.md)

### Authorization

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productcreateattributeoptions"></a>
# **ProductCreateAttributeOptions**
> EntitymanagerCreateAttributeOptionsResponse ProductCreateAttributeOptions (EntitymanagerCreateAttributeOptionsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductCreateAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerCreateAttributeOptionsRequest(); // EntitymanagerCreateAttributeOptionsRequest | 

            try
            {
                EntitymanagerCreateAttributeOptionsResponse result = apiInstance.ProductCreateAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCreateAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCreateAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerCreateAttributeOptionsResponse> response = apiInstance.ProductCreateAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCreateAttributeOptionsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productcreateentity"></a>
# **ProductCreateEntity**
> EntitymanagerCreateEntityResponse ProductCreateEntity (EntitymanagerEntity body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductCreateEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerEntity(); // EntitymanagerEntity | 

            try
            {
                EntitymanagerCreateEntityResponse result = apiInstance.ProductCreateEntity(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCreateEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCreateEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerCreateEntityResponse> response = apiInstance.ProductCreateEntityWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCreateEntityWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productcreateoptionslist"></a>
# **ProductCreateOptionsList**
> EntitymanagerCreateOptionsListResponse ProductCreateOptionsList (EntitymanagerCreateOptionsListRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductCreateOptionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerCreateOptionsListRequest(); // EntitymanagerCreateOptionsListRequest | 

            try
            {
                EntitymanagerCreateOptionsListResponse result = apiInstance.ProductCreateOptionsList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCreateOptionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCreateOptionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerCreateOptionsListResponse> response = apiInstance.ProductCreateOptionsListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCreateOptionsListWithHttpInfo: " + e.Message);
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

No authorization required

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
            var apiInstance = new ProductApi(config);
            var body = new ProductCreateProductRequest(); // ProductCreateProductRequest | 

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
| **body** | [**ProductCreateProductRequest**](ProductCreateProductRequest.md) |  |  |

### Return type

[**ProductCreateProductResponse**](ProductCreateProductResponse.md)

### Authorization

No authorization required

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

No authorization required

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

No authorization required

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

No authorization required

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

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetattributeoption"></a>
# **ProductGetAttributeOption**
> EntitymanagerGetAttributeOptionResponse ProductGetAttributeOption (EntitymanagerGetAttributeOptionRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetAttributeOptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetAttributeOptionRequest(); // EntitymanagerGetAttributeOptionRequest | 

            try
            {
                EntitymanagerGetAttributeOptionResponse result = apiInstance.ProductGetAttributeOption(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetAttributeOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetAttributeOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerGetAttributeOptionResponse> response = apiInstance.ProductGetAttributeOptionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetAttributeOptionWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetattributeoptions"></a>
# **ProductGetAttributeOptions**
> EntitymanagerGetAttributeOptionsResponse ProductGetAttributeOptions (EntitymanagerGetAttributeOptionsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetAttributeOptionsRequest(); // EntitymanagerGetAttributeOptionsRequest | 

            try
            {
                EntitymanagerGetAttributeOptionsResponse result = apiInstance.ProductGetAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerGetAttributeOptionsResponse> response = apiInstance.ProductGetAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetAttributeOptionsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetentity"></a>
# **ProductGetEntity**
> EntitymanagerEntity ProductGetEntity (EntitymanagerEntityRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerEntityRequest(); // EntitymanagerEntityRequest | 

            try
            {
                EntitymanagerEntity result = apiInstance.ProductGetEntity(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerEntity> response = apiInstance.ProductGetEntityWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetEntityWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetoptionslist"></a>
# **ProductGetOptionsList**
> EntitymanagerGetOptionsListResponse ProductGetOptionsList (EntitymanagerGetOptionsListRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetOptionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerGetOptionsListRequest(); // EntitymanagerGetOptionsListRequest | 

            try
            {
                EntitymanagerGetOptionsListResponse result = apiInstance.ProductGetOptionsList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetOptionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetOptionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerGetOptionsListResponse> response = apiInstance.ProductGetOptionsListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetOptionsListWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetproduct"></a>
# **ProductGetProduct**
> ProductGetProductResponse ProductGetProduct (ProductGetProductRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductRequest(); // ProductGetProductRequest | 

            try
            {
                ProductGetProductResponse result = apiInstance.ProductGetProduct(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductGetProductResponse> response = apiInstance.ProductGetProductWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetProductWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetproductbycode"></a>
# **ProductGetProductByCode**
> ProductGetProductByCodeResponse ProductGetProductByCode (ProductGetProductByCodeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetProductByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductByCodeRequest(); // ProductGetProductByCodeRequest | 

            try
            {
                ProductGetProductByCodeResponse result = apiInstance.ProductGetProductByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetProductByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetProductByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductGetProductByCodeResponse> response = apiInstance.ProductGetProductByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetProductByCodeWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productgetproductbyurlkey"></a>
# **ProductGetProductByUrlKey**
> ProductGetProductByUrlKeyResponse ProductGetProductByUrlKey (ProductGetProductByUrlKeyRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductGetProductByUrlKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductGetProductByUrlKeyRequest(); // ProductGetProductByUrlKeyRequest | 

            try
            {
                ProductGetProductByUrlKeyResponse result = apiInstance.ProductGetProductByUrlKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductGetProductByUrlKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGetProductByUrlKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductGetProductByUrlKeyResponse> response = apiInstance.ProductGetProductByUrlKeyWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductGetProductByUrlKeyWithHttpInfo: " + e.Message);
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

No authorization required

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

Attribute Groups endpoints

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
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListAttributeGroupsRequest(); // EntitymanagerListAttributeGroupsRequest | 

            try
            {
                // Attribute Groups endpoints
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
    // Attribute Groups endpoints
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistattributeoptions"></a>
# **ProductListAttributeOptions**
> EntitymanagerListAttributeOptionsResponse ProductListAttributeOptions (EntitymanagerListAttributeOptionsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListAttributeOptionsRequest(); // EntitymanagerListAttributeOptionsRequest | 

            try
            {
                EntitymanagerListAttributeOptionsResponse result = apiInstance.ProductListAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerListAttributeOptionsResponse> response = apiInstance.ProductListAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListAttributeOptionsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistentities"></a>
# **ProductListEntities**
> EntitymanagerListEntitiesResponse ProductListEntities (EntitymanagerListEntitiesRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListEntitiesRequest(); // EntitymanagerListEntitiesRequest | 

            try
            {
                EntitymanagerListEntitiesResponse result = apiInstance.ProductListEntities(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerListEntitiesResponse> response = apiInstance.ProductListEntitiesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListEntitiesWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistoptionslists"></a>
# **ProductListOptionsLists**
> EntitymanagerListOptionsListsResponse ProductListOptionsLists (EntitymanagerListOptionsListsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListOptionsListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerListOptionsListsRequest(); // EntitymanagerListOptionsListsRequest | 

            try
            {
                EntitymanagerListOptionsListsResponse result = apiInstance.ProductListOptionsLists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListOptionsLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListOptionsListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerListOptionsListsResponse> response = apiInstance.ProductListOptionsListsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListOptionsListsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistproducts"></a>
# **ProductListProducts**
> ProductListProductsResponse ProductListProducts (ProductListProductsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductListProductsRequest(); // ProductListProductsRequest | 

            try
            {
                ProductListProductsResponse result = apiInstance.ProductListProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductListProductsResponse> response = apiInstance.ProductListProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListProductsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistproductsbyids"></a>
# **ProductListProductsByIds**
> ProductListProductsByIdsResponse ProductListProductsByIds (ProductListProductsByIdsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListProductsByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductListProductsByIdsRequest(); // ProductListProductsByIdsRequest | 

            try
            {
                ProductListProductsByIdsResponse result = apiInstance.ProductListProductsByIds(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListProductsByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListProductsByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductListProductsByIdsResponse> response = apiInstance.ProductListProductsByIdsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListProductsByIdsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistproductsbysku"></a>
# **ProductListProductsBySku**
> ProductListProductsBySkuResponse ProductListProductsBySku (ProductListProductsBySkuRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListProductsBySkuExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductListProductsBySkuRequest(); // ProductListProductsBySkuRequest | 

            try
            {
                ProductListProductsBySkuResponse result = apiInstance.ProductListProductsBySku(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListProductsBySku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListProductsBySkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductListProductsBySkuResponse> response = apiInstance.ProductListProductsBySkuWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListProductsBySkuWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productlistvariantsbysku"></a>
# **ProductListVariantsBySku**
> ProductListVariantsBySkuResponse ProductListVariantsBySku (ProductListVariantsBySkuRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductListVariantsBySkuExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductListVariantsBySkuRequest(); // ProductListVariantsBySkuRequest | 

            try
            {
                ProductListVariantsBySkuResponse result = apiInstance.ProductListVariantsBySku(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductListVariantsBySku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListVariantsBySkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductListVariantsBySkuResponse> response = apiInstance.ProductListVariantsBySkuWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListVariantsBySkuWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productremovemediagalleryentry"></a>
# **ProductRemoveMediaGalleryEntry**
> Object ProductRemoveMediaGalleryEntry (ProductRemoveMediaGalleryEntryRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductRemoveMediaGalleryEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductRemoveMediaGalleryEntryRequest(); // ProductRemoveMediaGalleryEntryRequest | 

            try
            {
                Object result = apiInstance.ProductRemoveMediaGalleryEntry(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductRemoveMediaGalleryEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductRemoveMediaGalleryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductRemoveMediaGalleryEntryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductRemoveMediaGalleryEntryWithHttpInfo: " + e.Message);
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

No authorization required

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

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdateattributeoptions"></a>
# **ProductUpdateAttributeOptions**
> EntitymanagerUpdateAttributeOptionsResponse ProductUpdateAttributeOptions (EntitymanagerUpdateAttributeOptionsRequest body)

rpc GetAttributeOptionByCode (product.entitymanager.GetAttributeOptionByCodeRequest) returns (product.entitymanager.GetAttributeOptionByCodeResponse) {}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateAttributeOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerUpdateAttributeOptionsRequest(); // EntitymanagerUpdateAttributeOptionsRequest | 

            try
            {
                // rpc GetAttributeOptionByCode (product.entitymanager.GetAttributeOptionByCodeRequest) returns (product.entitymanager.GetAttributeOptionByCodeResponse) {}
                EntitymanagerUpdateAttributeOptionsResponse result = apiInstance.ProductUpdateAttributeOptions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateAttributeOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateAttributeOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // rpc GetAttributeOptionByCode (product.entitymanager.GetAttributeOptionByCodeRequest) returns (product.entitymanager.GetAttributeOptionByCodeResponse) {}
    ApiResponse<EntitymanagerUpdateAttributeOptionsResponse> response = apiInstance.ProductUpdateAttributeOptionsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateAttributeOptionsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdatemediagalleryentry"></a>
# **ProductUpdateMediaGalleryEntry**
> Object ProductUpdateMediaGalleryEntry (ProductUpdateMediaGalleryEntryRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateMediaGalleryEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new ProductUpdateMediaGalleryEntryRequest(); // ProductUpdateMediaGalleryEntryRequest | 

            try
            {
                Object result = apiInstance.ProductUpdateMediaGalleryEntry(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateMediaGalleryEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateMediaGalleryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProductUpdateMediaGalleryEntryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateMediaGalleryEntryWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productupdateoptionslist"></a>
# **ProductUpdateOptionsList**
> EntitymanagerUpdateOptionsListResponse ProductUpdateOptionsList (EntitymanagerUpdateOptionsListRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product.Api;
using product.Client;
using product.Model;

namespace Example
{
    public class ProductUpdateOptionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product.api.gogemini.io";
            var apiInstance = new ProductApi(config);
            var body = new EntitymanagerUpdateOptionsListRequest(); // EntitymanagerUpdateOptionsListRequest | 

            try
            {
                EntitymanagerUpdateOptionsListResponse result = apiInstance.ProductUpdateOptionsList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateOptionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateOptionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntitymanagerUpdateOptionsListResponse> response = apiInstance.ProductUpdateOptionsListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateOptionsListWithHttpInfo: " + e.Message);
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

No authorization required

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

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

