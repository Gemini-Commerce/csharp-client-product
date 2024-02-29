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
    /// EntitymanagerUpdateAttributeGroupRequestPayload
    /// </summary>
    [DataContract(Name = "entitymanagerUpdateAttributeGroupRequestPayload")]
    public partial class EntitymanagerUpdateAttributeGroupRequestPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitymanagerUpdateAttributeGroupRequestPayload" /> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="sort">sort.</param>
        /// <param name="visibility">visibility.</param>
        public EntitymanagerUpdateAttributeGroupRequestPayload(ProductentitymanagerLocalizedText label = default(ProductentitymanagerLocalizedText), int sort = default(int), List<string> visibility = default(List<string>))
        {
            this.Label = label;
            this.Sort = sort;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public ProductentitymanagerLocalizedText Label { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public int Sort { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public List<string> Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntitymanagerUpdateAttributeGroupRequestPayload {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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