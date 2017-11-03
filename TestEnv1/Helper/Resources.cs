using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace TestEnv1.Helper
{
    public static class Resources
    {
        public static readonly ResourceLoader CodeResources = ResourceLoader.GetForCurrentView("Strings");
    }

}