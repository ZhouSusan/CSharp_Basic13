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

        static ArrayList greaterThanY(int[] arr, int target)
        {
            ArrayList fiterArray = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > target)
                {
                    fiterArray.Add(arr[i]);
                }
            }
            return fiterArray;
        }

        static int[] squaresAllValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }

            return arr;
        }

        static int[] eliminateNegativeValues(int[] nums)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] < 0)
                {
                    nums[x] = 0;
                }
            }

            return nums;
        }

        static void getMinMaxAvg(int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("$Min: 0, Max: 0, Average: 0");
            }
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            Console.WriteLine("$Min: {0}, Max: {1}, Average: {2}\n", min, getMax(nums), getAvg(nums));

        }

        static int[] shiftingValuesInArray(int[] arr)
        {
            int s = 0;


            for (int r = 1; r < arr.Length; r++)
            {
                arr[s] = arr[r];
                s++;
            }
            arr[arr.Length - 1] = 0;
            return arr;
        } 

        static ArrayList numToString(int[] numsArr)
        {
            ArrayList numString = new ArrayList();
            for (int n = 0; n < numsArr.Length; n++)
            {
                if (numsArr[n] < 0)
                {
                    numString.Add("Dojo");
                } else
                {
                    numString.Add(numsArr[n]);
                }
            }

            return numString;
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
            int[] arrFive = { 1, 5, 10, -4 };
            int[] arrSix = { 1, 5, 10, -7, -2 };
            int[] arrSeven = { -1, -3, 2 };

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

            foreach (int j in greaterThanY(arrOne, 5))
            {
                System.Console.WriteLine(j);
            }

            //printAllItemsInArray(squaresAllValues(arrThree));
            //printAllItemsInArray(squaresAllValues(arrfour));

            //printAllItemsInArray(eliminateNegativeValues(arrThree));
            //printAllItemsInArray(eliminateNegativeValues(arrFive));

            //getMinMaxAvg(arrFive);

            //printAllItemsInArray(shiftingValuesInArray(arrOne));
            //printAllItemsInArray(shiftingValuesInArray(arrSix));

            foreach(var k in numToString(arrSeven))
            {
                Console.WriteLine(k);
            }

            foreach(var h in numToString(arrTwo))
            {
                Console.WriteLine(h);
            }
        }
    }
}