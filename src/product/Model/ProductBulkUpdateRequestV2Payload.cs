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
    /// ProductBulkUpdateRequestV2Payload
    /// </summary>
    [DataContract(Name = "productBulkUpdateRequestV2Payload")]
    public partial class ProductBulkUpdateRequestV2Payload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBulkUpdateRequestV2Payload" /> class.
        /// </summary>
        /// <param name="updateMask">updateMask.</param>
        /// <param name="attributes">attributes.</param>
        public ProductBulkUpdateRequestV2Payload(ProductFieldMask updateMask = default(ProductFieldMask), Dictionary<string, ProtobufAny> attributes = default(Dictionary<string, ProtobufAny>))
        {
            this.UpdateMask = updateMask;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Gets or Sets UpdateMask
        /// </summary>
        [DataMember(Name = "updateMask", EmitDefaultValue = false)]
        public ProductFieldMask UpdateMask { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, ProtobufAny> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductBulkUpdateRequestV2Payload {\n");
            sb.Append("  UpdateMask: ").Append(UpdateMask).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
