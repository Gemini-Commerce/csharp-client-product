/*
 * Product Service
 *
 * Introducing our revolutionary Product Management Service! Designed to streamline your product inventory and elevate customer experiences, our cutting-edge protobuf service is a game-changer in the world of efficient product management.  With our service, you can effortlessly create new products, allowing you to quickly bring your ideas to life and expand your catalog. Retrieve product information in a snap, providing accurate and personalized details to your customers based on their specific needs and preferences.  Stay ahead of the competition by easily updating product information, ensuring your catalog is always up-to-date and optimized. Seamlessly remove products from your inventory when needed, maintaining a clean and relevant product selection.  Enhance the visual appeal of your products with our advanced media gallery functionalities. Effortlessly add and update captivating images and videos to showcase your products in the best possible light, engaging your customers and driving conversions.  Personalization is key in today's market, and our service enables you to offer unique options to your customers. Easily create and manage lists of customizable options for your products, providing flexibility and tailoring to individual preferences.  Attributes play a vital role in defining products, and our service empowers you to effectively manage them. From bulk attribute creation to listing and retrieving attribute options, our service ensures your product information is rich and comprehensive.  Our service extends its capabilities to entity management, allowing you to effortlessly handle different entities and create customized options lists associated with them. This provides further flexibility and customization options for your product offerings.  When it comes to bulk updates, our service has you covered. Effortlessly update multiple products simultaneously, saving you time and streamlining your operations.  Finding specific products and variants is a breeze with our service. Quickly locate products based on their unique stock keeping unit (SKU) values, ensuring efficient inventory management and smooth order fulfillment.  Experience a new level of efficiency and productivity with our Product Management Service. Unlock the full potential of streamlined product management and empower your business to thrive in today's competitive market. Try our service today and elevate your product management to new heights!
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
    /// ProductCreateProductRequestV2
    /// </summary>
    [DataContract(Name = "productCreateProductRequestV2")]
    public partial class ProductCreateProductRequestV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCreateProductRequestV2" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="entityCode">entityCode.</param>
        /// <param name="code">code.</param>
        /// <param name="isConfigurable">isConfigurable.</param>
        /// <param name="variantAttributes">variantAttributes.</param>
        /// <param name="isVirtual">isVirtual.</param>
        /// <param name="isGiftcard">isGiftcard.</param>
        /// <param name="hasConfigurator">hasConfigurator.</param>
        /// <param name="urlKey">urlKey.</param>
        /// <param name="maxSaleableQuantity">maxSaleableQuantity.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="variants">variants.</param>
        /// <param name="mediaVariantAttributes">mediaVariantAttributes.</param>
        public ProductCreateProductRequestV2(string tenantId = default(string), string entityType = default(string), string entityCode = default(string), string code = default(string), bool isConfigurable = default(bool), List<string> variantAttributes = default(List<string>), bool isVirtual = default(bool), bool isGiftcard = default(bool), bool hasConfigurator = default(bool), ProductLocalizedText urlKey = default(ProductLocalizedText), long maxSaleableQuantity = default(long), Dictionary<string, ProtobufAny> attributes = default(Dictionary<string, ProtobufAny>), Dictionary<string, ProductProductVariant> variants = default(Dictionary<string, ProductProductVariant>), List<string> mediaVariantAttributes = default(List<string>))
        {
            this.TenantId = tenantId;
            this.EntityType = entityType;
            this.EntityCode = entityCode;
            this.Code = code;
            this.IsConfigurable = isConfigurable;
            this.VariantAttributes = variantAttributes;
            this.IsVirtual = isVirtual;
            this.IsGiftcard = isGiftcard;
            this.HasConfigurator = hasConfigurator;
            this.UrlKey = urlKey;
            this.MaxSaleableQuantity = maxSaleableQuantity;
            this.Attributes = attributes;
            this.Variants = variants;
            this.MediaVariantAttributes = mediaVariantAttributes;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

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
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets IsConfigurable
        /// </summary>
        [DataMember(Name = "isConfigurable", EmitDefaultValue = true)]
        public bool IsConfigurable { get; set; }

        /// <summary>
        /// Gets or Sets VariantAttributes
        /// </summary>
        [DataMember(Name = "variantAttributes", EmitDefaultValue = false)]
        public List<string> VariantAttributes { get; set; }

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
        /// Gets or Sets MaxSaleableQuantity
        /// </summary>
        [DataMember(Name = "maxSaleableQuantity", EmitDefaultValue = false)]
        public long MaxSaleableQuantity { get; set; }

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
        /// Gets or Sets MediaVariantAttributes
        /// </summary>
        [DataMember(Name = "mediaVariantAttributes", EmitDefaultValue = false)]
        public List<string> MediaVariantAttributes { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductCreateProductRequestV2 {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntityCode: ").Append(EntityCode).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IsConfigurable: ").Append(IsConfigurable).Append("\n");
            sb.Append("  VariantAttributes: ").Append(VariantAttributes).Append("\n");
            sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
            sb.Append("  IsGiftcard: ").Append(IsGiftcard).Append("\n");
            sb.Append("  HasConfigurator: ").Append(HasConfigurator).Append("\n");
            sb.Append("  UrlKey: ").Append(UrlKey).Append("\n");
            sb.Append("  MaxSaleableQuantity: ").Append(MaxSaleableQuantity).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("  MediaVariantAttributes: ").Append(MediaVariantAttributes).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
