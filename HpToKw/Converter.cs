using System;
using System.Collections.Generic;
using System.Text;

namespace HpToKw
{
    public class Converter
    {
        public static double calculate(string from, string to, double value)
        {
            Units parsedFrom = TypeParser.parseType(from);
            Units parsedTo = TypeParser.parseType(to);
            double calculationResult = 0;

            switch(parsedFrom)
            {
                case Units.Watt:
                    calculationResult = wattConverter(parsedTo, value);
                    break;
                case Units.Kilowatt:
                    calculationResult = kilowattConverter(parsedTo, value);
                    break;
                case Units.Megawatt:
                    calculationResult = megawattConverter(parsedTo, value);
                    break;
                case Units.Gigawatt:
                    calculationResult = gigawattConverter(parsedTo, value);
                    break;
                case Units.Horse_power_metric:
                    calculationResult = metricHorsepowerConverter(parsedTo, value);
                    break;
                case Units.Horse_power_electric:
                    calculationResult = electricHorsepowerConverter(parsedTo, value);
                    break;
            }
            /*
            if (parsedFrom.Equals(Units.Watt))
            {
                calculationResult = wattConverter(parsedTo, value);
            }
            else if (parsedFrom.Equals(Units.Kilowatt))
            {
                calculationResult = kilowattConverter(parsedTo, value);
            }
            else if (parsedFrom.Equals(Units.Megawatt))
            {
                calculationResult = megawattConverter(parsedTo, value);
            }
            else if(parsedFrom.Equals(Units.Gigawatt))
            {
                calculationResult = gigawattConverter(parsedTo, value);
            }
            else if (parsedFrom.Equals(Units.Horse_power_metric))
            {
                calculationResult = metricHorsepowerConverter(parsedTo, value);
            } else if(parsedFrom.Equals(Units.Horse_power_electric))
            {
                calculationResult = electricHorsepowerConverter(parsedTo, value);
            }
            */
            return calculationResult;
        }
        // Watt to....
        private static double wattConverter(Units to, double value)
        {
            switch (to)
            {
                case Units.Kilowatt:
                    value /= 1000;
                    break;
                case Units.Megawatt:
                    value /= 1000000;
                    break;
                case Units.Gigawatt:
                    value /= 1000000000;
                    break;
                case Units.Horse_power_metric:
                    value *= 0.0013596211551613;
                    break;
                case Units.Horse_power_electric:
                    value *= 0.0013404825737265;
                    break;
            }
            return value;
        }
        // Kilowatt to...
        private static double kilowattConverter(Units to, double value)
        {
            switch (to)
            {
                case Units.Watt:
                    value *= 1000;
                    break;
                case Units.Megawatt:
                    value /= 1000;
                    break;
                case Units.Gigawatt:
                    value *= 1000000;
                    break;
                case Units.Horse_power_metric:
                    value /= 0.735499;
                    break;
                case Units.Horse_power_electric:
                    value *= 1.3404825737265;
                    break;
            }

            return value;
        }
        // Megawatt to....
        private static double megawattConverter(Units to, double value)
        {
            switch(to)
            {
                case Units.Watt:
                    value *= 1000000;
                    break;
                case Units.Kilowatt:
                    value *= 1000;
                    break;
                case Units.Gigawatt:
                    value *= 1000;
                    break;
                case Units.Horse_power_metric:
                    value *= 1359.6211551613;
                    break;
                case Units.Horse_power_electric:
                    value *= 1340.4825737265;
                    break;
            }
            return value;
        }
        // Gigawatt to...
        private static double gigawattConverter(Units to, double value)
        {
            switch(to)
            {
                case Units.Watt:
                    value *= 100000000;
                    break;
                case Units.Kilowatt:
                    value *= 100000;
                    break;
                case Units.Megawatt:
                    value *= 1000;
                    break;
                case Units.Horse_power_metric:
                    value *= 1359621.1551613;
                    break;
                case Units.Horse_power_electric:
                    value *= 1340482.5737265;
                    break;
            }
            return value;
        }
        // Metric horsePower to...
        private static double metricHorsepowerConverter(Units to, double value)
        {
            switch(to)
            {
                case Units.Watt:
                    value *= 735.499;
                    break;
                case Units.Kilowatt:
                    value *= 0.735499;
                    break;
                case Units.Megawatt:
                    value *= 0.000735499;
                    break;
                case Units.Gigawatt:
                    value *= 1359621.1551613;
                    break;
                case Units.Horse_power_electric:
                    value *= 0.9859235924933;
                    break;
            }
            return value;
        }
        // Electric horsepower to..
        private static double electricHorsepowerConverter(Units to, double value)
        {
            switch(to)
            {
                case Units.Watt:
                    value /= 0.0013404825737265;
                    break;
                case Units.Kilowatt:
                    value /= 1.3404825737265;
                    break;
                case Units.Megawatt:
                    value /= 1340.4825737265;
                    break;
                case Units.Gigawatt:
                    value *= 1340482.5737265;
                    break;
                case Units.Horse_power_metric:
                    value *= 0.9859235924933;
                    break;
            }
            return value;
        }
    }
}
