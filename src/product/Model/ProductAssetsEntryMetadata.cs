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
    /// ProductAssetsEntryMetadata
    /// </summary>
    [DataContract(Name = "productAssetsEntryMetadata")]
    public partial class ProductAssetsEntryMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAssetsEntryMetadata" /> class.
        /// </summary>
        /// <param name="roles">roles.</param>
        /// <param name="alt">alt.</param>
        public ProductAssetsEntryMetadata(List<string> roles = default(List<string>), ProductLocalizedText alt = default(ProductLocalizedText))
        {
            this.Roles = roles;
            this.Alt = alt;
        }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Alt
        /// </summary>
        [DataMember(Name = "alt", EmitDefaultValue = false)]
        public ProductLocalizedText Alt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAssetsEntryMetadata {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Alt: ").Append(Alt).Append("\n");
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