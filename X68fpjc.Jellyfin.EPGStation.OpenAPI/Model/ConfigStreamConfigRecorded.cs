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
    /// 録画済みストリーミング設定
    /// </summary>
    [DataContract(Name = "Config_streamConfig_recorded")]
    public partial class ConfigStreamConfigRecorded : IEquatable<ConfigStreamConfigRecorded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigStreamConfigRecorded" /> class.
        /// </summary>
        /// <param name="ts">ts.</param>
        /// <param name="encoded">encoded.</param>
        public ConfigStreamConfigRecorded(ConfigStreamConfigRecordedTs ts = default(ConfigStreamConfigRecordedTs), ConfigStreamConfigRecordedEncoded encoded = default(ConfigStreamConfigRecordedEncoded))
        {
            this.Ts = ts;
            this.Encoded = encoded;
        }

        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name = "ts", EmitDefaultValue = false)]
        public ConfigStreamConfigRecordedTs Ts { get; set; }

        /// <summary>
        /// Gets or Sets Encoded
        /// </summary>
        [DataMember(Name = "encoded", EmitDefaultValue = false)]
        public ConfigStreamConfigRecordedEncoded Encoded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigStreamConfigRecorded {\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Encoded: ").Append(Encoded).Append("\n");
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
            return this.Equals(input as ConfigStreamConfigRecorded);
        }

        /// <summary>
        /// Returns true if ConfigStreamConfigRecorded instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigStreamConfigRecorded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigStreamConfigRecorded input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
                ) && 
                (
                    this.Encoded == input.Encoded ||
                    (this.Encoded != null &&
                    this.Encoded.Equals(input.Encoded))
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
                if (this.Ts != null)
                {
                    hashCode = (hashCode * 59) + this.Ts.GetHashCode();
                }
                if (this.Encoded != null)
                {
                    hashCode = (hashCode * 59) + this.Encoded.GetHashCode();
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
