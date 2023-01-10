using System;

namespace Drinks_app.Exception
{
    public class BadRequestException : SystemException
    {
        public BadRequestException(string message) : base(message)
        {

        }
    }
}
