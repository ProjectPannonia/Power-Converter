using System;
using System.Collections.Generic;
using System.Text;

namespace HpToKw
{
    class TypeParser
    {
        public static Units parseType(string text)
        {
            Units myEnum;
            switch (text)
            {
                case "Watt":
                    myEnum = Units.Watt;
                    break;
                case "Kilowatt":
                    myEnum = Units.Kilowatt;
                    break;
                case "Megawatt":
                    myEnum = Units.Megawatt;
                    break;
                case "Gigawatt":
                    myEnum = Units.Gigawatt;
                    break;
                case "Horse_power_metric":
                    myEnum = Units.Horse_power_metric;
                    break;
                case "Horse_power_electric":
                    myEnum = Units.Horse_power_electric;
                    break;
                default:
                    myEnum = Units.Watt;
                    break;
            }

            return myEnum;
        }
    }
}
