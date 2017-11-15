﻿namespace ImageCompressorLibrary
{
    public enum ImageQuality : short
    {
        /// <summary>
        /// Very Low Quality. Max Compress
        /// </summary>
        VeryLow = 1,
        /// <summary>
        /// Low Quality
        /// </summary>
        Low = 25,
        /// <summary>
        /// Medium Compress
        /// </summary>
        Medium = 50,
        /// <summary>
        /// Intermediate Compress
        /// </summary>
        Intermediate = 75,
        /// <summary>
        /// 0% Compressing
        /// </summary>
        UnCompress = 100
    }
}