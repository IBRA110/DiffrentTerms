using System;

public class Program
{
    public static void Main()
    {
        Int32 n = Convert.ToInt32(Console.ReadLine());

        List<Int32> result = new List<Int32> { };

        Int32 term = 1;
        
        while (n > 0)
        {
            if (n - term >= term + 1)
            {
                result.Add(term);
                n -= term;
            }
            else
            {
                result.Add(n);
                break;
            }
            
            term++;
        }


        Console.WriteLine(result.Count);

        foreach (Int32 element in result)
        {
            Console.Write(element + " ");
        }
    }
}