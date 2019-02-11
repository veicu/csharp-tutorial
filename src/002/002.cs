/*
    value types.
*/

namespace P002
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Boolean types
            //

            bool boolVar = true;                       // System.Boolean  TRUE or FALSE

            boolVar = false;


            //
            // Integer types
            //

            byte   byteVar   = 255;                    // System.Byte     8 - bit unsigned integer        0 to 255
            sbyte  sbyteVar  = 127;                    // System.SByte    8 - bit signed   integer type  -128 to 127
            short  shortVar  = 32767;                  // System.Int16   16 - bit signed   integer type
            ushort ushortVar = 65535;                  // System.UInt16  16 - bit unsigned integer type
            int    intVar    = 2147483647;             // System.Int32   32 - bit signed   integer type
            uint   uintVar   = 4294967295;             // System.UInt32  32 - bit unsigned integer type
            long   longVar   = 9223372036854775807;    // System.Int64   64 - bit signed   integer type
            ulong  ulongVar  = 18446744073709551615;   // System.UInt64  64 - bit unsigned integer type

            byteVar   =  0;
            sbyteVar  = -128;
            shortVar  = -32768;
            ushortVar =  0;
            intVar    = -2147483648;
            uintVar   =  0;
            longVar   = -9223372036854775808;
            ulongVar  =  0;


            //
            // Floating-point types
            //

            decimal decimalVar = 123456789.123456789M; // System.Decimal  128 - bit precise decimal values with 28 - 29 significant digits
            double  doubleVar  = 123456789.123456789;  // System.Double    64 - bit double-precision floating point type
            float   floatVar   = 12345.12345F;         // System.Single    32 - bit single-precision floating point type

            decimalVar = -123456789.123456789M;
            doubleVar  = -123456789.123456789;
            floatVar   = -12345.12345F;


            //
            // Character types
            //

            char charVar = 'A';                        // System.Char  16 - bit unicode character

            charVar = 'X';      // character literal
            charVar = '\x0058'; // hexadecimal
            charVar = (char)88; // cast from integral type
            charVar = '\u0058'; // unicode


            //
            // Exemplary use of variables
            //

            int i;
            i = 10;
            i = 10 + 20;
            i = i + 5;


            //
            // Print size of variable types
            //

            System.Console.WriteLine("Size of short  : {0} bytes", sizeof(short));
            System.Console.WriteLine("Size of int    : {0} bytes", sizeof(int));
            System.Console.WriteLine("Size of long   : {0} bytes", sizeof(long));
            System.Console.WriteLine("Size of float  : {0} bytes", sizeof(float));
            System.Console.WriteLine("Size of double : {0} bytes", sizeof(double));
            System.Console.ReadLine();
        }
    }
}
