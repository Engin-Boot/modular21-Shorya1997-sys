using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class classMain
    {
        public static void Main(string[] args)
        {

            ColorPair testPair1 = ClassforGetColorFromPairNumber.GetColorFromPairNumber(4);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", 4, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);


            testPair1 = ClassforGetColorFromPairNumber.GetColorFromPairNumber(5);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", 5, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            int pairNumber = 23;
            testPair1 = ClassforGetColorFromPairNumber.GetColorFromPairNumber(23);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", 23, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = ClassforGetPairNumberFromColor.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = ClassforGetPairNumberFromColor.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);

            ColorCodingManual.manual();
        }
    }
}
