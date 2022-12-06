using System.Collections;

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
        
        //Find Max
        static int getMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }

            int max = arr[0];

            for (int m = 1; m < arr.Length; m++)
            {
                if (arr[m] > max)
                {
                    max = arr[m];
                }
            }

            return max;
        }

        static double getAvg(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return Math.Round(sum / arr.Length, 2);
        }

        static ArrayList getOddNumbers1To255()
        {
            ArrayList oddNumerList = new ArrayList();
            for (int i = 1 ; i < 256 ; i+= 2)
            {
                oddNumerList.Add(i);
            }

            return oddNumerList;

        }
        public static void Main()
        {
            //print1To255();
            //printOddNum1To255();
            //printSum();

            int[] arrOne = { 1, 3, 5, 7, 9, 13 };
            int[] arrTwo = { -3, -5, -7 };
            int[] arrThree = { 2, 9, -3, 4, -5 };
            int[] arrfour = { 2, 10, 3 };
            //printAllItemsInArray(arrOne);
            //Console.WriteLine(getMax(arrOne));
            //Console.WriteLine(getMax(arrTwo));
            //Console.WriteLine(getMax(arrThree));
            //Console.WriteLine(getAvg(arrfour));
            //Console.WriteLine(getAvg(arrTwo));
            //Console.WriteLine(getAvg(arrThree));
            foreach (int i in getOddNumbers1To255())
            {
                System.Console.WriteLine(i);
            }
        }
    }
}