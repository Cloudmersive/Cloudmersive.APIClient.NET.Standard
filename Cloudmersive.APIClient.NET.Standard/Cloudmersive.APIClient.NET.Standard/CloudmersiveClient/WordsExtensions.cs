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
    /// Extension methods for Words.
    /// </summary>
    public static partial class WordsExtensions
    {
            /// <summary>
            /// Get words from string
            /// </summary>
            /// Segment an input string into its component words
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static string GetWordsString(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).GetWordsStringAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get words from string
            /// </summary>
            /// Segment an input string into its component words
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetWordsStringAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWordsStringWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get words in input string (JSON)
            /// </summary>
            /// Get the component words in an input string, formatted as JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// String to process
            /// </param>
            public static GetWordsJsonOKResponse GetWordsJson(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).GetWordsJsonAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get words in input string (JSON)
            /// </summary>
            /// Get the component words in an input string, formatted as JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// String to process
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetWordsJsonOKResponse> GetWordsJsonAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWordsJsonWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the verbs in a string
            /// </summary>
            /// Get all of the verbs in the input string.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static PostOKResponse Post(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).PostAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the verbs in a string
            /// </summary>
            /// Get all of the verbs in the input string.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PostOKResponse> PostAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get proper nouns in a string
            /// </summary>
            /// Returns all of the proper nouns in a string.  Proper nouns are named
            /// entities such as "Hilton".
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static string ProperNouns(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).ProperNounsAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get proper nouns in a string
            /// </summary>
            /// Returns all of the proper nouns in a string.  Proper nouns are named
            /// entities such as "Hilton".
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ProperNounsAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ProperNounsWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get nouns in string
            /// </summary>
            /// Returns all of the nouns in the input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static string Nouns(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).NounsAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get nouns in string
            /// </summary>
            /// Returns all of the nouns in the input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> NounsAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.NounsWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adverbs in input string
            /// </summary>
            /// Returns all adverb words in the input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static string Adverbs(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).AdverbsAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adverbs in input string
            /// </summary>
            /// Returns all adverb words in the input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> AdverbsAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AdverbsWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all pronounts in string
            /// </summary>
            /// Returns all pronouns in the input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static string Pronouns(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).PronounsAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all pronounts in string
            /// </summary>
            /// Returns all pronouns in the input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> PronounsAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PronounsWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adjectives in string
            /// </summary>
            /// Retrieves all adjectives in input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            public static string Adjectives(this IWords operations, string input)
            {
                return Task.Factory.StartNew(s => ((IWords)s).AdjectivesAsync(input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adjectives in string
            /// </summary>
            /// Retrieves all adjectives in input string
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> AdjectivesAsync(this IWords operations, string input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AdjectivesWithHttpMessagesAsync(input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}