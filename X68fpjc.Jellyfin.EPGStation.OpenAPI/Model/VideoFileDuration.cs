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
    /// ビデオファイルの長さ
    /// </summary>
    [DataContract(Name = "VideoFileDuration")]
    public partial class VideoFileDuration : IEquatable<VideoFileDuration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFileDuration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoFileDuration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFileDuration" /> class.
        /// </summary>
        /// <param name="duration">動画長(秒) (required).</param>
        public VideoFileDuration(decimal duration = default(decimal))
        {
            this.Duration = duration;
        }

        /// <summary>
        /// 動画長(秒)
        /// </summary>
        /// <value>動画長(秒)</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = false)]
        public decimal Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoFileDuration {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as VideoFileDuration);
        }

        /// <summary>
        /// Returns true if VideoFileDuration instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoFileDuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoFileDuration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
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
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
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