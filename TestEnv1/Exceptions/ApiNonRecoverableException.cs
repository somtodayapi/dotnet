using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnv1.Exceptions
{
    public class ApiNonRecoverableException : Exception

    {

        public ApiNonRecoverableException(string reason) : base(reason)

        {

        }

    }

}