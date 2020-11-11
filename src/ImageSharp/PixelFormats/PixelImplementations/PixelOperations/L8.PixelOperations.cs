// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Formats;

namespace SixLabors.ImageSharp.PixelFormats
{
    /// <content>
    /// Provides optimized overrides for bulk operations.
    /// </content>
    public partial struct L8
    {
        /// <summary>
        /// Provides optimized overrides for bulk operations.
        /// </summary>
        internal partial class PixelOperations : PixelOperations<L8>
        {
            /// <inheritdoc />
            public override PixelTypeInfo GetPixelTypeInfo()
                => PixelTypeInfo.Create<L8>(PixelAlphaRepresentation.None);
        }
    }
}
