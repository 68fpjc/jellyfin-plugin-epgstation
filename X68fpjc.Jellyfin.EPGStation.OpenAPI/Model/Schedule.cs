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
    /// 番組表データ
    /// </summary>
    [DataContract(Name = "Schedule")]
    public partial class Schedule : IEquatable<Schedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Schedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="channel">channel (required).</param>
        /// <param name="programs">programs (required).</param>
        public Schedule(ScheduleChannleItem channel = default(ScheduleChannleItem), List<ScheduleProgramItem> programs = default(List<ScheduleProgramItem>))
        {
            // to ensure "channel" is required (not null)
            if (channel == null)
            {
                throw new ArgumentNullException("channel is a required property for Schedule and cannot be null");
            }
            this.Channel = channel;
            // to ensure "programs" is required (not null)
            if (programs == null)
            {
                throw new ArgumentNullException("programs is a required property for Schedule and cannot be null");
            }
            this.Programs = programs;
        }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = false)]
        public ScheduleChannleItem Channel { get; set; }

        /// <summary>
        /// Gets or Sets Programs
        /// </summary>
        [DataMember(Name = "programs", IsRequired = true, EmitDefaultValue = false)]
        public List<ScheduleProgramItem> Programs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
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
            return this.Equals(input as Schedule);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="input">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Programs == input.Programs ||
                    this.Programs != null &&
                    input.Programs != null &&
                    this.Programs.SequenceEqual(input.Programs)
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
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.Programs != null)
                {
                    hashCode = (hashCode * 59) + this.Programs.GetHashCode();
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
