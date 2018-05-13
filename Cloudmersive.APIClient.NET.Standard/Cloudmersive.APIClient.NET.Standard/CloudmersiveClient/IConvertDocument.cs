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
    /// ConvertDocument operations.
    /// </summary>
    public partial interface IConvertDocument
    {
        /// <summary>
        /// Word DOCX to PDF
        /// </summary>
        /// Convert Office Word Documents (docx) to standard PDF
        /// <param name='inputFile'>
        /// Input file to perform the operation on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> DocxToPdfWithHttpMessagesAsync(System.IO.Stream inputFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// PowerPoint PPTX to PDF
        /// </summary>
        /// Convert Office PowerPoint Documents (pptx) to standard PDF
        /// <param name='inputFile'>
        /// Input file to perform the operation on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> PptxToPdfWithHttpMessagesAsync(System.IO.Stream inputFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Excel XLSX to PDF
        /// </summary>
        /// Convert Office Excel Workbooks (xlsx) to standard PDF.  Converts
        /// all worksheets in the workbook to PDF.
        /// <param name='inputFile'>
        /// Input file to perform the operation on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> XlsxToPdfWithHttpMessagesAsync(System.IO.Stream inputFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Excel XLSX to CSV
        /// </summary>
        /// Convert Office Excel Workbooks (xlsx) to standard Comma-Separated
        /// Values (CSV) format.
        /// <param name='inputFile'>
        /// Input file to perform the operation on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> XlsxToCsvWithHttpMessagesAsync(System.IO.Stream inputFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Convert Document to PDF
        /// </summary>
        /// Automatically detect file type and convert it to PDF.
        /// <param name='inputFile'>
        /// Input file to perform the operation on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> AutodetectToPdfWithHttpMessagesAsync(System.IO.Stream inputFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}