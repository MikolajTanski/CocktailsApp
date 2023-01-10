using System;

namespace Drinks_app.Exception
{
    public class NotFoundException : SystemException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}