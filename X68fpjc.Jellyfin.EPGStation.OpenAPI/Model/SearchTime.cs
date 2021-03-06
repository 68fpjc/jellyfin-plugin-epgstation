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
    /// 時刻範囲指定オプション
    /// </summary>
    [DataContract(Name = "SearchTime")]
    public partial class SearchTime : IEquatable<SearchTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTime" /> class.
        /// </summary>
        /// <param name="start">開始時刻 1 - 23, 時刻予約の場合は 0 時を 0 とした 0 ~ (60 * 50 * 24) - 1 秒までの開始時刻を指定する.</param>
        /// <param name="range">開始時刻からの時刻範囲(時) 1 - 23, 時刻予約の場合は秒で時間の長さを指定する 1 ~ 60 * 50 * 24 秒.</param>
        /// <param name="week">曜日指定 0x01, 0x02, 0x04, 0x08, 0x10, 0x20 ,0x40 が日〜土に対応するので and 演算で曜日を指定する (required).</param>
        public SearchTime(int start = default(int), int range = default(int), int week = default(int))
        {
            this.Week = week;
            this.Start = start;
            this.Range = range;
        }

        /// <summary>
        /// 開始時刻 1 - 23, 時刻予約の場合は 0 時を 0 とした 0 ~ (60 * 50 * 24) - 1 秒までの開始時刻を指定する
        /// </summary>
        /// <value>開始時刻 1 - 23, 時刻予約の場合は 0 時を 0 とした 0 ~ (60 * 50 * 24) - 1 秒までの開始時刻を指定する</value>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public int Start { get; set; }

        /// <summary>
        /// 開始時刻からの時刻範囲(時) 1 - 23, 時刻予約の場合は秒で時間の長さを指定する 1 ~ 60 * 50 * 24 秒
        /// </summary>
        /// <value>開始時刻からの時刻範囲(時) 1 - 23, 時刻予約の場合は秒で時間の長さを指定する 1 ~ 60 * 50 * 24 秒</value>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        public int Range { get; set; }

        /// <summary>
        /// 曜日指定 0x01, 0x02, 0x04, 0x08, 0x10, 0x20 ,0x40 が日〜土に対応するので and 演算で曜日を指定する
        /// </summary>
        /// <value>曜日指定 0x01, 0x02, 0x04, 0x08, 0x10, 0x20 ,0x40 が日〜土に対応するので and 演算で曜日を指定する</value>
        [DataMember(Name = "week", IsRequired = true, EmitDefaultValue = false)]
        public int Week { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchTime {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
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
            return this.Equals(input as SearchTime);
        }

        /// <summary>
        /// Returns true if SearchTime instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchTime input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Start == input.Start ||
                    this.Start.Equals(input.Start)
                ) && 
                (
                    this.Range == input.Range ||
                    this.Range.Equals(input.Range)
                ) && 
                (
                    this.Week == input.Week ||
                    this.Week.Equals(input.Week)
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
                hashCode = (hashCode * 59) + this.Start.GetHashCode();
                hashCode = (hashCode * 59) + this.Range.GetHashCode();
                hashCode = (hashCode * 59) + this.Week.GetHashCode();
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
