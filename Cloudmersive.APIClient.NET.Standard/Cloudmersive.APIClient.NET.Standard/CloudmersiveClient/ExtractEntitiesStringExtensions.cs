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
    /// Extension methods for ExtractEntitiesString.
    /// </summary>
    public static partial class ExtractEntitiesStringExtensions
    {
            /// <summary>
            /// Extract entities from string
            /// </summary>
            /// Extract the named entitites from an input string.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input string
            /// </param>
            public static PostOKResponse Post(this IExtractEntitiesString operations, string value)
            {
                return Task.Factory.StartNew(s => ((IExtractEntitiesString)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Extract entities from string
            /// </summary>
            /// Extract the named entitites from an input string.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PostOKResponse> PostAsync(this IExtractEntitiesString operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}