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
    /// Extension methods for Recognize.
    /// </summary>
    public static partial class RecognizeExtensions
    {
            /// <summary>
            /// Describe an image in natural language
            /// </summary>
            /// Generate an English language text description of the image as a sentence.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='imageFile'>
            /// Image file to perform the operation on.  Common file formats such as PNG,
            /// JPEG are supported.
            /// </param>
            public static DescribeOKResponse Describe(this IRecognize operations, System.IO.Stream imageFile)
            {
                return Task.Factory.StartNew(s => ((IRecognize)s).DescribeAsync(imageFile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe an image in natural language
            /// </summary>
            /// Generate an English language text description of the image as a sentence.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='imageFile'>
            /// Image file to perform the operation on.  Common file formats such as PNG,
            /// JPEG are supported.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DescribeOKResponse> DescribeAsync(this IRecognize operations, System.IO.Stream imageFile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DescribeWithHttpMessagesAsync(imageFile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
