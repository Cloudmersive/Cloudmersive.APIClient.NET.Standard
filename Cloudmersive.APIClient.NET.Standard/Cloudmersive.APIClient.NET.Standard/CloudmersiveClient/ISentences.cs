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
    /// Sentences operations.
    /// </summary>
    public partial interface ISentences
    {
        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// Segment an input string into separate sentences, output result as
        /// a string.
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PostOKResponse>> PostWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
