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
    /// ConvertImage operations.
    /// </summary>
    public partial interface IConvertImage
    {
        /// <summary>
        /// Image format conversion
        /// </summary>
        /// Convert between over 100 file formats, including key formats such
        /// as Photoshop (PSD), PNG, JPG, GIF, NEF, and BMP.
        /// <param name='format1'>
        /// Input file format as a 3+ letter file extension.  Supported
        /// formats include AAI, ART, ARW, AVS, BPG, BMP, BMP2, BMP3, BRF,
        /// CALS, CGM, CIN, CMYK, CMYKA, CR2, CRW, CUR, CUT, DCM, DCR, DCX,
        /// DDS, DIB, DJVU, DNG, DOT, DPX, EMF, EPDF, EPI, EPS, EPS2, EPS3,
        /// EPSF, EPSI, EPT, EXR, FAX, FIG, FITS, FPX, GIF, GPLT, GRAY, HDR,
        /// HEIC, HPGL, HRZ, ICO, ISOBRL, ISBRL6, JBIG, JNG, JP2, JPT, J2C,
        /// J2K, JPEG/JPG, JXR, MAT, MONO, MNG, M2V, MRW, MTV, NEF, ORF, OTB,
        /// P7, PALM, PAM, PBM, PCD, PCDS, PCL, PCX, PEF, PES, PFA, PFB, PFM,
        /// PGM, PICON, PICT, PIX, PNG, PNG8, PNG00, PNG24, PNG32, PNG48,
        /// PNG64, PNM, PPM, PSB, PSD, PTIF, PWB, RAD, RAF, RGB, RGBA, RGF,
        /// RLA, RLE, SCT, SFW, SGI, SID, SUN, SVG, TGA, TIFF, TIM, UIL,
        /// VIFF, VICAR, VBMP, WDP, WEBP, WPG, X, XBM, XCF, XPM, XWD, X3F,
        /// YCbCr, YCbCrA, YUV
        /// </param>
        /// <param name='format2'>
        /// Output (convert to this format) file format as a 3+ letter file
        /// extension.  Supported formats include AAI, ART, ARW, AVS, BPG,
        /// BMP, BMP2, BMP3, BRF, CALS, CGM, CIN, CMYK, CMYKA, CR2, CRW, CUR,
        /// CUT, DCM, DCR, DCX, DDS, DIB, DJVU, DNG, DOT, DPX, EMF, EPDF,
        /// EPI, EPS, EPS2, EPS3, EPSF, EPSI, EPT, EXR, FAX, FIG, FITS, FPX,
        /// GIF, GPLT, GRAY, HDR, HEIC, HPGL, HRZ, ICO, ISOBRL, ISBRL6, JBIG,
        /// JNG, JP2, JPT, J2C, J2K, JPEG/JPG, JXR, MAT, MONO, MNG, M2V, MRW,
        /// MTV, NEF, ORF, OTB, P7, PALM, PAM, PBM, PCD, PCDS, PCL, PCX, PEF,
        /// PES, PFA, PFB, PFM, PGM, PICON, PICT, PIX, PNG, PNG8, PNG00,
        /// PNG24, PNG32, PNG48, PNG64, PNM, PPM, PSB, PSD, PTIF, PWB, RAD,
        /// RAF, RGB, RGBA, RGF, RLA, RLE, SCT, SFW, SGI, SID, SUN, SVG, TGA,
        /// TIFF, TIM, UIL, VIFF, VICAR, VBMP, WDP, WEBP, WPG, X, XBM, XCF,
        /// XPM, XWD, X3F, YCbCr, YCbCrA, YUV
        /// </param>
        /// <param name='inputFile'>
        /// Input file to perform the operation on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> ImageFormatConvertWithHttpMessagesAsync(string format1, string format2, System.IO.Stream inputFile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
