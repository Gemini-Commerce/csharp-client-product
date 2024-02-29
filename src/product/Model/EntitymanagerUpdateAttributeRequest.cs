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
    /// EntitymanagerUpdateAttributeRequest
    /// </summary>
    [DataContract(Name = "entitymanagerUpdateAttributeRequest")]
    public partial class EntitymanagerUpdateAttributeRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitymanagerUpdateAttributeRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="code">code.</param>
        /// <param name="entityData">entityData.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="payload">payload.</param>
        /// <param name="fieldMask">fieldMask.</param>
        public EntitymanagerUpdateAttributeRequest(string tenantId = default(string), string code = default(string), EntitymanagerEntityIdentifier entityData = default(EntitymanagerEntityIdentifier), string entityId = default(string), EntitymanagerUpdateAttributeRequestPayload payload = default(EntitymanagerUpdateAttributeRequestPayload), string fieldMask = default(string))
        {
            this.TenantId = tenantId;
            this.Code = code;
            this.EntityData = entityData;
            this.EntityId = entityId;
            this.Payload = payload;
            this.FieldMask = fieldMask;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets EntityData
        /// </summary>
        [DataMember(Name = "entityData", EmitDefaultValue = false)]
        public EntitymanagerEntityIdentifier EntityData { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public EntitymanagerUpdateAttributeRequestPayload Payload { get; set; }

        /// <summary>
        /// Gets or Sets FieldMask
        /// </summary>
        [DataMember(Name = "fieldMask", EmitDefaultValue = false)]
        public string FieldMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntitymanagerUpdateAttributeRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  EntityData: ").Append(EntityData).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  FieldMask: ").Append(FieldMask).Append("\n");
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
