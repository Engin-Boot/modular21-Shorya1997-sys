using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorCodingManual
    {
        public static void manual()
        {
            for(int i = 1; i <= 25; i++)
            {
                ColorPair testPair1 = ClassforGetColorFromPairNumber.GetColorFromPairNumber(i);
                Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n",i, testPair1);
            }
        }
    }
}
