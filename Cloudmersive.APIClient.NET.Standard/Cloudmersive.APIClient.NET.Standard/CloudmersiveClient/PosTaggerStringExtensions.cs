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
    /// Extension methods for PosTaggerString.
    /// </summary>
    public static partial class PosTaggerStringExtensions
    {
            /// <summary>
            /// Part-of-speech tag a string
            /// </summary>
            /// Perform a part-of-speech (POS) tagging on the input string.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static PostOKResponse Post(this IPosTaggerString operations, string input)
            {
                return Task.Factory.StartNew(s => ((IPosTaggerString)s).PostAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Part-of-speech tag a string
            /// </summary>
            /// Perform a part-of-speech (POS) tagging on the input string.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PostOKResponse> PostAsync(this IPosTaggerString operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}