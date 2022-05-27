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
    /// エンコードプログラム情報
    /// </summary>
    [DataContract(Name = "EncodeProgramItem")]
    public partial class EncodeProgramItem : IEquatable<EncodeProgramItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeProgramItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncodeProgramItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeProgramItem" /> class.
        /// </summary>
        /// <param name="id">エンコード id (required).</param>
        /// <param name="mode">エンコード名 (required).</param>
        /// <param name="recorded">recorded (required).</param>
        /// <param name="percent">進捗.</param>
        /// <param name="log">ログ.</param>
        public EncodeProgramItem(int id = default(int), string mode = default(string), RecordedItem recorded = default(RecordedItem), decimal percent = default(decimal), string log = default(string))
        {
            this.Id = id;
            // to ensure "mode" is required (not null)
            if (mode == null)
            {
                throw new ArgumentNullException("mode is a required property for EncodeProgramItem and cannot be null");
            }
            this.Mode = mode;
            // to ensure "recorded" is required (not null)
            if (recorded == null)
            {
                throw new ArgumentNullException("recorded is a required property for EncodeProgramItem and cannot be null");
            }
            this.Recorded = recorded;
            this.Percent = percent;
            this.Log = log;
        }

        /// <summary>
        /// エンコード id
        /// </summary>
        /// <value>エンコード id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// エンコード名
        /// </summary>
        /// <value>エンコード名</value>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Recorded
        /// </summary>
        [DataMember(Name = "recorded", IsRequired = true, EmitDefaultValue = false)]
        public RecordedItem Recorded { get; set; }

        /// <summary>
        /// 進捗
        /// </summary>
        /// <value>進捗</value>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal Percent { get; set; }

        /// <summary>
        /// ログ
        /// </summary>
        /// <value>ログ</value>
        [DataMember(Name = "log", EmitDefaultValue = false)]
        public string Log { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncodeProgramItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Recorded: ").Append(Recorded).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
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
            return this.Equals(input as EncodeProgramItem);
        }

        /// <summary>
        /// Returns true if EncodeProgramItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EncodeProgramItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncodeProgramItem input)
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
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Recorded == input.Recorded ||
                    (this.Recorded != null &&
                    this.Recorded.Equals(input.Recorded))
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.Log == input.Log ||
                    (this.Log != null &&
                    this.Log.Equals(input.Log))
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
                if (this.Mode != null)
                {
                    hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                }
                if (this.Recorded != null)
                {
                    hashCode = (hashCode * 59) + this.Recorded.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percent.GetHashCode();
                if (this.Log != null)
                {
                    hashCode = (hashCode * 59) + this.Log.GetHashCode();
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