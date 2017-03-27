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
    /// InlineResponse20027
    /// </summary>
    [DataContract]
    public partial class InlineResponse20027 :  IEquatable<InlineResponse20027>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20027" /> class.
        /// </summary>
        /// <param name="TradeClientExtensionsModifyTransaction">The Transaction that updates the Trade&#39;s Client Extensions..</param>
        /// <param name="RelatedTransactionIDs">The IDs of all Transactions that were created while satisfying the request..</param>
        /// <param name="LastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        public InlineResponse20027(TradeClientExtensionsModifyTransaction TradeClientExtensionsModifyTransaction = default(TradeClientExtensionsModifyTransaction), List<TransactionID> RelatedTransactionIDs = default(List<TransactionID>), string LastTransactionID = default(string))
        {
            this.TradeClientExtensionsModifyTransaction = TradeClientExtensionsModifyTransaction;
            this.RelatedTransactionIDs = RelatedTransactionIDs;
            this.LastTransactionID = LastTransactionID;
        }
        
        /// <summary>
        /// The Transaction that updates the Trade&#39;s Client Extensions.
        /// </summary>
        /// <value>The Transaction that updates the Trade&#39;s Client Extensions.</value>
        [DataMember(Name="tradeClientExtensionsModifyTransaction", EmitDefaultValue=false)]
        public TradeClientExtensionsModifyTransaction TradeClientExtensionsModifyTransaction { get; set; }
        /// <summary>
        /// The IDs of all Transactions that were created while satisfying the request.
        /// </summary>
        /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
        [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=false)]
        public List<TransactionID> RelatedTransactionIDs { get; set; }
        /// <summary>
        /// The ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>The ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public string LastTransactionID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20027 {\n");
            sb.Append("  TradeClientExtensionsModifyTransaction: ").Append(TradeClientExtensionsModifyTransaction).Append("\n");
            sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
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
            return this.Equals(obj as InlineResponse20027);
        }

        /// <summary>
        /// Returns true if InlineResponse20027 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20027 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20027 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TradeClientExtensionsModifyTransaction == other.TradeClientExtensionsModifyTransaction ||
                    this.TradeClientExtensionsModifyTransaction != null &&
                    this.TradeClientExtensionsModifyTransaction.Equals(other.TradeClientExtensionsModifyTransaction)
                ) && 
                (
                    this.RelatedTransactionIDs == other.RelatedTransactionIDs ||
                    this.RelatedTransactionIDs != null &&
                    this.RelatedTransactionIDs.SequenceEqual(other.RelatedTransactionIDs)
                ) && 
                (
                    this.LastTransactionID == other.LastTransactionID ||
                    this.LastTransactionID != null &&
                    this.LastTransactionID.Equals(other.LastTransactionID)
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
                if (this.TradeClientExtensionsModifyTransaction != null)
                    hash = hash * 59 + this.TradeClientExtensionsModifyTransaction.GetHashCode();
                if (this.RelatedTransactionIDs != null)
                    hash = hash * 59 + this.RelatedTransactionIDs.GetHashCode();
                if (this.LastTransactionID != null)
                    hash = hash * 59 + this.LastTransactionID.GetHashCode();
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
