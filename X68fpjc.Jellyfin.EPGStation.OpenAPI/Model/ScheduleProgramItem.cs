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
    /// 番組表の番組データ
    /// </summary>
    [DataContract(Name = "ScheduleProgramItem")]
    public partial class ScheduleProgramItem : IEquatable<ScheduleProgramItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VideoType
        /// </summary>
        [DataMember(Name = "videoType", EmitDefaultValue = false)]
        public ProgramVideoType? VideoType { get; set; }

        /// <summary>
        /// Gets or Sets VideoResolution
        /// </summary>
        [DataMember(Name = "videoResolution", EmitDefaultValue = false)]
        public ProgramVideoResolution? VideoResolution { get; set; }

        /// <summary>
        /// Gets or Sets AudioSamplingRate
        /// </summary>
        [DataMember(Name = "audioSamplingRate", EmitDefaultValue = false)]
        public ProgramAudioSamplingRate? AudioSamplingRate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleProgramItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleProgramItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleProgramItem" /> class.
        /// </summary>
        /// <param name="id">program id (required).</param>
        /// <param name="channelId">放送局 id (required).</param>
        /// <param name="startAt">時刻 (ms) (required).</param>
        /// <param name="endAt">時刻 (ms) (required).</param>
        /// <param name="isFree">無料放送か (required).</param>
        /// <param name="name">番組名 (required).</param>
        /// <param name="description">番組詳細.</param>
        /// <param name="extended">番組拡張.</param>
        /// <param name="rawExtended">番組拡張 (Mirakurun の extended).</param>
        /// <param name="genre1">ジャンル.</param>
        /// <param name="subGenre1">サブジャンル.</param>
        /// <param name="genre2">ジャンル.</param>
        /// <param name="subGenre2">サブジャンル.</param>
        /// <param name="genre3">ジャンル.</param>
        /// <param name="subGenre3">サブジャンル.</param>
        /// <param name="videoType">videoType.</param>
        /// <param name="videoResolution">videoResolution.</param>
        /// <param name="videoStreamContent">videoStreamContent.</param>
        /// <param name="videoComponentType">videoComponentType.</param>
        /// <param name="audioSamplingRate">audioSamplingRate.</param>
        /// <param name="audioComponentType">audioComponentType.</param>
        public ScheduleProgramItem(long id = default(long), long channelId = default(long), long startAt = default(long), long endAt = default(long), bool isFree = default(bool), string name = default(string), string description = default(string), string extended = default(string), Object rawExtended = default(Object), int genre1 = default(int), int subGenre1 = default(int), int genre2 = default(int), int subGenre2 = default(int), int genre3 = default(int), int subGenre3 = default(int), ProgramVideoType? videoType = default(ProgramVideoType?), ProgramVideoResolution? videoResolution = default(ProgramVideoResolution?), int videoStreamContent = default(int), int videoComponentType = default(int), ProgramAudioSamplingRate? audioSamplingRate = default(ProgramAudioSamplingRate?), int audioComponentType = default(int))
        {
            this.Id = id;
            this.ChannelId = channelId;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.IsFree = isFree;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ScheduleProgramItem and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.Extended = extended;
            this.RawExtended = rawExtended;
            this.Genre1 = genre1;
            this.SubGenre1 = subGenre1;
            this.Genre2 = genre2;
            this.SubGenre2 = subGenre2;
            this.Genre3 = genre3;
            this.SubGenre3 = subGenre3;
            this.VideoType = videoType;
            this.VideoResolution = videoResolution;
            this.VideoStreamContent = videoStreamContent;
            this.VideoComponentType = videoComponentType;
            this.AudioSamplingRate = audioSamplingRate;
            this.AudioComponentType = audioComponentType;
        }

        /// <summary>
        /// program id
        /// </summary>
        /// <value>program id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public long Id { get; set; }

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
        /// 無料放送か
        /// </summary>
        /// <value>無料放送か</value>
        [DataMember(Name = "isFree", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFree { get; set; }

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
        /// 番組拡張 (Mirakurun の extended)
        /// </summary>
        /// <value>番組拡張 (Mirakurun の extended)</value>
        [DataMember(Name = "rawExtended", EmitDefaultValue = false)]
        public Object RawExtended { get; set; }

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
        /// Gets or Sets VideoStreamContent
        /// </summary>
        [DataMember(Name = "videoStreamContent", EmitDefaultValue = false)]
        public int VideoStreamContent { get; set; }

        /// <summary>
        /// Gets or Sets VideoComponentType
        /// </summary>
        [DataMember(Name = "videoComponentType", EmitDefaultValue = false)]
        public int VideoComponentType { get; set; }

        /// <summary>
        /// Gets or Sets AudioComponentType
        /// </summary>
        [DataMember(Name = "audioComponentType", EmitDefaultValue = false)]
        public int AudioComponentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleProgramItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  IsFree: ").Append(IsFree).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  RawExtended: ").Append(RawExtended).Append("\n");
            sb.Append("  Genre1: ").Append(Genre1).Append("\n");
            sb.Append("  SubGenre1: ").Append(SubGenre1).Append("\n");
            sb.Append("  Genre2: ").Append(Genre2).Append("\n");
            sb.Append("  SubGenre2: ").Append(SubGenre2).Append("\n");
            sb.Append("  Genre3: ").Append(Genre3).Append("\n");
            sb.Append("  SubGenre3: ").Append(SubGenre3).Append("\n");
            sb.Append("  VideoType: ").Append(VideoType).Append("\n");
            sb.Append("  VideoResolution: ").Append(VideoResolution).Append("\n");
            sb.Append("  VideoStreamContent: ").Append(VideoStreamContent).Append("\n");
            sb.Append("  VideoComponentType: ").Append(VideoComponentType).Append("\n");
            sb.Append("  AudioSamplingRate: ").Append(AudioSamplingRate).Append("\n");
            sb.Append("  AudioComponentType: ").Append(AudioComponentType).Append("\n");
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
            return this.Equals(input as ScheduleProgramItem);
        }

        /// <summary>
        /// Returns true if ScheduleProgramItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleProgramItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleProgramItem input)
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
                    this.IsFree == input.IsFree ||
                    this.IsFree.Equals(input.IsFree)
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
                    this.RawExtended == input.RawExtended ||
                    (this.RawExtended != null &&
                    this.RawExtended.Equals(input.RawExtended))
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
                ) && 
                (
                    this.VideoType == input.VideoType ||
                    this.VideoType.Equals(input.VideoType)
                ) && 
                (
                    this.VideoResolution == input.VideoResolution ||
                    this.VideoResolution.Equals(input.VideoResolution)
                ) && 
                (
                    this.VideoStreamContent == input.VideoStreamContent ||
                    this.VideoStreamContent.Equals(input.VideoStreamContent)
                ) && 
                (
                    this.VideoComponentType == input.VideoComponentType ||
                    this.VideoComponentType.Equals(input.VideoComponentType)
                ) && 
                (
                    this.AudioSamplingRate == input.AudioSamplingRate ||
                    this.AudioSamplingRate.Equals(input.AudioSamplingRate)
                ) && 
                (
                    this.AudioComponentType == input.AudioComponentType ||
                    this.AudioComponentType.Equals(input.AudioComponentType)
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
                hashCode = (hashCode * 59) + this.ChannelId.GetHashCode();
                hashCode = (hashCode * 59) + this.StartAt.GetHashCode();
                hashCode = (hashCode * 59) + this.EndAt.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFree.GetHashCode();
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
                if (this.RawExtended != null)
                {
                    hashCode = (hashCode * 59) + this.RawExtended.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Genre1.GetHashCode();
                hashCode = (hashCode * 59) + this.SubGenre1.GetHashCode();
                hashCode = (hashCode * 59) + this.Genre2.GetHashCode();
                hashCode = (hashCode * 59) + this.SubGenre2.GetHashCode();
                hashCode = (hashCode * 59) + this.Genre3.GetHashCode();
                hashCode = (hashCode * 59) + this.SubGenre3.GetHashCode();
                hashCode = (hashCode * 59) + this.VideoType.GetHashCode();
                hashCode = (hashCode * 59) + this.VideoResolution.GetHashCode();
                hashCode = (hashCode * 59) + this.VideoStreamContent.GetHashCode();
                hashCode = (hashCode * 59) + this.VideoComponentType.GetHashCode();
                hashCode = (hashCode * 59) + this.AudioSamplingRate.GetHashCode();
                hashCode = (hashCode * 59) + this.AudioComponentType.GetHashCode();
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
            // Id (long) maximum
            if (this.Id > (long)655356553565535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value less than or equal to 655356553565535.", new [] { "Id" });
            }

            // ChannelId (long) maximum
            if (this.ChannelId > (long)6553565535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelId, must be a value less than or equal to 6553565535.", new [] { "ChannelId" });
            }

            yield break;
        }
    }

}