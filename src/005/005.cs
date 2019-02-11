/*

*/

namespace P005
{
    class Shape
    {
        //
        // constructors
        //

        public Shape()
        {
            m_x_pos = 0;
            m_y_pos = 0;
        }

        public Shape( int x, int y )
        {
            m_x_pos = x;
            m_y_pos = y;
        }

        //
        // properties
        //

        public int x
        {
            get { return m_x_pos; }
            set { m_x_pos = value; }
        }

        public int y
        {
            get { return m_y_pos; }
            set { m_y_pos = value; }
        }

        //
        // fields
        //

        private int m_x_pos;
        private int m_y_pos;
    }

    class Rect : Shape
    {
        //
        // constructors
        //

        public Rect() : base()
        {
            m_width = 0;
            m_height = 0;
        }

        public Rect( int width, int height ) : base()
        {
            m_width = width;
            m_height = height;
        }

        public Rect(int x, int y, int width, int height) : base(x, y)
        {
            m_width = width;
            m_height = height;
        }

        //
        // properties
        //

        public int Width
        {
            get { return m_width; }
            set { m_width = value; }
        }

        public int Height
        {
            get { return m_height; }
            set { m_height = value; }
        }

        //
        // fields
        //

        private int m_width;
        private int m_height;
    }


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

        // indexer property
        public double this [string unit]
        {
            get
            {
                switch(unit)
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

        // indexer property
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
            Rect r1 = new Rect(0, 0, 100, 50);

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
