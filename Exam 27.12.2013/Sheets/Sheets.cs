﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sheets
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
 
        string[] arr = new string[11];
        for (int i = 0; i < 11; i++)
        {
            arr[i] = ("A" + i);
        }
 
        while (n > 0)
        {
            if (n >= 1024)
            {
                int index = Array.IndexOf(arr, "A0");
                if (index > -1)
                {
                    n -= 1024;
                    arr[index] = "";
                }
            }
            if (n >= 512)
            {
                int index = Array.IndexOf(arr, "A1");
                if (index > -1)
                {
                    n -= 512;
                    arr[index] = "";
                }
            }
            if (n >= 256)
            {
                int index = Array.IndexOf(arr, "A2");
                if (index > -1)
                {
                    n -= 256;
                    arr[index] = "";
                }
            }
            if (n >= 128)
            {
                int index = Array.IndexOf(arr, "A3");
                if (index > -1)
                {
                    n -= 128;
                    arr[index] = "";
                }
            }
            if (n >= 64)
            {
                int index = Array.IndexOf(arr, "A4");
                if (index > -1)
                {
                    n -= 64;
                    arr[index] = "";
                }
            }
            if (n >= 32)
            {
                int index = Array.IndexOf(arr, "A5");
                if (index > -1)
                {
                    n -= 32;
                    arr[index] = "";
                }
            }
            if (n >= 16)
            {
                int index = Array.IndexOf(arr, "A6");
                if (index > -1)
                {
                    n -= 16;
                    arr[index] = "";
                }
            }
            if (n >= 8)
            {
                int index = Array.IndexOf(arr, "A7");
                if (index > -1)
                {
                    n -= 8;
                    arr[index] = "";
                }
            }
            if (n >= 4)
            {
                int index = Array.IndexOf(arr, "A8");
                if (index > -1)
                {
                    n -= 4;
                    arr[index] = "";
                }
            }
            if (n >= 2)
            {
                int index = Array.IndexOf(arr, "A9");
                if (index > -1)
                {
                    n -= 2;
                    arr[index] = "";
                }
            }
            if (n >= 1)
            {
                int index = Array.IndexOf(arr, "A10");
                if (index > -1)
                {
                    n -= 1;
                    arr[index] = "";
                }
            }
             
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != "")
            {
                Console.WriteLine(arr[i]);
            }
        }
                 
    }
}
