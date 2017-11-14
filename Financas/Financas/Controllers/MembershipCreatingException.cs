using System;
using System.Runtime.Serialization;

namespace Financas.Controllers
{
    [Serializable]
    internal class MembershipCreatingException : Exception
    {
        public MembershipCreatingException()
        {
        }

        public MembershipCreatingException(string message) : base(message)
        {
        }

        public MembershipCreatingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MembershipCreatingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}