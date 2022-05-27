/*
 * epgstation
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.6.20
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
using OpenAPIDateConverter = X68fpjc.Jellyfin.EPGStation.OpenAPI.Client.OpenAPIDateConverter;

namespace X68fpjc.Jellyfin.EPGStation.OpenAPI.Model
{
    /// <summary>
    /// 録画タグ追加プション
    /// </summary>
    [DataContract(Name = "AddRecordedTagOption")]
    public partial class AddRecordedTagOption : IEquatable<AddRecordedTagOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRecordedTagOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddRecordedTagOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRecordedTagOption" /> class.
        /// </summary>
        /// <param name="name">タグ名 (required).</param>
        /// <param name="color">色 (required).</param>
        public AddRecordedTagOption(string name = default(string), string color = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddRecordedTagOption and cannot be null");
            }
            this.Name = name;
            // to ensure "color" is required (not null)
            if (color == null)
            {
                throw new ArgumentNullException("color is a required property for AddRecordedTagOption and cannot be null");
            }
            this.Color = color;
        }

        /// <summary>
        /// タグ名
        /// </summary>
        /// <value>タグ名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 色
        /// </summary>
        /// <value>色</value>
        [DataMember(Name = "color", IsRequired = true, EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddRecordedTagOption {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRecordedTagOption);
        }

        /// <summary>
        /// Returns true if AddRecordedTagOption instances are equal
        /// </summary>
        /// <param name="input">Instance of AddRecordedTagOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddRecordedTagOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
