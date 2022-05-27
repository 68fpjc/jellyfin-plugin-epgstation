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
    /// タグ追加成功応答データ
    /// </summary>
    [DataContract(Name = "AddedRecordedTag")]
    public partial class AddedRecordedTag : IEquatable<AddedRecordedTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedRecordedTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddedRecordedTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedRecordedTag" /> class.
        /// </summary>
        /// <param name="tagId">録画 tag id (required).</param>
        public AddedRecordedTag(int tagId = default(int))
        {
            this.TagId = tagId;
        }

        /// <summary>
        /// 録画 tag id
        /// </summary>
        /// <value>録画 tag id</value>
        [DataMember(Name = "tagId", IsRequired = true, EmitDefaultValue = false)]
        public int TagId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddedRecordedTag {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
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
            return this.Equals(input as AddedRecordedTag);
        }

        /// <summary>
        /// Returns true if AddedRecordedTag instances are equal
        /// </summary>
        /// <param name="input">Instance of AddedRecordedTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddedRecordedTag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TagId == input.TagId ||
                    this.TagId.Equals(input.TagId)
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
                hashCode = (hashCode * 59) + this.TagId.GetHashCode();
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