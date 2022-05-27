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
    /// 予約, 除外, 重複, 競合の reserveId のリスト
    /// </summary>
    [DataContract(Name = "ReserveLists")]
    public partial class ReserveLists : IEquatable<ReserveLists>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveLists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReserveLists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveLists" /> class.
        /// </summary>
        /// <param name="normal">normal (required).</param>
        /// <param name="conflicts">conflicts (required).</param>
        /// <param name="skips">skips (required).</param>
        /// <param name="overlaps">overlaps (required).</param>
        public ReserveLists(ReserveListItem normal = default(ReserveListItem), ReserveListItem conflicts = default(ReserveListItem), ReserveListItem skips = default(ReserveListItem), ReserveListItem overlaps = default(ReserveListItem))
        {
            // to ensure "normal" is required (not null)
            if (normal == null)
            {
                throw new ArgumentNullException("normal is a required property for ReserveLists and cannot be null");
            }
            this.Normal = normal;
            // to ensure "conflicts" is required (not null)
            if (conflicts == null)
            {
                throw new ArgumentNullException("conflicts is a required property for ReserveLists and cannot be null");
            }
            this.Conflicts = conflicts;
            // to ensure "skips" is required (not null)
            if (skips == null)
            {
                throw new ArgumentNullException("skips is a required property for ReserveLists and cannot be null");
            }
            this.Skips = skips;
            // to ensure "overlaps" is required (not null)
            if (overlaps == null)
            {
                throw new ArgumentNullException("overlaps is a required property for ReserveLists and cannot be null");
            }
            this.Overlaps = overlaps;
        }

        /// <summary>
        /// Gets or Sets Normal
        /// </summary>
        [DataMember(Name = "normal", IsRequired = true, EmitDefaultValue = false)]
        public ReserveListItem Normal { get; set; }

        /// <summary>
        /// Gets or Sets Conflicts
        /// </summary>
        [DataMember(Name = "conflicts", IsRequired = true, EmitDefaultValue = false)]
        public ReserveListItem Conflicts { get; set; }

        /// <summary>
        /// Gets or Sets Skips
        /// </summary>
        [DataMember(Name = "skips", IsRequired = true, EmitDefaultValue = false)]
        public ReserveListItem Skips { get; set; }

        /// <summary>
        /// Gets or Sets Overlaps
        /// </summary>
        [DataMember(Name = "overlaps", IsRequired = true, EmitDefaultValue = false)]
        public ReserveListItem Overlaps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReserveLists {\n");
            sb.Append("  Normal: ").Append(Normal).Append("\n");
            sb.Append("  Conflicts: ").Append(Conflicts).Append("\n");
            sb.Append("  Skips: ").Append(Skips).Append("\n");
            sb.Append("  Overlaps: ").Append(Overlaps).Append("\n");
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
            return this.Equals(input as ReserveLists);
        }

        /// <summary>
        /// Returns true if ReserveLists instances are equal
        /// </summary>
        /// <param name="input">Instance of ReserveLists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReserveLists input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Normal == input.Normal ||
                    (this.Normal != null &&
                    this.Normal.Equals(input.Normal))
                ) && 
                (
                    this.Conflicts == input.Conflicts ||
                    (this.Conflicts != null &&
                    this.Conflicts.Equals(input.Conflicts))
                ) && 
                (
                    this.Skips == input.Skips ||
                    (this.Skips != null &&
                    this.Skips.Equals(input.Skips))
                ) && 
                (
                    this.Overlaps == input.Overlaps ||
                    (this.Overlaps != null &&
                    this.Overlaps.Equals(input.Overlaps))
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
                if (this.Normal != null)
                {
                    hashCode = (hashCode * 59) + this.Normal.GetHashCode();
                }
                if (this.Conflicts != null)
                {
                    hashCode = (hashCode * 59) + this.Conflicts.GetHashCode();
                }
                if (this.Skips != null)
                {
                    hashCode = (hashCode * 59) + this.Skips.GetHashCode();
                }
                if (this.Overlaps != null)
                {
                    hashCode = (hashCode * 59) + this.Overlaps.GetHashCode();
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
