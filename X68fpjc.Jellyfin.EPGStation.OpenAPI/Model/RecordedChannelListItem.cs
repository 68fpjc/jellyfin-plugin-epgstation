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
    /// recorded が持つ channelId のリスト
    /// </summary>
    [DataContract(Name = "RecordedChannelListItem")]
    public partial class RecordedChannelListItem : IEquatable<RecordedChannelListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordedChannelListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecordedChannelListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordedChannelListItem" /> class.
        /// </summary>
        /// <param name="cnt">録画数 (required).</param>
        /// <param name="channelId">放送局 id (required).</param>
        public RecordedChannelListItem(int cnt = default(int), long channelId = default(long))
        {
            this.Cnt = cnt;
            this.ChannelId = channelId;
        }

        /// <summary>
        /// 録画数
        /// </summary>
        /// <value>録画数</value>
        [DataMember(Name = "cnt", IsRequired = true, EmitDefaultValue = false)]
        public int Cnt { get; set; }

        /// <summary>
        /// 放送局 id
        /// </summary>
        /// <value>放送局 id</value>
        [DataMember(Name = "channelId", IsRequired = true, EmitDefaultValue = false)]
        public long ChannelId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordedChannelListItem {\n");
            sb.Append("  Cnt: ").Append(Cnt).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
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
            return this.Equals(input as RecordedChannelListItem);
        }

        /// <summary>
        /// Returns true if RecordedChannelListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordedChannelListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordedChannelListItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cnt == input.Cnt ||
                    this.Cnt.Equals(input.Cnt)
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    this.ChannelId.Equals(input.ChannelId)
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
                hashCode = (hashCode * 59) + this.Cnt.GetHashCode();
                hashCode = (hashCode * 59) + this.ChannelId.GetHashCode();
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
