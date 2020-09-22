using System;
using System.Collections.Generic;
using System.Text;

namespace NieuweCsharpFunctionaliteiten.Extensions
{
    public static class IntExtensions
    {
        //methods must also  be public static
        //divide by two
        public static float DivideByTwo(this int number)
        {
            return (float)number / 2;
        }
        //Divide by user input number
        public static float DivideByNumber
            (this int number,int divider)
        {
            return (float)number / divider;
        }

    }
}
