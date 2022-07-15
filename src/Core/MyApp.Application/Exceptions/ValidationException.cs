using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException():this("Validation Exception Occur")
        {
        }

        public ValidationException(string msg):base(msg)
        {       
        }        
        public ValidationException(Exception ex):base(ex.Message)
        {
        }
    }
}
