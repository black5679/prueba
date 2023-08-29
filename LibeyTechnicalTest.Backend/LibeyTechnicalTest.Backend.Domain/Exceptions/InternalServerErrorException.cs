﻿using System.Runtime.Serialization;

namespace LibeyTechnicalTest.Backend.Domain.Exceptions
{
    [Serializable]
    public class InternalServerErrorException : Exception
    {
        public InternalServerErrorException()
        {
        }

        public InternalServerErrorException(string message)
            : base(message)
        {
        }

        public InternalServerErrorException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected InternalServerErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
