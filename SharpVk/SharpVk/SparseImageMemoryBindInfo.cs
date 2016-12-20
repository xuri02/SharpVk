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
    /// Structure specifying sparse image memory bind info.
    /// </summary>
    public struct SparseImageMemoryBindInfo
    {
        /// <summary>
        /// pname:image is the sname:VkImage object to be bound
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBinds is a pointer to array of sname:VkSparseImageMemoryBind
        /// structures
        /// </summary>
        public SparseImageMemoryBind[] Binds
        {
            get;
            set;
        }
        
        internal unsafe Interop.SparseImageMemoryBindInfo Pack()
        {
            Interop.SparseImageMemoryBindInfo result = default(Interop.SparseImageMemoryBindInfo);
            return result;
        }
        
        internal unsafe Interop.SparseImageMemoryBindInfo* MarshalTo()
        {
            var result = (Interop.SparseImageMemoryBindInfo*)Interop.HeapUtil.Allocate<Interop.SparseImageMemoryBindInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.SparseImageMemoryBindInfo* pointer)
        {
            pointer->Image = this.Image?.Pack() ?? Interop.Image.Null;
            
            //Binds
            if (this.Binds != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseImageMemoryBind>();
                IntPtr fieldPointer = Interop.HeapUtil.Allocate<Interop.SparseImageMemoryBind>(this.Binds.Length);
                for (int index = 0; index < this.Binds.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Binds[index].Pack(), fieldPointer + (size * index), false);
                }
                pointer->Binds = (Interop.SparseImageMemoryBind*)fieldPointer.ToPointer();
            }
            else
            {
                pointer->Binds = null;
            }
            pointer->BindCount = (uint)(this.Binds?.Length ?? 0);
        }
    }
}
