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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GraphicsPipelineShaderGroupsCreateInfo
    {
        /// <summary>
        /// </summary>
        public GraphicsShaderGroupCreateInfo[] Groups
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public Pipeline[] Pipelines
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GraphicsPipelineShaderGroupsCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsPipelineShaderGroupsCreateInfo;
            pointer->Next = null;
            pointer->GroupCount = (uint)(Interop.HeapUtil.GetLength(Groups));
            if (Groups != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.GraphicsShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.GraphicsShaderGroupCreateInfo>(Groups.Length).ToPointer());
                for(int index = 0; index < (uint)(Groups.Length); index++)
                {
                    Groups[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Groups = fieldPointer;
            }
            else
            {
                pointer->Groups = null;
            }
            pointer->PipelineCount = (uint)(Interop.HeapUtil.GetLength(Pipelines));
            if (Pipelines != null)
            {
                var fieldPointer = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Pipeline>(Pipelines.Length).ToPointer());
                for(int index = 0; index < (uint)(Pipelines.Length); index++)
                {
                    fieldPointer[index] = Pipelines[index]?.Handle ?? default;
                }
                pointer->Pipelines = fieldPointer;
            }
            else
            {
                pointer->Pipelines = null;
            }
        }
    }
}
