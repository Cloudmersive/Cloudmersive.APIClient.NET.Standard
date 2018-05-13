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
    /// Face operations.
    /// </summary>
    public partial interface IFace
    {
        /// <summary>
        /// Find faces in an image
        /// </summary>
        /// Locate the positions of all faces in an image
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
        Task<HttpOperationResponse<LocateOKResponse>> LocateWithHttpMessagesAsync(System.IO.Stream imageFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Crop image to face (square)
        /// </summary>
        /// Crop an image to the face (rectangular crop).  If there is more
        /// than one face present, choose the first one.
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
        Task<HttpOperationResponse<System.IO.Stream>> CropFirstWithHttpMessagesAsync(System.IO.Stream imageFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Crop image to face (round)
        /// </summary>
        /// Crop an image to the face (circular/round crop).  If there is more
        /// than one face present, choose the first one.
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
        Task<HttpOperationResponse<System.IO.Stream>> CropFirstRoundWithHttpMessagesAsync(System.IO.Stream imageFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}