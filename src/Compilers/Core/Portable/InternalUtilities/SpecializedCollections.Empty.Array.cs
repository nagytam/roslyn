﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class Empty
        {
            internal class Array<T>
            {
#pragma warning disable RS0007 // Avoid zero-length array allocations.
                public static readonly T[] Instance = new T[0];
#pragma warning restore RS0007 // Avoid zero-length array allocations.
            }
        }
    }
}
