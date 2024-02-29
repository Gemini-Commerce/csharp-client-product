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
    /// EntitymanagerListEntitiesResponse
    /// </summary>
    [DataContract(Name = "entitymanagerListEntitiesResponse")]
    public partial class EntitymanagerListEntitiesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitymanagerListEntitiesResponse" /> class.
        /// </summary>
        /// <param name="entities">entities.</param>
        /// <param name="nextPage">nextPage.</param>
        public EntitymanagerListEntitiesResponse(List<EntitymanagerEntity> entities = default(List<EntitymanagerEntity>), int nextPage = default(int))
        {
            this.Entities = entities;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public List<EntitymanagerEntity> Entities { get; set; }

        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name = "nextPage", EmitDefaultValue = false)]
        public int NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntitymanagerListEntitiesResponse {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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