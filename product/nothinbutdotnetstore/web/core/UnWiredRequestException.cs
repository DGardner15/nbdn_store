using System;
using System.Runtime.Serialization;

namespace nothinbutdotnetstore.web.core
{
    public class UnWiredRequestException : Exception
    {
   

        public UnWiredRequestException(string message) : base(message)
        {
        }

        public UnWiredRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnWiredRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}