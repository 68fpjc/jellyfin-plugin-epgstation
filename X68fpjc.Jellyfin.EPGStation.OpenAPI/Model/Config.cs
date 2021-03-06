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
    /// コンフィグ
    /// </summary>
    [DataContract(Name = "Config")]
    public partial class Config : IEquatable<Config>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Config() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="socketIOPort">socket.io 通信で使用するポート (required).</param>
        /// <param name="broadcast">broadcast (required).</param>
        /// <param name="recorded">指定可能な録画ディレクトリ名 (required).</param>
        /// <param name="encode">エンコードモード (required).</param>
        /// <param name="urlscheme">urlscheme (required).</param>
        /// <param name="isEnableLiveStream">ライブ視聴が有効か (required).</param>
        /// <param name="isEnableTSRecordedStream">録画済みの TS ファイルのストリーミングが有効か (required).</param>
        /// <param name="isEnableEncodedRecordedStream">録画済みのエンコード済みファイルのストリーミングが有効か (required).</param>
        /// <param name="streamConfig">streamConfig.</param>
        /// <param name="kodiHosts">kodi hosts.</param>
        public Config(int socketIOPort = default(int), ConfigBroadcast broadcast = default(ConfigBroadcast), List<string> recorded = default(List<string>), List<string> encode = default(List<string>), ConfigUrlscheme urlscheme = default(ConfigUrlscheme), bool isEnableLiveStream = default(bool), bool isEnableTSRecordedStream = default(bool), bool isEnableEncodedRecordedStream = default(bool), ConfigStreamConfig streamConfig = default(ConfigStreamConfig), List<string> kodiHosts = default(List<string>))
        {
            this.SocketIOPort = socketIOPort;
            // to ensure "broadcast" is required (not null)
            if (broadcast == null)
            {
                throw new ArgumentNullException("broadcast is a required property for Config and cannot be null");
            }
            this.Broadcast = broadcast;
            // to ensure "recorded" is required (not null)
            if (recorded == null)
            {
                throw new ArgumentNullException("recorded is a required property for Config and cannot be null");
            }
            this.Recorded = recorded;
            // to ensure "encode" is required (not null)
            if (encode == null)
            {
                throw new ArgumentNullException("encode is a required property for Config and cannot be null");
            }
            this.Encode = encode;
            // to ensure "urlscheme" is required (not null)
            if (urlscheme == null)
            {
                throw new ArgumentNullException("urlscheme is a required property for Config and cannot be null");
            }
            this.Urlscheme = urlscheme;
            this.IsEnableLiveStream = isEnableLiveStream;
            this.IsEnableTSRecordedStream = isEnableTSRecordedStream;
            this.IsEnableEncodedRecordedStream = isEnableEncodedRecordedStream;
            this.StreamConfig = streamConfig;
            this.KodiHosts = kodiHosts;
        }

        /// <summary>
        /// socket.io 通信で使用するポート
        /// </summary>
        /// <value>socket.io 通信で使用するポート</value>
        [DataMember(Name = "socketIOPort", IsRequired = true, EmitDefaultValue = false)]
        public int SocketIOPort { get; set; }

        /// <summary>
        /// Gets or Sets Broadcast
        /// </summary>
        [DataMember(Name = "broadcast", IsRequired = true, EmitDefaultValue = false)]
        public ConfigBroadcast Broadcast { get; set; }

        /// <summary>
        /// 指定可能な録画ディレクトリ名
        /// </summary>
        /// <value>指定可能な録画ディレクトリ名</value>
        [DataMember(Name = "recorded", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Recorded { get; set; }

        /// <summary>
        /// エンコードモード
        /// </summary>
        /// <value>エンコードモード</value>
        [DataMember(Name = "encode", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Encode { get; set; }

        /// <summary>
        /// Gets or Sets Urlscheme
        /// </summary>
        [DataMember(Name = "urlscheme", IsRequired = true, EmitDefaultValue = false)]
        public ConfigUrlscheme Urlscheme { get; set; }

        /// <summary>
        /// ライブ視聴が有効か
        /// </summary>
        /// <value>ライブ視聴が有効か</value>
        [DataMember(Name = "isEnableLiveStream", IsRequired = true, EmitDefaultValue = true)]
        public bool IsEnableLiveStream { get; set; }

        /// <summary>
        /// 録画済みの TS ファイルのストリーミングが有効か
        /// </summary>
        /// <value>録画済みの TS ファイルのストリーミングが有効か</value>
        [DataMember(Name = "isEnableTSRecordedStream", IsRequired = true, EmitDefaultValue = true)]
        public bool IsEnableTSRecordedStream { get; set; }

        /// <summary>
        /// 録画済みのエンコード済みファイルのストリーミングが有効か
        /// </summary>
        /// <value>録画済みのエンコード済みファイルのストリーミングが有効か</value>
        [DataMember(Name = "isEnableEncodedRecordedStream", IsRequired = true, EmitDefaultValue = true)]
        public bool IsEnableEncodedRecordedStream { get; set; }

        /// <summary>
        /// Gets or Sets StreamConfig
        /// </summary>
        [DataMember(Name = "streamConfig", EmitDefaultValue = false)]
        public ConfigStreamConfig StreamConfig { get; set; }

        /// <summary>
        /// kodi hosts
        /// </summary>
        /// <value>kodi hosts</value>
        [DataMember(Name = "kodiHosts", EmitDefaultValue = false)]
        public List<string> KodiHosts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  SocketIOPort: ").Append(SocketIOPort).Append("\n");
            sb.Append("  Broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  Recorded: ").Append(Recorded).Append("\n");
            sb.Append("  Encode: ").Append(Encode).Append("\n");
            sb.Append("  Urlscheme: ").Append(Urlscheme).Append("\n");
            sb.Append("  IsEnableLiveStream: ").Append(IsEnableLiveStream).Append("\n");
            sb.Append("  IsEnableTSRecordedStream: ").Append(IsEnableTSRecordedStream).Append("\n");
            sb.Append("  IsEnableEncodedRecordedStream: ").Append(IsEnableEncodedRecordedStream).Append("\n");
            sb.Append("  StreamConfig: ").Append(StreamConfig).Append("\n");
            sb.Append("  KodiHosts: ").Append(KodiHosts).Append("\n");
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
            return this.Equals(input as Config);
        }

        /// <summary>
        /// Returns true if Config instances are equal
        /// </summary>
        /// <param name="input">Instance of Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Config input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SocketIOPort == input.SocketIOPort ||
                    this.SocketIOPort.Equals(input.SocketIOPort)
                ) && 
                (
                    this.Broadcast == input.Broadcast ||
                    (this.Broadcast != null &&
                    this.Broadcast.Equals(input.Broadcast))
                ) && 
                (
                    this.Recorded == input.Recorded ||
                    this.Recorded != null &&
                    input.Recorded != null &&
                    this.Recorded.SequenceEqual(input.Recorded)
                ) && 
                (
                    this.Encode == input.Encode ||
                    this.Encode != null &&
                    input.Encode != null &&
                    this.Encode.SequenceEqual(input.Encode)
                ) && 
                (
                    this.Urlscheme == input.Urlscheme ||
                    (this.Urlscheme != null &&
                    this.Urlscheme.Equals(input.Urlscheme))
                ) && 
                (
                    this.IsEnableLiveStream == input.IsEnableLiveStream ||
                    this.IsEnableLiveStream.Equals(input.IsEnableLiveStream)
                ) && 
                (
                    this.IsEnableTSRecordedStream == input.IsEnableTSRecordedStream ||
                    this.IsEnableTSRecordedStream.Equals(input.IsEnableTSRecordedStream)
                ) && 
                (
                    this.IsEnableEncodedRecordedStream == input.IsEnableEncodedRecordedStream ||
                    this.IsEnableEncodedRecordedStream.Equals(input.IsEnableEncodedRecordedStream)
                ) && 
                (
                    this.StreamConfig == input.StreamConfig ||
                    (this.StreamConfig != null &&
                    this.StreamConfig.Equals(input.StreamConfig))
                ) && 
                (
                    this.KodiHosts == input.KodiHosts ||
                    this.KodiHosts != null &&
                    input.KodiHosts != null &&
                    this.KodiHosts.SequenceEqual(input.KodiHosts)
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
                hashCode = (hashCode * 59) + this.SocketIOPort.GetHashCode();
                if (this.Broadcast != null)
                {
                    hashCode = (hashCode * 59) + this.Broadcast.GetHashCode();
                }
                if (this.Recorded != null)
                {
                    hashCode = (hashCode * 59) + this.Recorded.GetHashCode();
                }
                if (this.Encode != null)
                {
                    hashCode = (hashCode * 59) + this.Encode.GetHashCode();
                }
                if (this.Urlscheme != null)
                {
                    hashCode = (hashCode * 59) + this.Urlscheme.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEnableLiveStream.GetHashCode();
                hashCode = (hashCode * 59) + this.IsEnableTSRecordedStream.GetHashCode();
                hashCode = (hashCode * 59) + this.IsEnableEncodedRecordedStream.GetHashCode();
                if (this.StreamConfig != null)
                {
                    hashCode = (hashCode * 59) + this.StreamConfig.GetHashCode();
                }
                if (this.KodiHosts != null)
                {
                    hashCode = (hashCode * 59) + this.KodiHosts.GetHashCode();
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
