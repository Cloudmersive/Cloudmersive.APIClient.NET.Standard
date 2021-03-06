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
    /// Extension methods for Resize.
    /// </summary>
    public static partial class ResizeExtensions
    {
            /// <summary>
            /// Resize an image with parameters
            /// </summary>
            /// Resize an image to a maximum width and maximum height, while preserving
            /// the image's original aspect ratio
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='maxWidth'>
            /// Maximum width of the output image - final image will be as large as
            /// possible while less than or equial to this width
            /// </param>
            /// <param name='maxHeight'>
            /// Maximum height of the output image - final image will be as large as
            /// possible while less than or equial to this height
            /// </param>
            /// <param name='imageFile'>
            /// Image file to perform the operation on.  Common file formats such as PNG,
            /// JPEG are supported.
            /// </param>
            public static object Post(this IResize operations, int maxWidth, int maxHeight, System.IO.Stream imageFile)
            {
                return Task.Factory.StartNew(s => ((IResize)s).PostAsync(maxWidth, maxHeight, imageFile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resize an image with parameters
            /// </summary>
            /// Resize an image to a maximum width and maximum height, while preserving
            /// the image's original aspect ratio
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='maxWidth'>
            /// Maximum width of the output image - final image will be as large as
            /// possible while less than or equial to this width
            /// </param>
            /// <param name='maxHeight'>
            /// Maximum height of the output image - final image will be as large as
            /// possible while less than or equial to this height
            /// </param>
            /// <param name='imageFile'>
            /// Image file to perform the operation on.  Common file formats such as PNG,
            /// JPEG are supported.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostAsync(this IResize operations, int maxWidth, int maxHeight, System.IO.Stream imageFile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(maxWidth, maxHeight, imageFile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
