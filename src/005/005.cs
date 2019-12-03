/*
    class inheritance
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

    class Program
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect();
            Rect r2 = new Rect();
            Rect r3 = new Rect(5, 10);
            Rect r4 = new Rect(55, 25, 100, 50);

            r2.x      = 10;
            r2.y      = 15;
            r2.Width  = 50;
            r2.Height = 25;

            System.Console.WriteLine("r1 [{0}/{1}/{2}/{3}]", r1.x, r1.y, r1.Width, r1.Height);
            System.Console.WriteLine("r2 [{0}/{1}/{2}/{3}]", r2.x, r2.y, r2.Width, r2.Height);
            System.Console.WriteLine("r3 [{0}/{1}/{2}/{3}]", r3.x, r3.y, r3.Width, r3.Height);
            System.Console.WriteLine("r4 [{0}/{1}/{2}/{3}]", r4.x, r4.y, r4.Width, r4.Height);

            System.Console.ReadLine();
        }
    }
}
