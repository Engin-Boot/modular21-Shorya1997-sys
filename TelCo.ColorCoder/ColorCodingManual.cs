using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
   
    class ColorCodingManual
    {
        const int numberofpairs=25;

        public static void manual()
        {
            for(int i = 1; i <= numberofpairs; i++)
            {
                ColorPair testPair1 = ClassforGetColorFromPairNumber.GetColorFromPairNumber(i);
                Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n",i, testPair1);
            }
        }
    }
}
