namespace Assignment;   
internal class Program
{
    private static void Main(string[] args)
    {
        #region Write a program that allows the user to enter a number then print it.
        //Console.WriteLine("Enter a Number: ");
        //string Num = Console.ReadLine();
        //Console.WriteLine(Num);
        #endregion


        #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

        int X = 5;
        int Y = 10;
        Y = X;  // X = 5 , Y = 5 
        X++;    // X = 6
        Console.WriteLine(X);
        Console.WriteLine(Y);
        #endregion


    }
}