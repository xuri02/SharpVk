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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineExecutableInternalRepresentation
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
        public string Description
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool IsText
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public byte[] Data
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PipelineExecutableInternalRepresentation MarshalFrom(SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation* pointer)
        {
            PipelineExecutableInternalRepresentation result = default;
            result.Name = Interop.HeapUtil.MarshalStringFrom(pointer->Name, Constants.MaxDescriptionSize, true);
            result.Description = Interop.HeapUtil.MarshalStringFrom(pointer->Description, Constants.MaxDescriptionSize, true);
            result.IsText = pointer->IsText;
            if (pointer->Data != null)
            {
                var fieldPointer = new byte[(uint)(pointer->DataSize)];
                for(int index = 0; index < (uint)(pointer->DataSize); index++)
                {
                    fieldPointer[index] = pointer->Data[index];
                }
                result.Data = fieldPointer;
            }
            else
            {
                result.Data = null;
            }
            return result;
        }
    }
}
