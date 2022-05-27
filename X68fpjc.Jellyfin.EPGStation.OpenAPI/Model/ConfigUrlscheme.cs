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
    /// URL Scheme 情報
    /// </summary>
    [DataContract(Name = "Config_urlscheme")]
    public partial class ConfigUrlscheme : IEquatable<ConfigUrlscheme>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigUrlscheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigUrlscheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigUrlscheme" /> class.
        /// </summary>
        /// <param name="m2ts">m2ts (required).</param>
        /// <param name="video">video (required).</param>
        /// <param name="download">download (required).</param>
        public ConfigUrlscheme(URLSchemeInfo m2ts = default(URLSchemeInfo), URLSchemeInfo video = default(URLSchemeInfo), URLSchemeInfo download = default(URLSchemeInfo))
        {
            // to ensure "m2ts" is required (not null)
            if (m2ts == null)
            {
                throw new ArgumentNullException("m2ts is a required property for ConfigUrlscheme and cannot be null");
            }
            this.M2ts = m2ts;
            // to ensure "video" is required (not null)
            if (video == null)
            {
                throw new ArgumentNullException("video is a required property for ConfigUrlscheme and cannot be null");
            }
            this.Video = video;
            // to ensure "download" is required (not null)
            if (download == null)
            {
                throw new ArgumentNullException("download is a required property for ConfigUrlscheme and cannot be null");
            }
            this.Download = download;
        }

        /// <summary>
        /// Gets or Sets M2ts
        /// </summary>
        [DataMember(Name = "m2ts", IsRequired = true, EmitDefaultValue = false)]
        public URLSchemeInfo M2ts { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name = "video", IsRequired = true, EmitDefaultValue = false)]
        public URLSchemeInfo Video { get; set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>
        [DataMember(Name = "download", IsRequired = true, EmitDefaultValue = false)]
        public URLSchemeInfo Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigUrlscheme {\n");
            sb.Append("  M2ts: ").Append(M2ts).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
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
            return this.Equals(input as ConfigUrlscheme);
        }

        /// <summary>
        /// Returns true if ConfigUrlscheme instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigUrlscheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigUrlscheme input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.M2ts == input.M2ts ||
                    (this.M2ts != null &&
                    this.M2ts.Equals(input.M2ts))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.Download == input.Download ||
                    (this.Download != null &&
                    this.Download.Equals(input.Download))
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
                if (this.M2ts != null)
                {
                    hashCode = (hashCode * 59) + this.M2ts.GetHashCode();
                }
                if (this.Video != null)
                {
                    hashCode = (hashCode * 59) + this.Video.GetHashCode();
                }
                if (this.Download != null)
                {
                    hashCode = (hashCode * 59) + this.Download.GetHashCode();
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