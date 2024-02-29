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
    /// EntitymanagerUpdateAttributeOptionsResponse
    /// </summary>
    [DataContract(Name = "entitymanagerUpdateAttributeOptionsResponse")]
    public partial class EntitymanagerUpdateAttributeOptionsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitymanagerUpdateAttributeOptionsResponse" /> class.
        /// </summary>
        /// <param name="options">options.</param>
        /// <param name="errors">errors.</param>
        public EntitymanagerUpdateAttributeOptionsResponse(List<EntitymanagerAttributeOption> options = default(List<EntitymanagerAttributeOption>), List<EntitymanagerAttributeOptionErrors> errors = default(List<EntitymanagerAttributeOptionErrors>))
        {
            this.Options = options;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<EntitymanagerAttributeOption> Options { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<EntitymanagerAttributeOptionErrors> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntitymanagerUpdateAttributeOptionsResponse {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
