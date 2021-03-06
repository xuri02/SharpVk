// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System.Runtime.InteropServices;

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DisplayProperties
    {
        /// <summary>
        /// A handle that is used to refer to the display described here. This
        /// handle will be valid for the lifetime of the Vulkan instance.
        /// </summary>
        public Display Display; 
        
        /// <summary>
        /// A string containing the name of the display. Generally, this will
        /// be the name provided by the display's EDID. It can be Null if no
        /// suitable name is available.
        /// </summary>
        public byte* DisplayName; 
        
        /// <summary>
        /// physicalDimensions describes the physical width and height of the
        /// visible portion of the display, in millimeters.
        /// </summary>
        public Extent2D PhysicalDimensions; 
        
        /// <summary>
        /// physicalResolution describes the physical, native, or preferred
        /// resolution of the display.
        /// </summary>
        public Extent2D PhysicalResolution; 
        
        /// <summary>
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// </summary>
        public Bool32 PlaneReorderPossible; 
        
        /// <summary>
        /// </summary>
        public Bool32 PersistentContent; 
    }
}
