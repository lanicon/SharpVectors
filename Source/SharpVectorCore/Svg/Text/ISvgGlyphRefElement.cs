﻿namespace SharpVectors.Dom.Svg
{
    /// <summary>
    /// The ISvgGlyphRefElement interface corresponds to the 'glyphRef' element. 
    /// </summary>
    public interface ISvgGlyphRefElement : ISvgElement, ISvgUriReference, ISvgStylable
    {
        /// <summary>
        /// Corresponds to attribute 'glyphRef attribute' on the given element.
        /// </summary>
        /// <remarks>It is read only attribute</remarks>
        string GlyphRef { get; set;}

        /// <summary>
        /// Corresponds to attribute 'format' on the given element.
        /// </summary>
        /// <remarks>It is read only attribute</remarks>
        string Format { get; set;}

        /// <summary>
        /// Corresponds to attribute 'x' on the given element.
        /// </summary>
        /// <remarks>It is read only attribute</remarks>
        float X { get; set;}

        /// <summary>
        /// Corresponds to attribute 'y' on the given element.
        /// </summary>
        /// <remarks>It is read only attribute</remarks>
        float Y { get; set;}

        /// <summary>
        /// Corresponds to attribute 'dx' on the given element.
        /// </summary>
        /// <remarks>It is read only attribute</remarks>
        float Dx { get; set;}

        /// <summary>
        /// Corresponds to attribute 'dy' on the given element.
        /// </summary>
        /// <remarks>It is read only attribute</remarks>
        float Dy { get; set;}
    }
}

