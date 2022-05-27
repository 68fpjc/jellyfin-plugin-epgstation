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
    /// RuleKeywordItem
    /// </summary>
    [DataContract(Name = "RuleKeywordItem")]
    public partial class RuleKeywordItem : IEquatable<RuleKeywordItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleKeywordItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleKeywordItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleKeywordItem" /> class.
        /// </summary>
        /// <param name="id">ルール id (required).</param>
        /// <param name="keyword">keyword (required).</param>
        public RuleKeywordItem(int id = default(int), string keyword = default(string))
        {
            this.Id = id;
            // to ensure "keyword" is required (not null)
            if (keyword == null)
            {
                throw new ArgumentNullException("keyword is a required property for RuleKeywordItem and cannot be null");
            }
            this.Keyword = keyword;
        }

        /// <summary>
        /// ルール id
        /// </summary>
        /// <value>ルール id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name = "keyword", IsRequired = true, EmitDefaultValue = false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleKeywordItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
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
            return this.Equals(input as RuleKeywordItem);
        }

        /// <summary>
        /// Returns true if RuleKeywordItem instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleKeywordItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleKeywordItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Keyword != null)
                {
                    hashCode = (hashCode * 59) + this.Keyword.GetHashCode();
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
