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
    /// ルール予約オプション
    /// </summary>
    [DataContract(Name = "RuleReserveOption")]
    public partial class RuleReserveOption : IEquatable<RuleReserveOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleReserveOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleReserveOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleReserveOption" /> class.
        /// </summary>
        /// <param name="enable">ルールが有効か (required).</param>
        /// <param name="allowEndLack">末尾切れを許可するか (required).</param>
        /// <param name="avoidDuplicate">録画済みの重複番組を排除するか (required).</param>
        /// <param name="periodToAvoidDuplicate">重複を避ける期間.</param>
        /// <param name="tags">tags.</param>
        public RuleReserveOption(bool enable = default(bool), bool allowEndLack = default(bool), bool avoidDuplicate = default(bool), int periodToAvoidDuplicate = default(int), List<int> tags = default(List<int>))
        {
            this.Enable = enable;
            this.AllowEndLack = allowEndLack;
            this.AvoidDuplicate = avoidDuplicate;
            this.PeriodToAvoidDuplicate = periodToAvoidDuplicate;
            this.Tags = tags;
        }

        /// <summary>
        /// ルールが有効か
        /// </summary>
        /// <value>ルールが有効か</value>
        [DataMember(Name = "enable", IsRequired = true, EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// 末尾切れを許可するか
        /// </summary>
        /// <value>末尾切れを許可するか</value>
        [DataMember(Name = "allowEndLack", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowEndLack { get; set; }

        /// <summary>
        /// 録画済みの重複番組を排除するか
        /// </summary>
        /// <value>録画済みの重複番組を排除するか</value>
        [DataMember(Name = "avoidDuplicate", IsRequired = true, EmitDefaultValue = true)]
        public bool AvoidDuplicate { get; set; }

        /// <summary>
        /// 重複を避ける期間
        /// </summary>
        /// <value>重複を避ける期間</value>
        [DataMember(Name = "periodToAvoidDuplicate", EmitDefaultValue = false)]
        public int PeriodToAvoidDuplicate { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleReserveOption {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  AllowEndLack: ").Append(AllowEndLack).Append("\n");
            sb.Append("  AvoidDuplicate: ").Append(AvoidDuplicate).Append("\n");
            sb.Append("  PeriodToAvoidDuplicate: ").Append(PeriodToAvoidDuplicate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as RuleReserveOption);
        }

        /// <summary>
        /// Returns true if RuleReserveOption instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleReserveOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleReserveOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.AllowEndLack == input.AllowEndLack ||
                    this.AllowEndLack.Equals(input.AllowEndLack)
                ) && 
                (
                    this.AvoidDuplicate == input.AvoidDuplicate ||
                    this.AvoidDuplicate.Equals(input.AvoidDuplicate)
                ) && 
                (
                    this.PeriodToAvoidDuplicate == input.PeriodToAvoidDuplicate ||
                    this.PeriodToAvoidDuplicate.Equals(input.PeriodToAvoidDuplicate)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowEndLack.GetHashCode();
                hashCode = (hashCode * 59) + this.AvoidDuplicate.GetHashCode();
                hashCode = (hashCode * 59) + this.PeriodToAvoidDuplicate.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
