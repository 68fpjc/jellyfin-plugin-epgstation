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
    /// ルール情報
    /// </summary>
    [DataContract(Name = "Rules")]
    public partial class Rules : IEquatable<Rules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rules" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rules() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rules" /> class.
        /// </summary>
        /// <param name="rules">rules (required).</param>
        /// <param name="total">ルール総件数 (required).</param>
        public Rules(List<Rule> rules = default(List<Rule>), int total = default(int))
        {
            // to ensure "rules" is required (not null)
            if (rules == null)
            {
                throw new ArgumentNullException("rules is a required property for Rules and cannot be null");
            }
            this._Rules = rules;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets _Rules
        /// </summary>
        [DataMember(Name = "rules", IsRequired = true, EmitDefaultValue = false)]
        public List<Rule> _Rules { get; set; }

        /// <summary>
        /// ルール総件数
        /// </summary>
        /// <value>ルール総件数</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Rules {\n");
            sb.Append("  _Rules: ").Append(_Rules).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as Rules);
        }

        /// <summary>
        /// Returns true if Rules instances are equal
        /// </summary>
        /// <param name="input">Instance of Rules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rules input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Rules == input._Rules ||
                    this._Rules != null &&
                    input._Rules != null &&
                    this._Rules.SequenceEqual(input._Rules)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this._Rules != null)
                {
                    hashCode = (hashCode * 59) + this._Rules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
