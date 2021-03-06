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
    /// Words operations.
    /// </summary>
    public partial interface IWords
    {
        /// <summary>
        /// Get words from string
        /// </summary>
        /// Segment an input string into its component words
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> GetWordsStringWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get words in input string (JSON)
        /// </summary>
        /// Get the component words in an input string, formatted as JSON
        /// <param name='input'>
        /// String to process
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetWordsJsonOKResponse>> GetWordsJsonWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the verbs in a string
        /// </summary>
        /// Get all of the verbs in the input string.
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
        /// <summary>
        /// Get proper nouns in a string
        /// </summary>
        /// Returns all of the proper nouns in a string.  Proper nouns are
        /// named entities such as "Hilton".
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> ProperNounsWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get nouns in string
        /// </summary>
        /// Returns all of the nouns in the input string
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> NounsWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get adverbs in input string
        /// </summary>
        /// Returns all adverb words in the input string
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> AdverbsWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all pronounts in string
        /// </summary>
        /// Returns all pronouns in the input string
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PronounsWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get adjectives in string
        /// </summary>
        /// Retrieves all adjectives in input string
        /// <param name='input'>
        /// Input string
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> AdjectivesWithHttpMessagesAsync(string input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
