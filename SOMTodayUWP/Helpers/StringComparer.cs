using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int xVal, yVal;
            var xIsVal = int.TryParse(x, out xVal);
            var yIsVal = int.TryParse(y, out yVal);

            if (xIsVal && yIsVal)   
                return xVal.CompareTo(yVal);
            if (!xIsVal && !yIsVal)
                return x.CompareTo(y);
            if (xIsVal)             
                return -1;
            return 1;             
        }

    }
}