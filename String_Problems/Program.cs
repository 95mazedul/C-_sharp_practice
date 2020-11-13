using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stringProblem
{

    class Program
    {
        //Write a program in C# Sharp to input a string and print it.
        static void printInputString()
        {
            string str1, str2;
            Console.WriteLine("Give your string1");
            str1 = Console.ReadLine();

            Console.WriteLine("Give your string1");
            str2 = Console.ReadLine();
            Console.Write("the string you write was {0} {1} ", str1, str2);
        }

        //Write a program in C# Sharp to separate the individual characters from a string.
        static void printCharacterOfString()
        {
            string str;
            Console.WriteLine("Give your string");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"{str[i]} ");
            }
        }

        //Write a program in C# Sharp to count the total number of words in a string.
        static void printWordCount()
        {
            string str;
            Console.WriteLine("Give your string");
            str = Console.ReadLine();
            int count = 0, i = 0;

            while (i < str.Length)
            {
                //checking the space, new line and tab
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {
                    count++;
                }
                i++;
            }
            Console.Write($"{count}");
        }

        //Write a program in C# Sharp to compare two string without using string library functions.
        static void printStringCompare()
        {
            string str1, str2;
            Console.WriteLine("Give your string");
            str1 = Console.ReadLine();
            Console.WriteLine("Give your string");
            str2 = Console.ReadLine();
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 != length2)
            {
                Console.WriteLine("The strings are not equal in size");
            }
            else if (length1 == length2)
            {
                bool flg = true;
                for (int i = 0; i < length1; i++)
                {
                    if (str1[i] != str2[2])
                    {
                        flg = false;
                    }
                }
                if (!flg)
                {
                    Console.WriteLine("The size of the string is matched but they are not same");
                }
                else
                {
                    Console.WriteLine("The size of the string is matched but they are  same");
                }
            }
        }

        //Write a program in C# Sharp to find maximum occurring character in a string.
        static void printMaximumcharacterOccurance()
        {
            string str; int ascii;
            Console.WriteLine("Give your string");
            str = Console.ReadLine();
            int[] arr = new int[255];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            for (int j = 0; j < str.Length; j++)
            {
                ascii = (int)str[j];
                arr[ascii] += 1;
            }
            int max = 0;
            for (int k = 0; k < 255; k++)
            {
                //in ascii 32 is ValueTuple for 0
                if (k != 32)
                {
                    if (arr[k] > arr[max])
                    {
                        max = k;
                    }
                }
            }
            Console.Write($"your repeated character is {(char)max} and it was repeated {arr[max]} times");

        }

        //Write a program in C# Sharp to sort a string array in ascending order.
        static void printStringInAscendingOrder()
        {
            string str;
            Console.WriteLine("Give your string");
            str = Console.ReadLine();
            char[] arr; char temp;
            arr = str.ToCharArray(0, str.Length);
            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (char ch in arr)
            {
                Console.Write($"{ch } ");
            }

        }

        //Write a program in C# Sharp to read a string through the keyboard and sort it using bubble sort.
        static void printStringUsingBubblesort()
        {
            string[] str; int n; string temp;
            Console.WriteLine("please write how many strings you want to write");
            n = Convert.ToInt32(Console.ReadLine());
            str = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"please write {i} number string");
                str[i] = Console.ReadLine();
            }
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n - 1; k++)
                {
                    if (str[k].CompareTo(str[k + 1]) > 0)
                    {
                        temp = str[k];
                        str[k] = str[k + 1];
                        str[k + 1] = temp;
                    }
                }
            }
            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
        }

        //Write a program in C# Sharp to extract a substring from a given string without using the library function.
        static void printExtractedSubstring()
        {
            string str; int pos, len; char[] arr;
            Console.WriteLine("please write your string");
            str = Console.ReadLine();
            Console.WriteLine("from wich position you want to start");
            pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("size of your Substring");
            len = Convert.ToInt32(Console.ReadLine());

            arr = str.ToCharArray(0, str.Length);
            int i = 0;
            while (i < len)
            {
                Console.Write($"{str[pos + i - 1]}");
                i++;
            }

        }
        //Write a C# Sharp program to check whether a given substring is present in the given string
        static void printChcekSubstringExist()
        {
            string str, subString;
            bool f;
            Console.WriteLine("write your string");
            str = Console.ReadLine().ToLower();

            Console.WriteLine("write your string");
            subString = Console.ReadLine().ToLower();

            f = str.Contains(subString);
            if (f)
            {
                Console.WriteLine("Your given string contains given substring");
            }
            else
            {
                Console.WriteLine("Your given string DOES NOT contain given substring");
            }
        }

        //Write a program in C# Sharp to search the position of a substring within a string
        static void printFindsubStringPosition()
        {
            string str, subString;
            Console.WriteLine("write your string");
            str = Console.ReadLine().ToLower();

            Console.WriteLine("write your Substring");
            subString = Console.ReadLine().ToLower();
            int In;
            In = str.IndexOf(subString);
            if (In < 0)
            {
                Console.WriteLine("your given string is invalid");
            }
            else
            {
                Console.WriteLine($"substring {subString} found in {In} position");
            }
        }
        static void Main(string[] args)
        {
            printInputString();
            printCharacterOfString();
            printWordCount();
            printStringCompare();
            printMaximumcharacterOccurance();
            printStringInAscendingOrder();
            printStringUsingBubblesort();
            printExtractedSubstring();
            printFindsubStringPosition();


            Console.ReadLine();
        }
    }
}
