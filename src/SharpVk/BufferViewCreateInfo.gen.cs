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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying parameters of a newly created buffer view.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BufferViewCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public BufferViewCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// A Buffer on which the view will be created.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// A Format describing the format of the data elements in the buffer.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// An offset in bytes from the base address of the buffer. Accesses to
        /// the buffer view from shaders use addressing that is relative to
        /// this starting offset.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// A size in bytes of the buffer view. If range is equal to
        /// Constants.WholeSize, the range from offset to the end of the buffer
        /// is used. If Constants.WholeSize is used and the remaining size of
        /// the buffer is not a multiple of the element size of format, then
        /// the nearest smaller multiple is used.
        /// </summary>
        public ulong Range
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.BufferViewCreateInfo* pointer)
        {
            pointer->SType = StructureType.BufferViewCreateInfo;
            pointer->Next = null;
            if (Flags != null)
            {
                pointer->Flags = Flags.Value;
            }
            else
            {
                pointer->Flags = default;
            }
            pointer->Buffer = Buffer?.Handle ?? default;
            pointer->Format = Format;
            pointer->Offset = Offset;
            pointer->Range = Range;
        }
    }
}
