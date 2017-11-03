using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnv1.Helper
{


    public enum UpdateStatus

    {

        //No internet connection

        NoInternet,

        //no update available

        NoUpdate,

        //Update is available and user can choose if he start update

        UpdateAvailable,

        //Update is available and will be installed without user permission

        UpdateForced,

        //This version is old, but update is not ready yet

        NextVersionNotReady



    }

}