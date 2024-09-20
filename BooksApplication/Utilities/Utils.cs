using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApplication.Utilities
{
    public static class Utils
    {
        public static bool IsValidString(params string[] values) 
        {
            foreach (string value in values)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
