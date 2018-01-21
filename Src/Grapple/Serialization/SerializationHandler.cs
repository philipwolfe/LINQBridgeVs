﻿#region License
// Copyright (c) 2013 Giovanni Campo
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion


using System;
using System.IO;

namespace Grapple.Serialization
{
    internal abstract class SerializationHandler : IServiceSerializer
    {
        protected SerializationHandler Successor;

        public void SetSuccessor(SerializationHandler successor)
        {
            Successor = successor;
        }

        public abstract void Serialize<T>(Stream aStream, T objToSerialize);
        public abstract byte[] Serialize<T>(T objToSerialize);
        public abstract T Deserialize<T>(Stream aStream);
        public abstract T Deserialize<T>(byte[] objToDeserialize);
        public abstract object Deserialize(byte[] objToDeserialize, Type type = null);
    }
}
