namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*====================   1 ========================*/



            /*Console.Write("Please Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine( num + " is Positive");
            }
            else if(num<0)
            {
                Console.WriteLine( num + " is Negative");
            }
            else
            {
                Console.WriteLine("This number is zero ");*/


            /*====================   2 ========================*/


            /*Console.Write("Please Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {

                Console.WriteLine(  number + " is Even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine( number + " is Odd");
            }*/


            /*====================   3 ========================*/

            Console.Write("Please Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Please Enter width : ");
            int width = int.Parse(Console.ReadLine());
            if (length==width)
            {
                Console.WriteLine("Square");
            }
            else
            {
                Console.WriteLine("not Square");
            }
        }
    }
    
}
