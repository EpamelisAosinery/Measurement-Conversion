using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Converter
    {
        private static LengthConverter lengthConverter = new LengthConverter();
        private static TemperatureConverter temperatureConverter = new TemperatureConverter();
        
        public static Object convert(string measurement, string fromUnit, string toUnit, double input)
        {
            // if measurement is ...
            if (measurement.Equals("Length"))
            {
                Length from = (Length)Enum.Parse(typeof(Length), fromUnit);
                Length to = (Length)Enum.Parse(typeof(Length), toUnit);
                return lengthConverter.Convert(input, from, to);
            }
            if (measurement.Equals("Temperature"))
            {
                Temperature from =  (Temperature) Enum.Parse(typeof(Temperature), fromUnit);
                Temperature to = (Temperature)Enum.Parse(typeof(Temperature), toUnit);
                return temperatureConverter.Convert(input, from, to);
            }
            
            throw new Exception("measure not supported");
        }
    }
}
