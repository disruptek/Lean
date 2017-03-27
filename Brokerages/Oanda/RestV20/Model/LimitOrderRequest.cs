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
    /// A LimitOrderRequest specifies the parameters that may be set when creating a Limit Order.
    /// </summary>
    [DataContract]
    public partial class LimitOrderRequest :  IEquatable<LimitOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of the Order to Create. Must be set to \"LIMIT\" when creating a Market Order.
        /// </summary>
        /// <value>The type of the Order to Create. Must be set to \"LIMIT\" when creating a Market Order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum MARKET for "MARKET"
            /// </summary>
            [EnumMember(Value = "MARKET")]
            MARKET,
            
            /// <summary>
            /// Enum LIMIT for "LIMIT"
            /// </summary>
            [EnumMember(Value = "LIMIT")]
            LIMIT,
            
            /// <summary>
            /// Enum STOP for "STOP"
            /// </summary>
            [EnumMember(Value = "STOP")]
            STOP,
            
            /// <summary>
            /// Enum MARKETIFTOUCHED for "MARKET_IF_TOUCHED"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED")]
            MARKETIFTOUCHED,
            
            /// <summary>
            /// Enum TAKEPROFIT for "TAKE_PROFIT"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT")]
            TAKEPROFIT,
            
            /// <summary>
            /// Enum STOPLOSS for "STOP_LOSS"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS")]
            STOPLOSS,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSS for "TRAILING_STOP_LOSS"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS")]
            TRAILINGSTOPLOSS
        }

        /// <summary>
        /// The time-in-force requested for the Limit Order.
        /// </summary>
        /// <value>The time-in-force requested for the Limit Order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            
            /// <summary>
            /// Enum GTC for "GTC"
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC,
            
            /// <summary>
            /// Enum GTD for "GTD"
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD,
            
            /// <summary>
            /// Enum GFD for "GFD"
            /// </summary>
            [EnumMember(Value = "GFD")]
            GFD,
            
            /// <summary>
            /// Enum FOK for "FOK"
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK,
            
            /// <summary>
            /// Enum IOC for "IOC"
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC
        }

        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order is filled.
        /// </summary>
        /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionFillEnum
        {
            
            /// <summary>
            /// Enum OPENONLY for "OPEN_ONLY"
            /// </summary>
            [EnumMember(Value = "OPEN_ONLY")]
            OPENONLY,
            
            /// <summary>
            /// Enum REDUCEFIRST for "REDUCE_FIRST"
            /// </summary>
            [EnumMember(Value = "REDUCE_FIRST")]
            REDUCEFIRST,
            
            /// <summary>
            /// Enum REDUCEONLY for "REDUCE_ONLY"
            /// </summary>
            [EnumMember(Value = "REDUCE_ONLY")]
            REDUCEONLY,
            
            /// <summary>
            /// Enum DEFAULT for "DEFAULT"
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT
        }

        /// <summary>
        /// The type of the Order to Create. Must be set to \"LIMIT\" when creating a Market Order.
        /// </summary>
        /// <value>The type of the Order to Create. Must be set to \"LIMIT\" when creating a Market Order.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The time-in-force requested for the Limit Order.
        /// </summary>
        /// <value>The time-in-force requested for the Limit Order.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order is filled.
        /// </summary>
        /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
        [DataMember(Name="positionFill", EmitDefaultValue=false)]
        public PositionFillEnum? PositionFill { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitOrderRequest" /> class.
        /// </summary>
        /// <param name="Type">The type of the Order to Create. Must be set to \&quot;LIMIT\&quot; when creating a Market Order..</param>
        /// <param name="Instrument">The Limit Order&#39;s Instrument..</param>
        /// <param name="Units">The quantity requested to be filled by the Limit Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order..</param>
        /// <param name="Price">The price threshold specified for the Limit Order. The Limit Order will only be filled by a market price that is equal to or better than this price..</param>
        /// <param name="TimeInForce">The time-in-force requested for the Limit Order..</param>
        /// <param name="GtdTime">The date/time when the Limit Order will be cancelled if its timeInForce is \&quot;GTD\&quot;..</param>
        /// <param name="PositionFill">Specification of how Positions in the Account are modified when the Order is filled..</param>
        /// <param name="ClientExtensions">The client extensions to add to the Order. Do not set, modify, or delete clientExtensions if your account is associated with MT4..</param>
        /// <param name="TakeProfitOnFill">TakeProfitDetails specifies the details of a Take Profit Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Take Profit, or when a Trade&#39;s dependent Take Profit Order is modified directly through the Trade..</param>
        /// <param name="StopLossOnFill">StopLossDetails specifies the details of a Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Stop Loss, or when a Trade&#39;s dependent Stop Loss Order is modified directly through the Trade..</param>
        /// <param name="TrailingStopLossOnFill">TrailingStopLossDetails specifies the details of a Trailing Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Trailing Stop Loss, or when a Trade&#39;s dependent Trailing Stop Loss Order is modified directly through the Trade..</param>
        /// <param name="TradeClientExtensions">Client Extensions to add to the Trade created when the Order is filled (if such a Trade is created). Do not set, modify, or delete tradeClientExtensions if your account is associated with MT4..</param>
        public LimitOrderRequest(TypeEnum? Type = default(TypeEnum?), string Instrument = default(string), string Units = default(string), string Price = default(string), TimeInForceEnum? TimeInForce = default(TimeInForceEnum?), string GtdTime = default(string), PositionFillEnum? PositionFill = default(PositionFillEnum?), ClientExtensions ClientExtensions = default(ClientExtensions), TakeProfitDetails TakeProfitOnFill = default(TakeProfitDetails), StopLossDetails StopLossOnFill = default(StopLossDetails), TrailingStopLossDetails TrailingStopLossOnFill = default(TrailingStopLossDetails), ClientExtensions TradeClientExtensions = default(ClientExtensions))
        {
            this.Type = Type;
            this.Instrument = Instrument;
            this.Units = Units;
            this.Price = Price;
            this.TimeInForce = TimeInForce;
            this.GtdTime = GtdTime;
            this.PositionFill = PositionFill;
            this.ClientExtensions = ClientExtensions;
            this.TakeProfitOnFill = TakeProfitOnFill;
            this.StopLossOnFill = StopLossOnFill;
            this.TrailingStopLossOnFill = TrailingStopLossOnFill;
            this.TradeClientExtensions = TradeClientExtensions;
        }
        
        /// <summary>
        /// The Limit Order&#39;s Instrument.
        /// </summary>
        /// <value>The Limit Order&#39;s Instrument.</value>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public string Instrument { get; set; }
        /// <summary>
        /// The quantity requested to be filled by the Limit Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
        /// </summary>
        /// <value>The quantity requested to be filled by the Limit Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }
        /// <summary>
        /// The price threshold specified for the Limit Order. The Limit Order will only be filled by a market price that is equal to or better than this price.
        /// </summary>
        /// <value>The price threshold specified for the Limit Order. The Limit Order will only be filled by a market price that is equal to or better than this price.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }
        /// <summary>
        /// The date/time when the Limit Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.
        /// </summary>
        /// <value>The date/time when the Limit Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }
        /// <summary>
        /// The client extensions to add to the Order. Do not set, modify, or delete clientExtensions if your account is associated with MT4.
        /// </summary>
        /// <value>The client extensions to add to the Order. Do not set, modify, or delete clientExtensions if your account is associated with MT4.</value>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }
        /// <summary>
        /// TakeProfitDetails specifies the details of a Take Profit Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Take Profit, or when a Trade&#39;s dependent Take Profit Order is modified directly through the Trade.
        /// </summary>
        /// <value>TakeProfitDetails specifies the details of a Take Profit Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Take Profit, or when a Trade&#39;s dependent Take Profit Order is modified directly through the Trade.</value>
        [DataMember(Name="takeProfitOnFill", EmitDefaultValue=false)]
        public TakeProfitDetails TakeProfitOnFill { get; set; }
        /// <summary>
        /// StopLossDetails specifies the details of a Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Stop Loss, or when a Trade&#39;s dependent Stop Loss Order is modified directly through the Trade.
        /// </summary>
        /// <value>StopLossDetails specifies the details of a Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Stop Loss, or when a Trade&#39;s dependent Stop Loss Order is modified directly through the Trade.</value>
        [DataMember(Name="stopLossOnFill", EmitDefaultValue=false)]
        public StopLossDetails StopLossOnFill { get; set; }
        /// <summary>
        /// TrailingStopLossDetails specifies the details of a Trailing Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Trailing Stop Loss, or when a Trade&#39;s dependent Trailing Stop Loss Order is modified directly through the Trade.
        /// </summary>
        /// <value>TrailingStopLossDetails specifies the details of a Trailing Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Trailing Stop Loss, or when a Trade&#39;s dependent Trailing Stop Loss Order is modified directly through the Trade.</value>
        [DataMember(Name="trailingStopLossOnFill", EmitDefaultValue=false)]
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }
        /// <summary>
        /// Client Extensions to add to the Trade created when the Order is filled (if such a Trade is created). Do not set, modify, or delete tradeClientExtensions if your account is associated with MT4.
        /// </summary>
        /// <value>Client Extensions to add to the Trade created when the Order is filled (if such a Trade is created). Do not set, modify, or delete tradeClientExtensions if your account is associated with MT4.</value>
        [DataMember(Name="tradeClientExtensions", EmitDefaultValue=false)]
        public ClientExtensions TradeClientExtensions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitOrderRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  TakeProfitOnFill: ").Append(TakeProfitOnFill).Append("\n");
            sb.Append("  StopLossOnFill: ").Append(StopLossOnFill).Append("\n");
            sb.Append("  TrailingStopLossOnFill: ").Append(TrailingStopLossOnFill).Append("\n");
            sb.Append("  TradeClientExtensions: ").Append(TradeClientExtensions).Append("\n");
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
            return this.Equals(obj as LimitOrderRequest);
        }

        /// <summary>
        /// Returns true if LimitOrderRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LimitOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitOrderRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Instrument == other.Instrument ||
                    this.Instrument != null &&
                    this.Instrument.Equals(other.Instrument)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.Equals(other.Units)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.TimeInForce == other.TimeInForce ||
                    this.TimeInForce != null &&
                    this.TimeInForce.Equals(other.TimeInForce)
                ) && 
                (
                    this.GtdTime == other.GtdTime ||
                    this.GtdTime != null &&
                    this.GtdTime.Equals(other.GtdTime)
                ) && 
                (
                    this.PositionFill == other.PositionFill ||
                    this.PositionFill != null &&
                    this.PositionFill.Equals(other.PositionFill)
                ) && 
                (
                    this.ClientExtensions == other.ClientExtensions ||
                    this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(other.ClientExtensions)
                ) && 
                (
                    this.TakeProfitOnFill == other.TakeProfitOnFill ||
                    this.TakeProfitOnFill != null &&
                    this.TakeProfitOnFill.Equals(other.TakeProfitOnFill)
                ) && 
                (
                    this.StopLossOnFill == other.StopLossOnFill ||
                    this.StopLossOnFill != null &&
                    this.StopLossOnFill.Equals(other.StopLossOnFill)
                ) && 
                (
                    this.TrailingStopLossOnFill == other.TrailingStopLossOnFill ||
                    this.TrailingStopLossOnFill != null &&
                    this.TrailingStopLossOnFill.Equals(other.TrailingStopLossOnFill)
                ) && 
                (
                    this.TradeClientExtensions == other.TradeClientExtensions ||
                    this.TradeClientExtensions != null &&
                    this.TradeClientExtensions.Equals(other.TradeClientExtensions)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Instrument != null)
                    hash = hash * 59 + this.Instrument.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.TimeInForce != null)
                    hash = hash * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hash = hash * 59 + this.GtdTime.GetHashCode();
                if (this.PositionFill != null)
                    hash = hash * 59 + this.PositionFill.GetHashCode();
                if (this.ClientExtensions != null)
                    hash = hash * 59 + this.ClientExtensions.GetHashCode();
                if (this.TakeProfitOnFill != null)
                    hash = hash * 59 + this.TakeProfitOnFill.GetHashCode();
                if (this.StopLossOnFill != null)
                    hash = hash * 59 + this.StopLossOnFill.GetHashCode();
                if (this.TrailingStopLossOnFill != null)
                    hash = hash * 59 + this.TrailingStopLossOnFill.GetHashCode();
                if (this.TradeClientExtensions != null)
                    hash = hash * 59 + this.TradeClientExtensions.GetHashCode();
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
