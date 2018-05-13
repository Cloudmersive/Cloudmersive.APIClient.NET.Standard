﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Cloudmersive
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Nsfw operations.
    /// </summary>
    public partial interface INsfw
    {
        /// <summary>
        /// NSFW image classifier
        /// </summary>
        /// Classify an image into Not Safe For Work (NSFW)/Porn/Racy content
        /// and Safe Content.
        /// <param name='imageFile'>
        /// Image file to perform the operation on.  Common file formats such
        /// as PNG, JPEG are supported.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ClassifyOKResponse>> ClassifyWithHttpMessagesAsync(System.IO.Stream imageFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}