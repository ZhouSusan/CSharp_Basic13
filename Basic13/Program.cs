namespace Basic13
{
    public class Program
    {
        //Method that print all integer from 1 to 255
        static void print1To255 ()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Method that print odd number from 1 to 255
        static void printOddNum1To255()
        {
            for (int j = 1; j <= 255; j+=2)
            {
                Console.WriteLine(j);
            }
        }

        //Print Sum
        static void printSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("$New number: {0} Sum: {1}", i, sum);
            }
        }

        //Iterate through array
        static void printAllItemsInArray(int[] arr)
        {
            foreach(int i in arr)
            {
                System.Console.Write("{0} ", i);
            }    
        }
        
        public static void Main()
        {
            //print1To255();
            //printOddNum1To255();
            //printSum();

            int[] arrOne = { 1, 3, 5, 7, 9, 13 };
            printAllItemsInArray(arrOne);
        }
    }
}