namespace Demo
{
    internal class Program
    {
        //static int Sum(int x , int y)
        //{
        //    return x - y;
        //}
        static void Main(string[] args)
        {
            #region Error Types

            #region Syntax Error

            //console.WriteLine("hello");
            //iint x;

            #endregion

            #region RunTime Error
            //int X = 5;
            //int Y = 0;
            //Console.WriteLine(X/Y);
            #endregion

            #region Logical Error
            //int A = 10;
            //int B = 5;
            //Console.WriteLine(Sum(A, B));
            #endregion

            #region Warning
            // int X; // 4 byte
            #endregion


            #endregion

            #region Variables
            // 5 
            // int Number = 5; // 4 byte
            #endregion

            #region CTS - CLS
            //int x = 5 ; // 4Byte
            //String Name = "Ahmed";// 10Byte
            //    Name = "Ali";// 6 BYte

            #endregion

            #region Value Type
            //int X; // 4 Byte
            //X = 4;
            //int Y = 9;// 4 Byte
            //Y = X; // Y = 4
            //X++; // X = 5
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            #endregion

            #region Reference Type
            //Point P01;
            //P01 = new Point();

            //Point P02 = new Point();

            //P02 = P01;

            //P01.x = 10;
            //Console.WriteLine(P02.x);
            #endregion

            #region Object
            //Point P01 = new Point();
            //P01.
            object obj = new object();
            //obj = 1;
            //obj = "Hello";
            //obj = "A";
            //obj = true;
            //object obj02 = new object();
            //Console.WriteLine(obj.GetHashCode());
            //Console.WriteLine(obj02.GetHashCode());

            //obj02 = obj;
            //Console.WriteLine("****************");
            //Console.WriteLine(obj.GetHashCode());
            //Console.WriteLine(obj02.GetHashCode());
            #endregion

            #region Fractions and Discard
            //int Num01 = 12345644444;
            long Num02 = 12345644444;
            double Num03 = 22.2;
            float Num04 = 22.2F;
            decimal Num05 = 22.2m;

            int Num06 = 1_000_000;
            Console.WriteLine(Num06);

            #endregion

        }
    }
}
