﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Cloudmersive
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for ImageOcr.
    /// </summary>
    public static partial class ImageOcrExtensions
    {
            /// <summary>
            /// Converts an uploaded image in common formats such as JPEG, PNG into text
            /// via Optical Character Recognition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='imageFile'>
            /// Image file to perform OCR on.  Common file formats such as PNG, JPEG are
            /// supported.
            /// </param>
            public static PostOKResponse Post(this IImageOcr operations, System.IO.Stream imageFile)
            {
                return Task.Factory.StartNew(s => ((IImageOcr)s).PostAsync(imageFile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Converts an uploaded image in common formats such as JPEG, PNG into text
            /// via Optical Character Recognition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='imageFile'>
            /// Image file to perform OCR on.  Common file formats such as PNG, JPEG are
            /// supported.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PostOKResponse> PostAsync(this IImageOcr operations, System.IO.Stream imageFile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(imageFile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
