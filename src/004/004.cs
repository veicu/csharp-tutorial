/*
    class basics
*/

namespace P004
{
    struct Point2D
    {
        //
        // constructors
        //

        //
        // a explicit (parameterless) standard constructor is not allowed for structs, it is generated implicitly
        //

        /*
        public Point2D()
        {
            m_x = 0;
            m_y = 0;
        }
        */

        public Point2D( int x, int y )
        {
            m_x = x;
            m_y = y;
        }

        //
        // properties
        //

        public int x
        {
            get { return m_x; }
            set { m_x = value; }
        }

        public int y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        //
        // fields (member variables) (only value types are allowed in structs)
        //

        private int m_x;
        private int m_y;
    }

    class Rectangle
    {
        //
        // constructors
        //

        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle( int width, int height )
        {
            this.width = width;
            this.height = height;
        }

        //
        // properties
        //

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //
        // methods
        //

        public int area()
        {
            return width * height;
        }

        //
        // fields (ordinary member variables)
        //

        private int width;
        private int height;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D();
            Point2D point2 = new Point2D();
            Point2D point3 = new Point2D(10,20);

            point2.x = 5;
            point2.y = 15;

            System.Console.WriteLine("point1 ({0}/{1})", point1.x, point1.y);
            System.Console.WriteLine("point2 ({0}/{1})", point2.x, point2.y);
            System.Console.WriteLine("point3 ({0}/{1})", point3.x, point3.y);

            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(10,20);

            System.Console.WriteLine("rect1 [{0}/{1}] => {2}", rect1.Width, rect1.Height, rect1.area());
            System.Console.WriteLine("rect2 [{0}/{1}] => {2}", rect2.Width, rect2.Height, rect2.area());

            System.Console.ReadLine();
        }
    }
}
