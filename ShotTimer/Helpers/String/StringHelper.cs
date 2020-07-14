using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.String
{
    public static class StringHelper
    {
        public static string GetTrimmedValueOrEmpty(string value) 
        {
            return string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : value.Trim();
        }
    }
}
