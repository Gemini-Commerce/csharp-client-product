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
    /// ProductAssetsEntry
    /// </summary>
    [DataContract(Name = "productAssetsEntry")]
    public partial class ProductAssetsEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAssetsEntry" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="assetGrn">assetGrn.</param>
        /// <param name="localizedAssetGrn">localizedAssetGrn.</param>
        /// <param name="locales">locales.</param>
        /// <param name="position">position.</param>
        /// <param name="metadata">metadata.</param>
        public ProductAssetsEntry(string id = default(string), string assetGrn = default(string), ProductLocalizedAsset localizedAssetGrn = default(ProductLocalizedAsset), List<string> locales = default(List<string>), long position = default(long), List<ProductAssetsEntryMetadata> metadata = default(List<ProductAssetsEntryMetadata>))
        {
            this.Id = id;
            this.AssetGrn = assetGrn;
            this.LocalizedAssetGrn = localizedAssetGrn;
            this.Locales = locales;
            this.Position = position;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetGrn
        /// </summary>
        [DataMember(Name = "assetGrn", EmitDefaultValue = false)]
        public string AssetGrn { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedAssetGrn
        /// </summary>
        [DataMember(Name = "localizedAssetGrn", EmitDefaultValue = false)]
        public ProductLocalizedAsset LocalizedAssetGrn { get; set; }

        /// <summary>
        /// Gets or Sets Locales
        /// </summary>
        [DataMember(Name = "locales", EmitDefaultValue = false)]
        public List<string> Locales { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public long Position { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<ProductAssetsEntryMetadata> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAssetsEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetGrn: ").Append(AssetGrn).Append("\n");
            sb.Append("  LocalizedAssetGrn: ").Append(LocalizedAssetGrn).Append("\n");
            sb.Append("  Locales: ").Append(Locales).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
