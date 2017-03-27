/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.14
 * Contact: api@oanda.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// Full specification of an Instrument.
    /// </summary>
    [DataContract]
    public partial class Instrument :  IEquatable<Instrument>, IValidatableObject
    {
        /// <summary>
        /// The type of the Instrument
        /// </summary>
        /// <value>The type of the Instrument</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum CURRENCY for "CURRENCY"
            /// </summary>
            [EnumMember(Value = "CURRENCY")]
            CURRENCY,
            
            /// <summary>
            /// Enum CFD for "CFD"
            /// </summary>
            [EnumMember(Value = "CFD")]
            CFD,
            
            /// <summary>
            /// Enum METAL for "METAL"
            /// </summary>
            [EnumMember(Value = "METAL")]
            METAL
        }

        /// <summary>
        /// The type of the Instrument
        /// </summary>
        /// <value>The type of the Instrument</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instrument" /> class.
        /// </summary>
        /// <param name="Name">The name of the Instrument.</param>
        /// <param name="Type">The type of the Instrument.</param>
        /// <param name="DisplayName">The display name of the Instrument.</param>
        /// <param name="PipLocation">The location of the \&quot;pip\&quot; for this instrument. The decimal position of the pip in this Instrument&#39;s price can be found at 10 ^ pipLocation (e.g. -4 pipLocation results in a decimal pip position of 10 ^ -4 &#x3D; 0.0001)..</param>
        /// <param name="DisplayPrecision">The number of decimal places that should be used to display prices for this instrument. (e.g. a displayPrecision of 5 would result in a price of \&quot;1\&quot; being displayed as \&quot;1.00000\&quot;).</param>
        /// <param name="TradeUnitsPrecision">The amount of decimal places that may be provided when specifying the number of units traded for this instrument..</param>
        /// <param name="MinimumTradeSize">The smallest number of units allowed to be traded for this instrument..</param>
        /// <param name="MaximumTrailingStopDistance">The maximum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units..</param>
        /// <param name="MinimumTrailingStopDistance">The minimum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units..</param>
        /// <param name="MaximumPositionSize">The maximum position size allowed for this instrument. Specified in units..</param>
        /// <param name="MaximumOrderUnits">The maximum units allowed for an Order placed for this instrument. Specified in units..</param>
        /// <param name="MarginRate">The margin rate for this instrument..</param>
        public Instrument(string Name = default(string), TypeEnum? Type = default(TypeEnum?), string DisplayName = default(string), int? PipLocation = default(int?), int? DisplayPrecision = default(int?), int? TradeUnitsPrecision = default(int?), string MinimumTradeSize = default(string), string MaximumTrailingStopDistance = default(string), string MinimumTrailingStopDistance = default(string), string MaximumPositionSize = default(string), string MaximumOrderUnits = default(string), string MarginRate = default(string))
        {
            this.Name = Name;
            this.Type = Type;
            this.DisplayName = DisplayName;
            this.PipLocation = PipLocation;
            this.DisplayPrecision = DisplayPrecision;
            this.TradeUnitsPrecision = TradeUnitsPrecision;
            this.MinimumTradeSize = MinimumTradeSize;
            this.MaximumTrailingStopDistance = MaximumTrailingStopDistance;
            this.MinimumTrailingStopDistance = MinimumTrailingStopDistance;
            this.MaximumPositionSize = MaximumPositionSize;
            this.MaximumOrderUnits = MaximumOrderUnits;
            this.MarginRate = MarginRate;
        }
        
        /// <summary>
        /// The name of the Instrument
        /// </summary>
        /// <value>The name of the Instrument</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The display name of the Instrument
        /// </summary>
        /// <value>The display name of the Instrument</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// The location of the \&quot;pip\&quot; for this instrument. The decimal position of the pip in this Instrument&#39;s price can be found at 10 ^ pipLocation (e.g. -4 pipLocation results in a decimal pip position of 10 ^ -4 &#x3D; 0.0001).
        /// </summary>
        /// <value>The location of the \&quot;pip\&quot; for this instrument. The decimal position of the pip in this Instrument&#39;s price can be found at 10 ^ pipLocation (e.g. -4 pipLocation results in a decimal pip position of 10 ^ -4 &#x3D; 0.0001).</value>
        [DataMember(Name="pipLocation", EmitDefaultValue=false)]
        public int? PipLocation { get; set; }
        /// <summary>
        /// The number of decimal places that should be used to display prices for this instrument. (e.g. a displayPrecision of 5 would result in a price of \&quot;1\&quot; being displayed as \&quot;1.00000\&quot;)
        /// </summary>
        /// <value>The number of decimal places that should be used to display prices for this instrument. (e.g. a displayPrecision of 5 would result in a price of \&quot;1\&quot; being displayed as \&quot;1.00000\&quot;)</value>
        [DataMember(Name="displayPrecision", EmitDefaultValue=false)]
        public int? DisplayPrecision { get; set; }
        /// <summary>
        /// The amount of decimal places that may be provided when specifying the number of units traded for this instrument.
        /// </summary>
        /// <value>The amount of decimal places that may be provided when specifying the number of units traded for this instrument.</value>
        [DataMember(Name="tradeUnitsPrecision", EmitDefaultValue=false)]
        public int? TradeUnitsPrecision { get; set; }
        /// <summary>
        /// The smallest number of units allowed to be traded for this instrument.
        /// </summary>
        /// <value>The smallest number of units allowed to be traded for this instrument.</value>
        [DataMember(Name="minimumTradeSize", EmitDefaultValue=false)]
        public string MinimumTradeSize { get; set; }
        /// <summary>
        /// The maximum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.
        /// </summary>
        /// <value>The maximum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.</value>
        [DataMember(Name="maximumTrailingStopDistance", EmitDefaultValue=false)]
        public string MaximumTrailingStopDistance { get; set; }
        /// <summary>
        /// The minimum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.
        /// </summary>
        /// <value>The minimum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.</value>
        [DataMember(Name="minimumTrailingStopDistance", EmitDefaultValue=false)]
        public string MinimumTrailingStopDistance { get; set; }
        /// <summary>
        /// The maximum position size allowed for this instrument. Specified in units.
        /// </summary>
        /// <value>The maximum position size allowed for this instrument. Specified in units.</value>
        [DataMember(Name="maximumPositionSize", EmitDefaultValue=false)]
        public string MaximumPositionSize { get; set; }
        /// <summary>
        /// The maximum units allowed for an Order placed for this instrument. Specified in units.
        /// </summary>
        /// <value>The maximum units allowed for an Order placed for this instrument. Specified in units.</value>
        [DataMember(Name="maximumOrderUnits", EmitDefaultValue=false)]
        public string MaximumOrderUnits { get; set; }
        /// <summary>
        /// The margin rate for this instrument.
        /// </summary>
        /// <value>The margin rate for this instrument.</value>
        [DataMember(Name="marginRate", EmitDefaultValue=false)]
        public string MarginRate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Instrument {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PipLocation: ").Append(PipLocation).Append("\n");
            sb.Append("  DisplayPrecision: ").Append(DisplayPrecision).Append("\n");
            sb.Append("  TradeUnitsPrecision: ").Append(TradeUnitsPrecision).Append("\n");
            sb.Append("  MinimumTradeSize: ").Append(MinimumTradeSize).Append("\n");
            sb.Append("  MaximumTrailingStopDistance: ").Append(MaximumTrailingStopDistance).Append("\n");
            sb.Append("  MinimumTrailingStopDistance: ").Append(MinimumTrailingStopDistance).Append("\n");
            sb.Append("  MaximumPositionSize: ").Append(MaximumPositionSize).Append("\n");
            sb.Append("  MaximumOrderUnits: ").Append(MaximumOrderUnits).Append("\n");
            sb.Append("  MarginRate: ").Append(MarginRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Instrument);
        }

        /// <summary>
        /// Returns true if Instrument instances are equal
        /// </summary>
        /// <param name="other">Instance of Instrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Instrument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.PipLocation == other.PipLocation ||
                    this.PipLocation != null &&
                    this.PipLocation.Equals(other.PipLocation)
                ) && 
                (
                    this.DisplayPrecision == other.DisplayPrecision ||
                    this.DisplayPrecision != null &&
                    this.DisplayPrecision.Equals(other.DisplayPrecision)
                ) && 
                (
                    this.TradeUnitsPrecision == other.TradeUnitsPrecision ||
                    this.TradeUnitsPrecision != null &&
                    this.TradeUnitsPrecision.Equals(other.TradeUnitsPrecision)
                ) && 
                (
                    this.MinimumTradeSize == other.MinimumTradeSize ||
                    this.MinimumTradeSize != null &&
                    this.MinimumTradeSize.Equals(other.MinimumTradeSize)
                ) && 
                (
                    this.MaximumTrailingStopDistance == other.MaximumTrailingStopDistance ||
                    this.MaximumTrailingStopDistance != null &&
                    this.MaximumTrailingStopDistance.Equals(other.MaximumTrailingStopDistance)
                ) && 
                (
                    this.MinimumTrailingStopDistance == other.MinimumTrailingStopDistance ||
                    this.MinimumTrailingStopDistance != null &&
                    this.MinimumTrailingStopDistance.Equals(other.MinimumTrailingStopDistance)
                ) && 
                (
                    this.MaximumPositionSize == other.MaximumPositionSize ||
                    this.MaximumPositionSize != null &&
                    this.MaximumPositionSize.Equals(other.MaximumPositionSize)
                ) && 
                (
                    this.MaximumOrderUnits == other.MaximumOrderUnits ||
                    this.MaximumOrderUnits != null &&
                    this.MaximumOrderUnits.Equals(other.MaximumOrderUnits)
                ) && 
                (
                    this.MarginRate == other.MarginRate ||
                    this.MarginRate != null &&
                    this.MarginRate.Equals(other.MarginRate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.PipLocation != null)
                    hash = hash * 59 + this.PipLocation.GetHashCode();
                if (this.DisplayPrecision != null)
                    hash = hash * 59 + this.DisplayPrecision.GetHashCode();
                if (this.TradeUnitsPrecision != null)
                    hash = hash * 59 + this.TradeUnitsPrecision.GetHashCode();
                if (this.MinimumTradeSize != null)
                    hash = hash * 59 + this.MinimumTradeSize.GetHashCode();
                if (this.MaximumTrailingStopDistance != null)
                    hash = hash * 59 + this.MaximumTrailingStopDistance.GetHashCode();
                if (this.MinimumTrailingStopDistance != null)
                    hash = hash * 59 + this.MinimumTrailingStopDistance.GetHashCode();
                if (this.MaximumPositionSize != null)
                    hash = hash * 59 + this.MaximumPositionSize.GetHashCode();
                if (this.MaximumOrderUnits != null)
                    hash = hash * 59 + this.MaximumOrderUnits.GetHashCode();
                if (this.MarginRate != null)
                    hash = hash * 59 + this.MarginRate.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
