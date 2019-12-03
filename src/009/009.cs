/*

*/

namespace P009
{
    enum LengthUnit
    {
        m,
        cm,
        inch
    }

    class Length
    {
        private double lengthInMeter;

        public Length()
        {
            lengthInMeter = 0;
        }

        public double Meter
        {
            get { return lengthInMeter; }
            set { lengthInMeter = value; }
        }

        public double CentiMeter
        {
            get { return lengthInMeter * 100; }
            set { lengthInMeter = value / 100; }
        }

        public double Inch
        {
            get { return lengthInMeter / 2.54; }
            set { lengthInMeter = value * 2.56; }
        }

        //
        // indexer property
        //

        public double this[string unit]
        {
            get
            {
                switch (unit)
                {
                    case "m":
                        return Meter;
                    case "cm":
                        return CentiMeter;
                    case "inch":
                        return Inch;
                }

                return 0;
            }

            set
            {
                switch (unit)
                {
                    case "m":
                        Meter = value;
                        break;
                    case "cm":
                        CentiMeter = value;
                        break;
                    case "inch":
                        Inch = value;
                        break;
                }
            }
        }

        //
        // indexer property
        //

        public double this[LengthUnit unit]
        {
            get
            {
                switch (unit)
                {
                    case LengthUnit.m:
                        return Meter;
                    case LengthUnit.cm:
                        return CentiMeter;
                    case LengthUnit.inch:
                        return Inch;
                }

                return 0;
            }

            set
            {
                switch (unit)
                {
                    case LengthUnit.m:
                        Meter = value;
                        break;
                    case LengthUnit.cm:
                        CentiMeter = value;
                        break;
                    case LengthUnit.inch:
                        Inch = value;
                        break;
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Length l1 = new Length();
            l1.Meter = 10.0;
            System.Console.WriteLine(l1.CentiMeter);

            l1["cm"] = 123;
            System.Console.WriteLine(l1.Meter);

            l1[LengthUnit.inch] = 200;
            System.Console.WriteLine(l1.Inch);
            System.Console.WriteLine(l1.Meter);

            Length l2 = new Length
            {
                Meter = 2.5
            };

            System.Console.ReadLine();
        }
    }
}
