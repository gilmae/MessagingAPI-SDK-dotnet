/*
 * TelstraMessagingAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TelstraMessagingAPI.Standard.Http.Client;

using TelstraMessagingAPI.Standard.Models;
using TelstraMessagingAPI.Standard;
using TelstraMessagingAPI.Standard.Utilities;


namespace TelstraMessagingAPI.Standard.Exceptions
{
    public class ErrorErrorErrorErrorErrorException : APIException 
    {
        // These fields hold the values for the public properties.
        private int? status;
        private string message;

        /// <summary>
        /// The status code.
        /// </summary>
        [JsonProperty("status")]
        public int? Status 
        { 
            get 
            {
                return this.status; 
            } 
            private set 
            {
                this.status = value;
            }
        }

        /// <summary>
        /// Message describing the error.
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ErrorErrorErrorErrorErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 