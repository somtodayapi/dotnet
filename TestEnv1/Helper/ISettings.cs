using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnv1.Helper
{
    public interface ISettings
    {
  
        string SomRefreshToken { get; set; }

        string Password { get; set; }

        string Username { get; set; }
        string UUId { get; set; }

    }

}