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
    /// ProductProductEntity
    /// </summary>
    [DataContract(Name = "productProductEntity")]
    public partial class ProductProductEntity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductProductEntity" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="entityCode">entityCode.</param>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="variantAttributes">variantAttributes.</param>
        /// <param name="isConfigurable">isConfigurable.</param>
        /// <param name="isVirtual">isVirtual.</param>
        /// <param name="isGiftcard">isGiftcard.</param>
        /// <param name="hasConfigurator">hasConfigurator.</param>
        /// <param name="urlKey">urlKey.</param>
        /// <param name="mediaVariantAttributes">mediaVariantAttributes.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="variants">variants.</param>
        /// <param name="mediaGallery">mediaGallery.</param>
        /// <param name="maxSaleableQuantity">maxSaleableQuantity.</param>
        /// <param name="assets">assets.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public ProductProductEntity(string tenantId = default(string), string entityType = default(string), string entityCode = default(string), string id = default(string), string code = default(string), List<string> variantAttributes = default(List<string>), bool isConfigurable = default(bool), bool isVirtual = default(bool), bool isGiftcard = default(bool), bool hasConfigurator = default(bool), ProductLocalizedText urlKey = default(ProductLocalizedText), List<string> mediaVariantAttributes = default(List<string>), Dictionary<string, ProtobufAny> attributes = default(Dictionary<string, ProtobufAny>), Dictionary<string, ProductProductVariant> variants = default(Dictionary<string, ProductProductVariant>), ProductMediaGallery mediaGallery = default(ProductMediaGallery), long maxSaleableQuantity = default(long), ProductAssets assets = default(ProductAssets), string createdAt = default(string), string updatedAt = default(string))
        {
            this.TenantId = tenantId;
            this.EntityType = entityType;
            this.EntityCode = entityCode;
            this.Id = id;
            this.Code = code;
            this.VariantAttributes = variantAttributes;
            this.IsConfigurable = isConfigurable;
            this.IsVirtual = isVirtual;
            this.IsGiftcard = isGiftcard;
            this.HasConfigurator = hasConfigurator;
            this.UrlKey = urlKey;
            this.MediaVariantAttributes = mediaVariantAttributes;
            this.Attributes = attributes;
            this.Variants = variants;
            this.MediaGallery = mediaGallery;
            this.MaxSaleableQuantity = maxSaleableQuantity;
            this.Assets = assets;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Grn
        /// </summary>
        [DataMember(Name = "grn", EmitDefaultValue = false)]
        public string Grn { get; private set; }

        /// <summary>
        /// Returns false as Grn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGrn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets EntityCode
        /// </summary>
        [DataMember(Name = "entityCode", EmitDefaultValue = false)]
        public string EntityCode { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets VariantAttributes
        /// </summary>
        [DataMember(Name = "variantAttributes", EmitDefaultValue = false)]
        public List<string> VariantAttributes { get; set; }

        /// <summary>
        /// Gets or Sets IsConfigurable
        /// </summary>
        [DataMember(Name = "isConfigurable", EmitDefaultValue = true)]
        public bool IsConfigurable { get; set; }

        /// <summary>
        /// Gets or Sets IsVirtual
        /// </summary>
        [DataMember(Name = "isVirtual", EmitDefaultValue = true)]
        public bool IsVirtual { get; set; }

        /// <summary>
        /// Gets or Sets IsGiftcard
        /// </summary>
        [DataMember(Name = "isGiftcard", EmitDefaultValue = true)]
        public bool IsGiftcard { get; set; }

        /// <summary>
        /// Gets or Sets HasConfigurator
        /// </summary>
        [DataMember(Name = "hasConfigurator", EmitDefaultValue = true)]
        public bool HasConfigurator { get; set; }

        /// <summary>
        /// Gets or Sets UrlKey
        /// </summary>
        [DataMember(Name = "urlKey", EmitDefaultValue = false)]
        public ProductLocalizedText UrlKey { get; set; }

        /// <summary>
        /// Gets or Sets MediaVariantAttributes
        /// </summary>
        [DataMember(Name = "mediaVariantAttributes", EmitDefaultValue = false)]
        public List<string> MediaVariantAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, ProtobufAny> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        public Dictionary<string, ProductProductVariant> Variants { get; set; }

        /// <summary>
        /// Gets or Sets MediaGallery
        /// </summary>
        [DataMember(Name = "mediaGallery", EmitDefaultValue = false)]
        public ProductMediaGallery MediaGallery { get; set; }

        /// <summary>
        /// Gets or Sets MaxSaleableQuantity
        /// </summary>
        [DataMember(Name = "maxSaleableQuantity", EmitDefaultValue = false)]
        public long MaxSaleableQuantity { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public ProductAssets Assets { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductProductEntity {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Grn: ").Append(Grn).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntityCode: ").Append(EntityCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  VariantAttributes: ").Append(VariantAttributes).Append("\n");
            sb.Append("  IsConfigurable: ").Append(IsConfigurable).Append("\n");
            sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
            sb.Append("  IsGiftcard: ").Append(IsGiftcard).Append("\n");
            sb.Append("  HasConfigurator: ").Append(HasConfigurator).Append("\n");
            sb.Append("  UrlKey: ").Append(UrlKey).Append("\n");
            sb.Append("  MediaVariantAttributes: ").Append(MediaVariantAttributes).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("  MediaGallery: ").Append(MediaGallery).Append("\n");
            sb.Append("  MaxSaleableQuantity: ").Append(MaxSaleableQuantity).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
