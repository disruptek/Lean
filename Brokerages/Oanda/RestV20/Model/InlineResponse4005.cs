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
    /// InlineResponse4005
    /// </summary>
    [DataContract]
    public partial class InlineResponse4005 :  IEquatable<InlineResponse4005>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4005" /> class.
        /// </summary>
        /// <param name="OrderRejectTransaction">The MarketOrderReject Transaction that rejects the creation of the Trade-closing MarketOrder..</param>
        /// <param name="ErrorCode">The code of the error that has occurred. This field may not be returned for some errors..</param>
        /// <param name="ErrorMessage">The human-readable description of the error that has occurred..</param>
        public InlineResponse4005(MarketOrderRejectTransaction OrderRejectTransaction = default(MarketOrderRejectTransaction), string ErrorCode = default(string), string ErrorMessage = default(string))
        {
            this.OrderRejectTransaction = OrderRejectTransaction;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
        }
        
        /// <summary>
        /// The MarketOrderReject Transaction that rejects the creation of the Trade-closing MarketOrder.
        /// </summary>
        /// <value>The MarketOrderReject Transaction that rejects the creation of the Trade-closing MarketOrder.</value>
        [DataMember(Name="orderRejectTransaction", EmitDefaultValue=false)]
        public MarketOrderRejectTransaction OrderRejectTransaction { get; set; }
        /// <summary>
        /// The code of the error that has occurred. This field may not be returned for some errors.
        /// </summary>
        /// <value>The code of the error that has occurred. This field may not be returned for some errors.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        /// <value>The human-readable description of the error that has occurred.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse4005 {\n");
            sb.Append("  OrderRejectTransaction: ").Append(OrderRejectTransaction).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(obj as InlineResponse4005);
        }

        /// <summary>
        /// Returns true if InlineResponse4005 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse4005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse4005 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderRejectTransaction == other.OrderRejectTransaction ||
                    this.OrderRejectTransaction != null &&
                    this.OrderRejectTransaction.Equals(other.OrderRejectTransaction)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                if (this.OrderRejectTransaction != null)
                    hash = hash * 59 + this.OrderRejectTransaction.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
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
