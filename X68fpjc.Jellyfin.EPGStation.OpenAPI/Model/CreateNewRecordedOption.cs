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
    /// 新規追加する録画番組情報
    /// </summary>
    [DataContract(Name = "CreateNewRecordedOption")]
    public partial class CreateNewRecordedOption : IEquatable<CreateNewRecordedOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewRecordedOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateNewRecordedOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewRecordedOption" /> class.
        /// </summary>
        /// <param name="ruleId">ルール id.</param>
        /// <param name="channelId">放送局 id (required).</param>
        /// <param name="startAt">時刻 (ms) (required).</param>
        /// <param name="endAt">時刻 (ms) (required).</param>
        /// <param name="name">番組名 (required).</param>
        /// <param name="description">番組詳細.</param>
        /// <param name="extended">番組拡張.</param>
        /// <param name="genre1">ジャンル.</param>
        /// <param name="subGenre1">サブジャンル.</param>
        /// <param name="genre2">ジャンル.</param>
        /// <param name="subGenre2">サブジャンル.</param>
        /// <param name="genre3">ジャンル.</param>
        /// <param name="subGenre3">サブジャンル.</param>
        public CreateNewRecordedOption(int ruleId = default(int), long channelId = default(long), long startAt = default(long), long endAt = default(long), string name = default(string), string description = default(string), string extended = default(string), int genre1 = default(int), int subGenre1 = default(int), int genre2 = default(int), int subGenre2 = default(int), int genre3 = default(int), int subGenre3 = default(int))
        {
            this.ChannelId = channelId;
            this.StartAt = startAt;
            this.EndAt = endAt;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateNewRecordedOption and cannot be null");
            }
            this.Name = name;
            this.RuleId = ruleId;
            this.Description = description;
            this.Extended = extended;
            this.Genre1 = genre1;
            this.SubGenre1 = subGenre1;
            this.Genre2 = genre2;
            this.SubGenre2 = subGenre2;
            this.Genre3 = genre3;
            this.SubGenre3 = subGenre3;
        }

        /// <summary>
        /// ルール id
        /// </summary>
        /// <value>ルール id</value>
        [DataMember(Name = "ruleId", EmitDefaultValue = false)]
        public int RuleId { get; set; }

        /// <summary>
        /// 放送局 id
        /// </summary>
        /// <value>放送局 id</value>
        [DataMember(Name = "channelId", IsRequired = true, EmitDefaultValue = false)]
        public long ChannelId { get; set; }

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
        /// 番組名
        /// </summary>
        /// <value>番組名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 番組詳細
        /// </summary>
        /// <value>番組詳細</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 番組拡張
        /// </summary>
        /// <value>番組拡張</value>
        [DataMember(Name = "extended", EmitDefaultValue = false)]
        public string Extended { get; set; }

        /// <summary>
        /// ジャンル
        /// </summary>
        /// <value>ジャンル</value>
        [DataMember(Name = "genre1", EmitDefaultValue = false)]
        public int Genre1 { get; set; }

        /// <summary>
        /// サブジャンル
        /// </summary>
        /// <value>サブジャンル</value>
        [DataMember(Name = "subGenre1", EmitDefaultValue = false)]
        public int SubGenre1 { get; set; }

        /// <summary>
        /// ジャンル
        /// </summary>
        /// <value>ジャンル</value>
        [DataMember(Name = "genre2", EmitDefaultValue = false)]
        public int Genre2 { get; set; }

        /// <summary>
        /// サブジャンル
        /// </summary>
        /// <value>サブジャンル</value>
        [DataMember(Name = "subGenre2", EmitDefaultValue = false)]
        public int SubGenre2 { get; set; }

        /// <summary>
        /// ジャンル
        /// </summary>
        /// <value>ジャンル</value>
        [DataMember(Name = "genre3", EmitDefaultValue = false)]
        public int Genre3 { get; set; }

        /// <summary>
        /// サブジャンル
        /// </summary>
        /// <value>サブジャンル</value>
        [DataMember(Name = "subGenre3", EmitDefaultValue = false)]
        public int SubGenre3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateNewRecordedOption {\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  Genre1: ").Append(Genre1).Append("\n");
            sb.Append("  SubGenre1: ").Append(SubGenre1).Append("\n");
            sb.Append("  Genre2: ").Append(Genre2).Append("\n");
            sb.Append("  SubGenre2: ").Append(SubGenre2).Append("\n");
            sb.Append("  Genre3: ").Append(Genre3).Append("\n");
            sb.Append("  SubGenre3: ").Append(SubGenre3).Append("\n");
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
            return this.Equals(input as CreateNewRecordedOption);
        }

        /// <summary>
        /// Returns true if CreateNewRecordedOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNewRecordedOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNewRecordedOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RuleId == input.RuleId ||
                    this.RuleId.Equals(input.RuleId)
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    this.ChannelId.Equals(input.ChannelId)
                ) && 
                (
                    this.StartAt == input.StartAt ||
                    this.StartAt.Equals(input.StartAt)
                ) && 
                (
                    this.EndAt == input.EndAt ||
                    this.EndAt.Equals(input.EndAt)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Extended == input.Extended ||
                    (this.Extended != null &&
                    this.Extended.Equals(input.Extended))
                ) && 
                (
                    this.Genre1 == input.Genre1 ||
                    this.Genre1.Equals(input.Genre1)
                ) && 
                (
                    this.SubGenre1 == input.SubGenre1 ||
                    this.SubGenre1.Equals(input.SubGenre1)
                ) && 
                (
                    this.Genre2 == input.Genre2 ||
                    this.Genre2.Equals(input.Genre2)
                ) && 
                (
                    this.SubGenre2 == input.SubGenre2 ||
                    this.SubGenre2.Equals(input.SubGenre2)
                ) && 
                (
                    this.Genre3 == input.Genre3 ||
                    this.Genre3.Equals(input.Genre3)
                ) && 
                (
                    this.SubGenre3 == input.SubGenre3 ||
                    this.SubGenre3.Equals(input.SubGenre3)
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
                hashCode = (hashCode * 59) + this.RuleId.GetHashCode();
                hashCode = (hashCode * 59) + this.ChannelId.GetHashCode();
                hashCode = (hashCode * 59) + this.StartAt.GetHashCode();
                hashCode = (hashCode * 59) + this.EndAt.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Extended != null)
                {
                    hashCode = (hashCode * 59) + this.Extended.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Genre1.GetHashCode();
                hashCode = (hashCode * 59) + this.SubGenre1.GetHashCode();
                hashCode = (hashCode * 59) + this.Genre2.GetHashCode();
                hashCode = (hashCode * 59) + this.SubGenre2.GetHashCode();
                hashCode = (hashCode * 59) + this.Genre3.GetHashCode();
                hashCode = (hashCode * 59) + this.SubGenre3.GetHashCode();
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
            // ChannelId (long) maximum
            if (this.ChannelId > (long)6553565535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelId, must be a value less than or equal to 6553565535.", new [] { "ChannelId" });
            }

            yield break;
        }
    }

}
