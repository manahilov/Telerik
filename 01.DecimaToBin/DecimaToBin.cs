/*
 * Write a program to convert decimal numbers to their binary representation.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecimaToBin
{
    static void Main()
    {
        decimal N;
        List<byte> binnary = new List<byte>();
        N = decimal.Parse(Console.ReadLine());
        do
        {
            binnary.Add((byte)(N % 2));
            N = N / 2;
        } while (N > 0);
        binnary.Reverse();
        foreach (var item in binnary)
        {
            Console.Write(item);
        }
        Console.ReadLine();
    }
}
