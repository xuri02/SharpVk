// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

using System;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying a sparse buffer memory bind operation.
    /// </summary>
    public struct SparseBufferMemoryBindInfo
    {
        /// <summary>
        /// pname:buffer is the sname:VkBuffer object to be bound.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBinds is a pointer to array of sname:VkSparseMemoryBind
        /// structures.
        /// </summary>
        public SparseMemoryBind[] Binds
        {
            get;
            set;
        }
        
        internal unsafe Interop.SparseBufferMemoryBindInfo Pack()
        {
            Interop.SparseBufferMemoryBindInfo result = default(Interop.SparseBufferMemoryBindInfo);
            return result;
        }
        
        internal unsafe Interop.SparseBufferMemoryBindInfo* MarshalTo()
        {
            var result = (Interop.SparseBufferMemoryBindInfo*)Interop.HeapUtil.Allocate<Interop.SparseBufferMemoryBindInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.SparseBufferMemoryBindInfo* pointer)
        {
            pointer->Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
            
            //Binds
            if (this.Binds != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseMemoryBind>();
                IntPtr fieldPointer = Interop.HeapUtil.Allocate<Interop.SparseMemoryBind>(this.Binds.Length);
                for (int index = 0; index < this.Binds.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Binds[index].Pack(), fieldPointer + (size * index), false);
                }
                pointer->Binds = (Interop.SparseMemoryBind*)fieldPointer.ToPointer();
            }
            else
            {
                pointer->Binds = null;
            }
            pointer->BindCount = (uint)(this.Binds?.Length ?? 0);
        }
    }
}
