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

namespace SharpVk.NVidia
{
    /// <summary>
    /// Structure specifying parameters of a newly created pipeline viewport W
    /// scaling state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineViewportWScalingStateCreateInfo
    {
        /// <summary>
        /// The enable for viewport W scaling
        /// </summary>
        public bool ViewportWScalingEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of ViewportWScalingNV structures which define the W
        /// scaling parameters for the corresponding viewport. If the viewport
        /// W scaling state is dynamic, this member is ignored.
        /// </summary>
        public ViewportWScaling[] ViewportWScalings
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PipelineViewportWScalingStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineViewportWScalingStateCreateInfo;
            pointer->Next = null;
            pointer->ViewportWScalingEnable = ViewportWScalingEnable;
            pointer->ViewportCount = (uint)(Interop.HeapUtil.GetLength(ViewportWScalings));
            if (ViewportWScalings != null)
            {
                var fieldPointer = (ViewportWScaling*)(Interop.HeapUtil.AllocateAndClear<ViewportWScaling>(ViewportWScalings.Length).ToPointer());
                for(int index = 0; index < (uint)(ViewportWScalings.Length); index++)
                {
                    fieldPointer[index] = ViewportWScalings[index];
                }
                pointer->ViewportWScalings = fieldPointer;
            }
            else
            {
                pointer->ViewportWScalings = null;
            }
        }
    }
}
