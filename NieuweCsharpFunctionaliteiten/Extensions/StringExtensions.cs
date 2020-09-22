using System;
using System.Collections.Generic;
using System.Text;

namespace NieuweCsharpFunctionaliteiten.Extensions
{
    public static class StringExtensions
    {
        public static int CountChars(this string input)
        {
            return input.Length;
        }
    }
}
