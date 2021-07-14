using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorUtillclass
    {
        
        private static Color[] colorMapMajor;
        
        private static Color[] colorMapMinor;
        
        
        static ColorUtillclass()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        public static Color getcolorMapMajor(int index){return colorMapMajor[index];}

        public static int getcolorMapMajorlen(){return colorMapMajor.Length;}

        public static Color getcolorMapMinor(int index){return colorMapMinor[index];}

        public static int getcolorMapMinorlen(){return colorMapMinor.Length;}

        public static Color getcolorMap(int index,bool majororminor)
        {
            return majororminor == true ? getcolorMapMajor(index) : getcolorMapMinor(index);
        }



    }
}