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

    /// <summary>
    /// Virus positively identified
    /// </summary>
    public partial class FileOKResponseFoundVirusesItem
    {
        /// <summary>
        /// Initializes a new instance of the FileOKResponseFoundVirusesItem
        /// class.
        /// </summary>
        public FileOKResponseFoundVirusesItem() { }

        /// <summary>
        /// Initializes a new instance of the FileOKResponseFoundVirusesItem
        /// class.
        /// </summary>
        public FileOKResponseFoundVirusesItem(string fileName = default(string), string virusName = default(string))
        {
            FileName = fileName;
            VirusName = virusName;
        }

        /// <summary>
        /// Name of the file containing the virus
        /// </summary>
        [JsonProperty(PropertyName = "FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Name of the virus that was found
        /// </summary>
        [JsonProperty(PropertyName = "VirusName")]
        public string VirusName { get; set; }

    }
}
