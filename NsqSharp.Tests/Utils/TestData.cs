﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NsqSharp.Tests.Utils
{
    [Serializable]
    public class TestData<TInput, TOutput> : Dictionary<TInput, Result<TOutput>>
    {
        public TestData()
        {
        }

        protected TestData(SerializationInfo info, StreamingContext context)
        {
        }
    }
}
