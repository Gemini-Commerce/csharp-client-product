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
    /// EntitymanagerAttributeOption
    /// </summary>
    [DataContract(Name = "entitymanagerAttributeOption")]
    public partial class EntitymanagerAttributeOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitymanagerAttributeOption" /> class.
        /// </summary>
        /// <param name="option">option.</param>
        /// <param name="sort">sort.</param>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="value">value.</param>
        /// <param name="swatches">swatches.</param>
        public EntitymanagerAttributeOption(Dictionary<string, string> option = default(Dictionary<string, string>), long sort = default(long), string id = default(string), string code = default(string), ProductentitymanagerLocalizedText value = default(ProductentitymanagerLocalizedText), List<EntitymanagerAttributeOptionSwatch> swatches = default(List<EntitymanagerAttributeOptionSwatch>))
        {
            this.Option = option;
            this.Sort = sort;
            this.Id = id;
            this.Code = code;
            this.Value = value;
            this.Swatches = swatches;
        }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name = "option", EmitDefaultValue = false)]
        public Dictionary<string, string> Option { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public long Sort { get; set; }

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
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public ProductentitymanagerLocalizedText Value { get; set; }

        /// <summary>
        /// Gets or Sets Swatches
        /// </summary>
        [DataMember(Name = "swatches", EmitDefaultValue = false)]
        public List<EntitymanagerAttributeOptionSwatch> Swatches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntitymanagerAttributeOption {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Swatches: ").Append(Swatches).Append("\n");
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
