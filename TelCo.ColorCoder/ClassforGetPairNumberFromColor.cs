using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
	public class ClassforGetPairNumberFromColor
	{
        internal static int GetPairNumberFromColor(ColorPair pair)
        {
            
            int majorIndex = -1;
           
            majorIndex = doforloop(ColorUtillclass.getcolorMapMajorlen(), pair.majorColor, true);
            
            int minorIndex = -1;
            
            minorIndex = doforloop(ColorUtillclass.getcolorMapMinorlen(), pair.minorColor,false);

            
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            
            return (majorIndex * ColorUtillclass.getcolorMapMinorlen()) + (minorIndex + 1);
        }

        internal static int doforloop(int len, Color pair,bool majororminor)
        {
            int index = -1;
            for (int i = 0; i < len; i++)
            {
                if (ColorUtillclass.getcolorMap(i,majororminor) == pair)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

    }
}
