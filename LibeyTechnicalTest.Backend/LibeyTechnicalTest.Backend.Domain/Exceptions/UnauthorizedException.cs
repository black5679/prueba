﻿using System.Runtime.Serialization;

namespace LibeyTechnicalTest.Backend.Domain.Exceptions
{
    [Serializable]
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException()
        {
        }

        public UnauthorizedException(string message)
            : base(message)
        {
        }

        public UnauthorizedException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected UnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
