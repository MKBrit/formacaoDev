using System;
using System.Collections.Generic;
using System.IO;

class Program 
{
    static void Main()
    {
        // Declaring Variables 
        int size = 10;
        Random random = new Random();
        int[] nrArray = new int[size];

        // Creating randoms
        for (int i = 0; i < size; i++) 
        {
            nrArray[i] = random.Next(1, 20);
        }
        
        Console.WriteLine();

        // Showing chosen randoms on array
        int index = 0;
        foreach (int x in nrArray) 
        { 
            Console.WriteLine("Random Array: On position: " + index + " the value is: " + x);
            index++;
        }

        Console.WriteLine();

        // Organiza os elementos por ordem
        int[] nrArray2 = nrArray;
        index = 0;
        Array.Sort(nrArray2); 
        foreach (int x in nrArray2)
        {
            Console.WriteLine("Sorted Array: On position: " + index + " the value is: " + x);
            index++;
        }

        
        Console.WriteLine();    
        
        // Check biggest nr
        Console.WriteLine("Teh biggest boy on this array is: " + nrArray.Max());
    }
}