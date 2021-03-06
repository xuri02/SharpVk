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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceToolProperties
    {
        /// <summary>
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public string Version
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ToolPurposeFlags Purposes
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public string Description
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public string Layer
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceToolProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceToolProperties* pointer)
        {
            PhysicalDeviceToolProperties result = default;
            result.Name = Interop.HeapUtil.MarshalStringFrom(pointer->Name, Constants.MaxExtensionNameSize, true);
            result.Version = Interop.HeapUtil.MarshalStringFrom(pointer->Version, Constants.MaxExtensionNameSize, true);
            result.Purposes = pointer->Purposes;
            result.Description = Interop.HeapUtil.MarshalStringFrom(pointer->Description, Constants.MaxDescriptionSize, true);
            result.Layer = Interop.HeapUtil.MarshalStringFrom(pointer->Layer, Constants.MaxExtensionNameSize, true);
            return result;
        }
    }
}
