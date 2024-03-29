/*
 * Product Service
 *
 * API for managing products
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = product.Client.OpenAPIDateConverter;

namespace product.Model
{
    /// <summary>
    /// ProductBulkUpdateRequestV2
    /// </summary>
    [DataContract(Name = "productBulkUpdateRequestV2")]
    public partial class ProductBulkUpdateRequestV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBulkUpdateRequestV2" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="productIds">productIds.</param>
        /// <param name="payload">payload.</param>
        public ProductBulkUpdateRequestV2(string tenantId = default(string), List<string> productIds = default(List<string>), ProductBulkUpdateRequestV2Payload payload = default(ProductBulkUpdateRequestV2Payload))
        {
            this.TenantId = tenantId;
            this.ProductIds = productIds;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ProductIds
        /// </summary>
        [DataMember(Name = "productIds", EmitDefaultValue = false)]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public ProductBulkUpdateRequestV2Payload Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductBulkUpdateRequestV2 {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ProductIds: ").Append(ProductIds).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
