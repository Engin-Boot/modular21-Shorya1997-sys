using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class Program
    {
        
        private static Color[] colorMapMajor;
        
        private static Color[] colorMapMinor;
        
        
        static Program()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        static public Color getcolorMapMajor(int index){return colorMapMajor[index];}

        static public int getcolorMapMajorlen(){return colorMapMajor.Length;}

        static public Color getcolorMapMinor(int index){return colorMapMinor[index];}

        static public int getcolorMapMinorlen(){return colorMapMinor.Length;}

        
    }
}