using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int multiplo = 0;
        bool isMultiplo = false;

        while(!isMultiplo)
        {
          multiplo++;
          if(multiplo % num1 == 0 && multiplo % num2 == 0)
          {
            isMultiplo = true;
          }
        }

        Console.WriteLine(multiplo);
    }
}