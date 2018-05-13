﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Cloudmersive.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ValueOperationsItem
    {
        /// <summary>
        /// Initializes a new instance of the ValueOperationsItem class.
        /// </summary>
        public ValueOperationsItem() { }

        /// <summary>
        /// Initializes a new instance of the ValueOperationsItem class.
        /// </summary>
        public ValueOperationsItem(int? action = default(int?), string matchAgsint = default(string), string replaceWith = default(string))
        {
            Action = action;
            MatchAgsint = matchAgsint;
            ReplaceWith = replaceWith;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Action")]
        public int? Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MatchAgsint")]
        public string MatchAgsint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReplaceWith")]
        public string ReplaceWith { get; set; }

    }
}