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
    /// 手動予約オプション
    /// </summary>
    [DataContract(Name = "ManualReserveOption")]
    public partial class ManualReserveOption : IEquatable<ManualReserveOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualReserveOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManualReserveOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualReserveOption" /> class.
        /// </summary>
        /// <param name="programId">program id.</param>
        /// <param name="timeSpecifiedOption">時刻指定オプション.</param>
        /// <param name="allowEndLack">末尾切れを許すか (required).</param>
        /// <param name="tags">tags.</param>
        /// <param name="saveOption">saveOption.</param>
        /// <param name="encodeOption">encodeOption.</param>
        public ManualReserveOption(long programId = default(long), Object timeSpecifiedOption = default(Object), bool allowEndLack = default(bool), List<int> tags = default(List<int>), ReserveSaveOption saveOption = default(ReserveSaveOption), ReserveEncodedOption encodeOption = default(ReserveEncodedOption))
        {
            this.AllowEndLack = allowEndLack;
            this.ProgramId = programId;
            this.TimeSpecifiedOption = timeSpecifiedOption;
            this.Tags = tags;
            this.SaveOption = saveOption;
            this.EncodeOption = encodeOption;
        }

        /// <summary>
        /// program id
        /// </summary>
        /// <value>program id</value>
        [DataMember(Name = "programId", EmitDefaultValue = false)]
        public long ProgramId { get; set; }

        /// <summary>
        /// 時刻指定オプション
        /// </summary>
        /// <value>時刻指定オプション</value>
        [DataMember(Name = "timeSpecifiedOption", EmitDefaultValue = false)]
        public Object TimeSpecifiedOption { get; set; }

        /// <summary>
        /// 末尾切れを許すか
        /// </summary>
        /// <value>末尾切れを許すか</value>
        [DataMember(Name = "allowEndLack", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowEndLack { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets SaveOption
        /// </summary>
        [DataMember(Name = "saveOption", EmitDefaultValue = false)]
        public ReserveSaveOption SaveOption { get; set; }

        /// <summary>
        /// Gets or Sets EncodeOption
        /// </summary>
        [DataMember(Name = "encodeOption", EmitDefaultValue = false)]
        public ReserveEncodedOption EncodeOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManualReserveOption {\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  TimeSpecifiedOption: ").Append(TimeSpecifiedOption).Append("\n");
            sb.Append("  AllowEndLack: ").Append(AllowEndLack).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  SaveOption: ").Append(SaveOption).Append("\n");
            sb.Append("  EncodeOption: ").Append(EncodeOption).Append("\n");
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
            return this.Equals(input as ManualReserveOption);
        }

        /// <summary>
        /// Returns true if ManualReserveOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualReserveOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualReserveOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProgramId == input.ProgramId ||
                    this.ProgramId.Equals(input.ProgramId)
                ) && 
                (
                    this.TimeSpecifiedOption == input.TimeSpecifiedOption ||
                    (this.TimeSpecifiedOption != null &&
                    this.TimeSpecifiedOption.Equals(input.TimeSpecifiedOption))
                ) && 
                (
                    this.AllowEndLack == input.AllowEndLack ||
                    this.AllowEndLack.Equals(input.AllowEndLack)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.SaveOption == input.SaveOption ||
                    (this.SaveOption != null &&
                    this.SaveOption.Equals(input.SaveOption))
                ) && 
                (
                    this.EncodeOption == input.EncodeOption ||
                    (this.EncodeOption != null &&
                    this.EncodeOption.Equals(input.EncodeOption))
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
                hashCode = (hashCode * 59) + this.ProgramId.GetHashCode();
                if (this.TimeSpecifiedOption != null)
                {
                    hashCode = (hashCode * 59) + this.TimeSpecifiedOption.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowEndLack.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.SaveOption != null)
                {
                    hashCode = (hashCode * 59) + this.SaveOption.GetHashCode();
                }
                if (this.EncodeOption != null)
                {
                    hashCode = (hashCode * 59) + this.EncodeOption.GetHashCode();
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
            // ProgramId (long) maximum
            if (this.ProgramId > (long)655356553565535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramId, must be a value less than or equal to 655356553565535.", new [] { "ProgramId" });
            }

            yield break;
        }
    }

}