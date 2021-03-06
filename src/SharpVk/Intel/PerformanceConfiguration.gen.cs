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

namespace SharpVk.Intel
{
    /// <summary>
    /// Device configuration for performance queries
    /// </summary>
    public class PerformanceConfiguration
    {
        internal readonly SharpVk.Interop.Intel.PerformanceConfiguration Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal PerformanceConfiguration(Device parent, SharpVk.Interop.Intel.PerformanceConfiguration handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Intel.PerformanceConfiguration RawHandle => Handle;
        
        /// <summary>
        /// </summary>
        public unsafe void Release()
        {
            try
            {
                SharpVk.Interop.Intel.VkPerformanceConfigurationINTELReleaseDelegate commandDelegate = commandCache.Cache.vkReleasePerformanceConfigurationINTEL;
                Result methodResult = commandDelegate(parent.Handle, Handle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
