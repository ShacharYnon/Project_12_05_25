using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_05_25
{
    internal class Program
    {
        static int[] series =new int[0];
        static string[] splitArr(string arr_)
        {
            string[] wordes = arr_.Split(' ');
            return wordes;
        }
        static bool checkIntString(string[] arr_)
        {
            foreach (string item in arr_)
            {
                if (!int.TryParse(item, out _))
                {
                    return false;
                }
            }
            return true;
        }
        static bool checkIntInt(int[] arr_)
        {
            return true;
        }
        static bool checkLen(int[] ins_)
        {
            if (ins_.Length < 3)
            {
                return false;
            }
            return true;
        }
        static bool checkPosit(int[] ins_)
        {
            for (int i = 0; i < ins_.Length; i++)
            {
                if (ins_[i] < 0)
                {
                    return false;
                }
            }
            return true;

        }
        static int[] converArr(string[] arr_)
        {
            int[] arrt = Array.ConvertAll(arr_, int.Parse);
            return arrt;
        }
        static int menu()
        {
            Console.WriteLine(" ------MENU------\r\n" +
            "1. Enter a positive numbers series.\r\n" +
            "2. Display the series in the order it was entered.\r\n" +
            "3. Display the series in the reverse order it was entered.\r\n" +
            "4. Display the series in sorted order (lowest to highest).\r\n" +
            "5. Display the maximum value of the series.\r\n" +
            "6. Display the minimum value of the series.\r\n" +
            "7. Display the average of the series.\r\n" +
            "8. Display the number of elements in the series.\r\n" +
            "9. Display the sum of the series.\r\n" +
            "10. Output.");
            int num_ = int.Parse(Console.ReadLine());
            return num_;
        }
        static void managManu()
        {
            bool flag = true;
            while (flag)
            {
                int choice = menu();
            
            switch (choice)
            {
                case 1:
                    mGetSeriesNum();
                    break;
                case 2:
                    show();
                    break;
                case 3:
                    reversShow();
                    break;
                case 4:
                    sortMinToMax();
                    break;
                case 5:
                    bigNumber();
                    break;
                case 6:
                    smallNumber();
                    break;
                case 7:
                    averageOfTheSeries();
                    break;
                case 8:
                    numObgInSeries();
                    break;
                case 9:
                    sumOfTheSeries();
                    break;
                case 10:
                    returen folaese;
                    break;
            }
            }
        }
        static string mGetSeriesNum()
        {
            Console.WriteLine("Enter a positive numbers series. ");
            string str_ = Console.ReadLine();
            return str_;
        }
        static void reversShow()
        {
            for (int i = arr_.Length - 1; i >= 0; i--)
            {
                Console.Write(arr_[i] + " ");
            }
             
        }
        static void show()
        {
            foreach (int i in arr_)
            {
                Console.Write(i + " ");
            }
        }
        static void sortMinToMax(int[] arr_)
        {
            Array.Sort(arr_);
            foreach (int i in arr_)
            {
                Console.Write(i + " ");
            }
        }
        static void sortMaxToMin(int[] arr_)
        {
            Array.Sort(arr_);
            Array.Reverse(arr_);

            foreach (int num in arr_)
            {
                Console.Write(num + " ");
            }
        }
        static void bigNumber(int[] arr_)
        {
            Array.Sort(arr_);
            Array.Reverse(arr_);
            Console.Write(arr_[0]);
        }
        static void smallNumber(int[] arr_)
        {
            Array.Sort(arr_);
            Console.Write(arr_[0]);
        }
        static void averageOfTheSeries(int[] arr_)
        {
            int sum = 0;
            foreach (int i in arr_)
            {
                sum += i;
            }
            Console.WriteLine(sum / (arr_.Length));
        }
        static void numObgInSeries(int[] arr_)
        {
            Console.WriteLine(arr_.Length);
        }
        static void sumOfTheSeries(int[] arr_)
        {
            int sum = 0;
            foreach (int i in arr_)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void meneger()
        {
            bool onOff = true;
            while (onOff)
            {
            }
        }


        static void Main(string[] args)
        {
            menu();
        }
    }
}
