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
    /// Location of one face in an image
    /// </summary>
    public partial class LocateOKResponseFacesItem
    {
        /// <summary>
        /// Initializes a new instance of the LocateOKResponseFacesItem class.
        /// </summary>
        public LocateOKResponseFacesItem() { }

        /// <summary>
        /// Initializes a new instance of the LocateOKResponseFacesItem class.
        /// </summary>
        public LocateOKResponseFacesItem(int? leftX = default(int?), int? topY = default(int?), int? rightX = default(int?), int? bottomY = default(int?))
        {
            LeftX = leftX;
            TopY = topY;
            RightX = rightX;
            BottomY = bottomY;
        }

        /// <summary>
        /// X coordinate of the left side of the face
        /// </summary>
        [JsonProperty(PropertyName = "LeftX")]
        public int? LeftX { get; set; }

        /// <summary>
        /// Y coordinate of the top side of the face
        /// </summary>
        [JsonProperty(PropertyName = "TopY")]
        public int? TopY { get; set; }

        /// <summary>
        /// X coordinate of the right side of the face
        /// </summary>
        [JsonProperty(PropertyName = "RightX")]
        public int? RightX { get; set; }

        /// <summary>
        /// Y coordinate of the bottom side of the face
        /// </summary>
        [JsonProperty(PropertyName = "BottomY")]
        public int? BottomY { get; set; }

    }
}