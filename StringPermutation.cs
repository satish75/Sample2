// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class StringPermutation
    {
        HashSet<string> myhash1 = new HashSet<string>();
        public void StringPermutionIterativly()
        {
            Console.WriteLine("Enter String For Permution\n");
            string permuteString = Console.ReadLine();
            Console.WriteLine("............\n");
            char[] c = permuteString.ToCharArray();
          
          
            for (int i=0;i<c.Length;i++)
            {
                for(int j=i;j<c.Length;j++)
                {
                    char[] temparray = new char[c.Length];
                    Array.Copy(c,temparray,c.Length);
                   
                   
                    char temp = temparray[i];
                    temparray[i] = temparray[j];
                    temparray[j] = temp;
                   
                    string s = new string(temparray);
                    swap(s);
                }
                 break;

            }
            Console.WriteLine("**********");
            foreach (string str in myhash1)
            {
                Console.WriteLine(str);
            }

        }
          public void swap(string s)
        {
            char []c = s.ToCharArray();
           
            for (int i=1;i<c.Length;i++)
            {
                for(int j=i;j<c.Length;j++)
                {
                    char[] temparray = new char[c.Length];
                    Array.Copy(c, temparray, c.Length);
                    char temp = temparray[i];
                    temparray[i] = temparray[j];
                    temparray[j] = temp;
                    string s1 = new string(temparray);
                   // Console.WriteLine(s1);
                    myhash1.Add(s1);
                }
               // 
            }
           

        }
    }
}
