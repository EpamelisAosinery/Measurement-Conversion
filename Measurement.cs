using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    enum Measurement
    {
        Length, Mass, Speed, Temperature, Time
    }

    enum Length
    {
        Kilometer, Meter, Centimeter, Millimeter, Micrometer, Nanometer, Mile, Yard, Foot, Inch
    }

    enum Mass
    {
        MetricTon, Kilogram, Gram, Milligram, Microgram, ImperialTon, USTon, Stone, Pound, Ounce
    }

    enum Speed
    {
        MPH, FPS, MPS, KPH, Knot
    }

    enum Temperature
    {
        Celsius, Fahrenheit, Kelvin
    }

    class LengthConverter : UnitConverter<Length, double>
    {
        static LengthConverter()
        {
            BaseUnit = Length.Kilometer;
            RegisterConversion(Length.Meter, v => v * Math.Pow(10,3), v => v / Math.Pow(10, 3));
            RegisterConversion(Length.Centimeter, v => v * Math.Pow(10,5), v => v / Math.Pow(10, 5));
            RegisterConversion(Length.Millimeter, v => v * Math.Pow(10, 6), v => v / Math.Pow(10, 6));
            RegisterConversion(Length.Micrometer, v => v * Math.Pow(10, 9), v => v / Math.Pow(10, 9));
            RegisterConversion(Length.Nanometer, v => v * Math.Pow(10, 12), v => v / Math.Pow(10, 12));
            RegisterConversion(Length.Mile, v => v * 0.62137, v => v * 1.6093);
            RegisterConversion(Length.Yard, v => v * 1093.61, v => v / 1093.61);
            RegisterConversion(Length.Foot, v => v * 3280.84, v => v / 3280.84);
            RegisterConversion(Length.Inch, v => v * 39370.08, v => v / 39370.08);
        }
    }

    class TemperatureConverter : UnitConverter<Temperature, double>
    {
        static TemperatureConverter()
        {
            BaseUnit = Temperature.Celsius;
            RegisterConversion(Temperature.Fahrenheit, v => (v * 9 / 5) + 32, v => (v - 32) * 5 / 9);
            RegisterConversion(Temperature.Kelvin, v => v + 273.15, v => v - 273.15);
        }
    }

    enum Time
    {
        Nanosecond, Microsecond, Gram, Millisecond, Second, Minute, Hour, Day, Week, Month, CalendarYear, Decade, Century
    }
}
