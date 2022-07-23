using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInCar.Exceptions
{
    public abstract class ExceptionsMessages : Exception
    {
        

        public ExceptionsMessages(string message) : base(message)
        {
           
        }

        public ExceptionsMessages(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
