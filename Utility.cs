// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;
    using System.IO;
    /// <summary>
    /// Utitilty class which contains all generic(s) methods.
    /// </summary>
    public class Utility
    {

        /// <summary>
        /// This Method Check Two String Are Anagram Or Not 
        /// </summary>

        public void ToCheckTheStringAnagram()
        {
            Console.WriteLine("Enter First String");
            String firstString = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            String secondString = Console.ReadLine();
            char[] first = firstString.ToLower().ToCharArray();
            char[] second = secondString.ToLower().ToCharArray();

            Array.Sort(first);
            Array.Sort(second);
            if (first.Length == second.Length)
            {
                int count = 0;
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                        count++;
                }
                if (count == 0)
                {
                    Console.WriteLine("{0} And {1} Are Anagram", firstString, secondString);
                }
                else
                {
                    Console.WriteLine("{0} And {1} Are Not Anagram...", firstString, secondString);
                }
            }
            else
            {
                Console.WriteLine("{0} And {1} Are Not Anagram...", firstString, secondString);

            }

        }
        /// <summary>
        /// 
        /// </summary>
        public void ToPrintPrimeNumberInRange()
        {
            Console.WriteLine("Enter Start Range");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter End Range");
            int end = Convert.ToInt32(Console.ReadLine());
            int count;
            for (int i = start; i < end; i++)
            {
                count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write(" " + i);
                }
            }
        }
        /// <summary>
        /// This Method is Binary Search Method to Search The Element Type Integer.
        /// </summary>
        public void BinarySearchInteger()
        {
            Console.WriteLine("How Many Element Do You Want to Enter");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intarray = new int[size];
            int start = 0, end = size - 1;
            int mid = (start + end) / 2;
            Console.WriteLine("Enter Elements :");
            for (int i = 0; i < size; i++)
            {
                intarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Element For Search ");
            int search = Convert.ToInt32(Console.ReadLine());

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (intarray[mid] == search)
                {
                    Console.WriteLine("Element Found At :{0} Position.", mid + 1);
                    break;
                }
                else if (intarray[mid] < search)
                {
                    start = mid + 1;
                }
                else if (intarray[mid] > search)
                {
                    end = mid - 1;
                }

            }
            if (start > end)
            {
                Console.WriteLine("Element Not Found Position.");

            }
        }
        /// <summary>
        /// This is Binary search Method For String.
        /// </summary>
        public void StringSearch()
        {
            Console.WriteLine("Enter Message ");
            String message = Console.ReadLine();
            String[] messagearray = message.Split(' ');
            Array.Sort(messagearray);
            Console.WriteLine("Enter Word For Search  ");
            String word = Console.ReadLine();

            int start = 0, end = messagearray.Length - 1;
            int mid;

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (messagearray[mid].CompareTo(word) == 0)
                {
                    Console.WriteLine(" Word Is Found In This Message.");
                    break;
                }
                else if (messagearray[mid].CompareTo(word) < 0)
                {
                    start = mid + 1;
                }
                else if (messagearray[mid].CompareTo(word) > 0)
                {
                    end = mid - 1;
                }

            }
            if (start > end)
            {
                Console.WriteLine("Word Not Found .");

            }
        }
        /// <summary>
        /// This Is Insertion Sort Method For Integer Value.
        /// </summary>
        public void InsertionSortInteger()
        {
            Console.WriteLine("How Many Element Do You Want to Enter");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intarray = new int[size];

            Console.WriteLine("Enter Elements :");
            for (int i = 0; i < size; i++)
            {
                intarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < intarray.Length; i++)
            {
                int key = intarray[i];
                int j = i - 1;
                while (j > -1 && intarray[j] > key)
                {

                    intarray[j + 1] = intarray[j];
                    j--;
                }
                intarray[j + 1] = key;
            }
            foreach (int a in intarray)
                Console.Write(" " + a);
        }
        /// <summary>
        /// This is Insertion Sort Method For String 
        /// </summary>

        public void InsertionSortString()
        {
            Console.WriteLine("Enter Message ");
            String message = Console.ReadLine();
            String[] messagearray = message.Split(' ');

            for (int i = 1; i < messagearray.Length; i++)
            {
                String key = messagearray[i];
                int j = i - 1;
                while (j > -1 && messagearray[j].CompareTo(key) > 0)
                {

                    messagearray[j + 1] = messagearray[j];
                    j--;
                }
                messagearray[j + 1] = key;
            }
            foreach (String s in messagearray)
                Console.Write(" " + s);
        }
        /// <summary>
        /// This is Bubble Sort Method For Integer.
        /// </summary>
        public void BubbleSortInteger()
        {
            Console.WriteLine("How Many Element Do You Want to Enter");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intarray = new int[size];

            Console.WriteLine("Enter Elements :");
            for (int i = 0; i < size; i++)
            {
                intarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < intarray.Length; i++)
            {
                for (int j = 1; j < intarray.Length-i; j++)
                {
                    if (intarray[j-1] > intarray[j])
                    {
                        int temp = intarray[j-1];
                        intarray[j-1] = intarray[j];
                        intarray[j] = temp;
                    }

                }
            }
            foreach (int a in intarray)
                Console.Write(" " + a);
        }

        /// <summary>
        /// This Is Bubble Sort Method For String .
        /// </summary>
        public void BubbleSortString()
        {
            Console.WriteLine("Enter Message ");
            String message = Console.ReadLine();
            String[] messagearray = message.Split(' ');

            for (int i = 0; i < messagearray.Length; i++)
            {
                for (int j = 1; j < messagearray.Length - i; j++)
                {
                    if (messagearray[j - 1].CompareTo(messagearray[j]) > 0)
                    {
                        String temp = messagearray[j - 1];
                        messagearray[j - 1] = messagearray[j];
                        messagearray[j] = temp;
                    }

                }
            }
            foreach (String a in messagearray)
                Console.Write(" " + a);
        }
        /// <summary>
        /// This Is Method for To Guess The Number
        /// </summary>

        public void FindNumberMethod()
        {
            Console.WriteLine("Enter Range For Numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] numberlist = new int[number];
            int start = 0, end = number - 1;
            int mid = (start + end) / 2;
            for (int i = 0; i < number; i++)
            {
                numberlist[i] = i;
            }
            Console.WriteLine("Think Your Number ");
            for(int j=0;j<10;j++)
            {
                Console.Write("...");
                Thread.Sleep(1000);
            }

            while (start <= end)
            {
                mid = (start + end) / 2;
                Console.WriteLine("\nIs This Your Number  :" + numberlist[mid] + "\n Enter Y or N");
                char isnumber = Console.ReadLine()[0];
                if (isnumber == 'Y' || isnumber == 'y')
                {
                    Console.WriteLine("Great......... ");
                    break;
                }

                else
                {

                    Console.WriteLine("Is Your Number Greater Than  :" + numberlist[mid] + "\n Enter Y or N");
                    char decision = Console.ReadLine()[0];

                    if (decision == 'Y' || decision == 'y')
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }


                }

            }
        }
        /// <summary>
        /// This Is Word Search Method From File
        /// </summary>
        public string wordlines = "";//here retrive each line 
        public String[] wordarray;

        public void SearchWordFromFileMethod()
        {
            String textFile = "C:\\Users\\Admin\\Desktop\\Satya\\readfile1.txt";//File Path
            string[] lines = File.ReadAllLines(textFile); //Read File
            String[] wordString = new String[9];
            foreach (String readlines in lines)
            {
                Console.WriteLine(readlines);
            }
            int k = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                wordlines = lines[i];

                for (int j = 0; j < lines.Length; j++)
                {
                    wordarray = wordlines.Split(',');
                }

                foreach (String s in wordarray)
                {
                    if (s != null)
                    {
                        wordString[k] = s;
                        k++;
                    }

                }

            }



            //Actual Logic For Binary Search For String 


            Array.Sort(wordString);
            Console.WriteLine("\n\nEnter Word For Search  ");
            String word = Console.ReadLine();

            int start = 0, end = wordString.Length - 1;
            int mid;

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (wordString[mid].CompareTo(word) == 0)
                {
                    Console.WriteLine(" Word Is Found In This Message.");
                    break;
                }
                else if (wordString[mid].CompareTo(word) < 0)
                {
                    start = mid + 1;
                }
                else if (wordString[mid].CompareTo(word) > 0)
                {
                    end = mid - 1;
                }

            }
            if (start > end)
            {
                Console.WriteLine("Word Not Found .");

            }
        }

    }
    }
