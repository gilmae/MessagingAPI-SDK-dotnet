/* 
 * Telstra Messaging API
 *
 *  The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 
 *
 * OpenAPI spec version: 2.2.4
 * 
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
using SwaggerDateConverter = com.telstra.messaging.Client.SwaggerDateConverter;

namespace com.telstra.messaging.Model
{
    /// <summary>
    /// ErrorErrorError62
    /// </summary>
    [DataContract]
    public partial class ErrorErrorError62 :  IEquatable<ErrorErrorError62>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorErrorError62" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorErrorError62() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorErrorError62" /> class.
        /// </summary>
        /// <param name="Status">A short error code (required).</param>
        /// <param name="Message">Message describing the error..</param>
        public ErrorErrorError62(string Status = default(string), string Message = default(string))
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ErrorErrorError62 and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.Message = Message;
        }
        
        /// <summary>
        /// A short error code
        /// </summary>
        /// <value>A short error code</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Message describing the error.
        /// </summary>
        /// <value>Message describing the error.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorErrorError62 {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorErrorError62);
        }

        /// <summary>
        /// Returns true if ErrorErrorError62 instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorErrorError62 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorErrorError62 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
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