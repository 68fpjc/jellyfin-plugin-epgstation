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
    /// 録画済み TS ファイルのストリーミング設定
    /// </summary>
    [DataContract(Name = "Config_streamConfig_recorded_ts")]
    public partial class ConfigStreamConfigRecordedTs : IEquatable<ConfigStreamConfigRecordedTs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigStreamConfigRecordedTs" /> class.
        /// </summary>
        /// <param name="webm">録画済み TS ファイルの WebM ストリーミング設定.</param>
        /// <param name="mp4">録画済み TS ファイルの MP4 ストリーミング設定.</param>
        /// <param name="hls">録画済み TS ファイルの HLS ストリーミング設定.</param>
        public ConfigStreamConfigRecordedTs(List<string> webm = default(List<string>), List<string> mp4 = default(List<string>), List<string> hls = default(List<string>))
        {
            this.Webm = webm;
            this.Mp4 = mp4;
            this.Hls = hls;
        }

        /// <summary>
        /// 録画済み TS ファイルの WebM ストリーミング設定
        /// </summary>
        /// <value>録画済み TS ファイルの WebM ストリーミング設定</value>
        [DataMember(Name = "webm", EmitDefaultValue = false)]
        public List<string> Webm { get; set; }

        /// <summary>
        /// 録画済み TS ファイルの MP4 ストリーミング設定
        /// </summary>
        /// <value>録画済み TS ファイルの MP4 ストリーミング設定</value>
        [DataMember(Name = "mp4", EmitDefaultValue = false)]
        public List<string> Mp4 { get; set; }

        /// <summary>
        /// 録画済み TS ファイルの HLS ストリーミング設定
        /// </summary>
        /// <value>録画済み TS ファイルの HLS ストリーミング設定</value>
        [DataMember(Name = "hls", EmitDefaultValue = false)]
        public List<string> Hls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigStreamConfigRecordedTs {\n");
            sb.Append("  Webm: ").Append(Webm).Append("\n");
            sb.Append("  Mp4: ").Append(Mp4).Append("\n");
            sb.Append("  Hls: ").Append(Hls).Append("\n");
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
            return this.Equals(input as ConfigStreamConfigRecordedTs);
        }

        /// <summary>
        /// Returns true if ConfigStreamConfigRecordedTs instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigStreamConfigRecordedTs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigStreamConfigRecordedTs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Webm == input.Webm ||
                    this.Webm != null &&
                    input.Webm != null &&
                    this.Webm.SequenceEqual(input.Webm)
                ) && 
                (
                    this.Mp4 == input.Mp4 ||
                    this.Mp4 != null &&
                    input.Mp4 != null &&
                    this.Mp4.SequenceEqual(input.Mp4)
                ) && 
                (
                    this.Hls == input.Hls ||
                    this.Hls != null &&
                    input.Hls != null &&
                    this.Hls.SequenceEqual(input.Hls)
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
                if (this.Webm != null)
                {
                    hashCode = (hashCode * 59) + this.Webm.GetHashCode();
                }
                if (this.Mp4 != null)
                {
                    hashCode = (hashCode * 59) + this.Mp4.GetHashCode();
                }
                if (this.Hls != null)
                {
                    hashCode = (hashCode * 59) + this.Hls.GetHashCode();
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
