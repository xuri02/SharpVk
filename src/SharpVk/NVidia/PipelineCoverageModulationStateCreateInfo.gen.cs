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
    public struct PipelineCoverageModulationStateCreateInfo
    {
        /// <summary>
        /// </summary>
        public PipelineCoverageModulationStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public CoverageModulationMode CoverageModulationMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool CoverageModulationTableEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint? CoverageModulationTableCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public float[] CoverageModulationTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PipelineCoverageModulationStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineCoverageModulationStateCreateInfo;
            pointer->Next = null;
            if (Flags != null)
            {
                pointer->Flags = Flags.Value;
            }
            else
            {
                pointer->Flags = default;
            }
            pointer->CoverageModulationMode = CoverageModulationMode;
            pointer->CoverageModulationTableEnable = CoverageModulationTableEnable;
            if (CoverageModulationTableCount != null)
            {
                pointer->CoverageModulationTableCount = CoverageModulationTableCount.Value;
            }
            else
            {
                pointer->CoverageModulationTableCount = (uint)(Interop.HeapUtil.GetLength(CoverageModulationTable));
            }
            if (CoverageModulationTable != null)
            {
                var fieldPointer = (float*)(Interop.HeapUtil.AllocateAndClear<float>(CoverageModulationTable.Length).ToPointer());
                for(int index = 0; index < (uint)(CoverageModulationTable.Length); index++)
                {
                    fieldPointer[index] = CoverageModulationTable[index];
                }
                pointer->CoverageModulationTable = fieldPointer;
            }
            else
            {
                pointer->CoverageModulationTable = null;
            }
        }
    }
}
