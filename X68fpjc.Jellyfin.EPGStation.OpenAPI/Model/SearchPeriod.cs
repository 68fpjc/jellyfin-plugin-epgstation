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
    /// 検索対象期間オプション
    /// </summary>
    [DataContract(Name = "SearchPeriod")]
    public partial class SearchPeriod : IEquatable<SearchPeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchPeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPeriod" /> class.
        /// </summary>
        /// <param name="startAt">時刻 (ms) (required).</param>
        /// <param name="endAt">時刻 (ms) (required).</param>
        public SearchPeriod(long startAt = default(long), long endAt = default(long))
        {
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// 時刻 (ms)
        /// </summary>
        /// <value>時刻 (ms)</value>
        [DataMember(Name = "startAt", IsRequired = true, EmitDefaultValue = false)]
        public long StartAt { get; set; }

        /// <summary>
        /// 時刻 (ms)
        /// </summary>
        /// <value>時刻 (ms)</value>
        [DataMember(Name = "endAt", IsRequired = true, EmitDefaultValue = false)]
        public long EndAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchPeriod {\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
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
            return this.Equals(input as SearchPeriod);
        }

        /// <summary>
        /// Returns true if SearchPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchPeriod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartAt == input.StartAt ||
                    this.StartAt.Equals(input.StartAt)
                ) && 
                (
                    this.EndAt == input.EndAt ||
                    this.EndAt.Equals(input.EndAt)
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
                hashCode = (hashCode * 59) + this.StartAt.GetHashCode();
                hashCode = (hashCode * 59) + this.EndAt.GetHashCode();
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
