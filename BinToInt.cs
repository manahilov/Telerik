/*
 * Write a program to convert binary numbers to their decimal representation.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToDecimal
{
    static void Main()
    {
        List<int> number = new List<int>();
        string N;
        int theNewOne = 0;
        N = Console.ReadLine();
        do
        {
            number.Add((int)N.First() - 48); //Adding the first element of the string, to the List
            N = N.Remove(0, 1); //Removing the already added element
        } while (N != ""); //and that till the string is empty

        for (int i = number.Count - 1; i >= 0; i--)
        {
            theNewOne += number[i] * (int)Math.Pow(2, i); //calculating the sum of the pow's of the elements
        }

        foreach (var item in number)
        {
            Console.Write(item);
        }
        Console.WriteLine("(2) = {0}(10)", theNewOne);
        Console.ReadLine();
    }
}
