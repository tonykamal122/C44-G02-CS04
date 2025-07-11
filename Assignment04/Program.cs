using System.Text;
namespace Assignment04;

class Program
{
    static void Main(string[] args)
    {
        #region 1- allows the user to ins integer then print all nums between 1 to that nums
        /*
        Console.WriteLine("Please enter a number");
        int x;
        Int32.TryParse(Console.ReadLine(), out x);
        for (int i = 1; i <= x; i++)
        {
            Console.Write(i < x ? $"{i}, " : $"{i}");
        }
        */
        #endregion

        #region 2- user to insert number then print all even numbers between 1 to this number
        /*
        Console.WriteLine("Please enter a number");
        int x;
        Int32.TryParse(Console.ReadLine(), out x);
        for (int i = 1; i <= 12; i++)
        {
            Console.Write(x * i);
            Console.Write(' ');
        }
        */
        #endregion

        #region 3- user to insert number then print all even numbers between 1 to this number
        Console.WriteLine("Please enter a number");
        int x;
        Int32.TryParse(Console.ReadLine(), out x);
        for (int i = 1; i <= x; i++)
        {
            Console.Write((((i & 1) == 0) ? x : ' '));
            Console.Write(' ');
        }
        #endregion

        #region 4- Write a program that takes two integers then prints the power.

        /*
        Console.WriteLine("Please Enter Two Numbers:");
        int x, y,res = 1;
        Int32.TryParse(Console.ReadLine(), out x);
        Int32.TryParse(Console.ReadLine(), out y);
        for (int i = 1; i <= y; i++)
        {
            res *= x;
        }
        Console.WriteLine(res);
        */

        #endregion

        #region 5- enter marks of five subjects and calculate total, average and percentage.

        /*
        Console.WriteLine("Enter Five Numbers:");
        string[] arr = Console.ReadLine().Split(' ');
        int[] arr2 = new int[arr.Length];
        for (int i = 0; i < arr2.Length; i++)  Int32.TryParse(arr[i], out arr2[i]);
        int sum = 0;
        double avg = 0;
        for (int i = 0; i < arr2.Length; i++)  sum += arr2[i];
        avg = sum / (double)arr2.Length;
        Console.WriteLine($"Total Marks = {sum}");
        Console.WriteLine($"Average = {avg}");
        Console.WriteLine($"Percent = {((double)sum / 500) * 100}");
        */

        #endregion

        #region 6- the user to enter a string and print the REVERSE of it

        /*
        Console.WriteLine("Please Enter A word");
        string word = Console.ReadLine();
        StringBuilder word2 = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--) word2.Append(word[i]);
        Console.WriteLine($"Reversed word:  {word2}");
        */

        #endregion

        #region 7- Write a program to allow the user to enter int and print the REVERSED of it.

        /*
        Console.WriteLine("Please Enter a number:");
        int x, y = 0;
        Int32.TryParse(Console.ReadLine(), out x);
        while (x != 0)
        {
            int tmp = x % 10;
            y = y * 10 + tmp;
            x /= 10;
        }
        Console.WriteLine(y);
        */

        #endregion

        #region 8- find prime numbers within a range of numbers.

        /*
        Console.WriteLine("Enter a range of Numbers");
        int x, y;
        Int32.TryParse(Console.ReadLine(), out x);
        Int32.TryParse(Console.ReadLine(), out y);
        for (int i = x; i <= y; i++) // Number Theory <3
        {
            if (i <= 1) continue;
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) Console.Write(i + " ");

        }
        */

        #endregion

        #region 9- convert a decimal number into binary

        /*
        int num;
        Int32.TryParse(Console.ReadLine(), out num);
        int binary = 0;
        int place = 1;

        while (num > 0)
        {
            int bit = num % 2;
            binary += bit * place;
            place *= 10;
            num /= 2;
        }
        Console.WriteLine(binary);
        */

        #endregion

        #region 10- that asks the user to input three points lie on a single straight line.

        /*
        int x1, y1, x2, y2, x3, y3;
        Int32.TryParse(Console.ReadLine(), out x1);
        Int32.TryParse(Console.ReadLine(), out y1);
        Int32.TryParse(Console.ReadLine(), out x2);
        Int32.TryParse(Console.ReadLine(), out y2);
        Int32.TryParse(Console.ReadLine(), out x3);
        Int32.TryParse(Console.ReadLine(), out y3);
        Console.WriteLine((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1)
            ? "Points are on a straight line.": "Points are NOT on a straight line.");
        */

        #endregion

        #region 11- identity matrix using for loop, in other words takes a value n from the user

        /*
        int n;
        Int32.TryParse(Console.ReadLine(), out n);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(i == j) Console.Write($"{1} ");
                else Console.Write($"{0} ");
            }

            Console.WriteLine();
        }
        */

        #endregion
    }
}