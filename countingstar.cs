using System;

class countingstarstar
{
    static void Main()
    {
        for(int i =0; i<=4;i++)
        {
            for(int j=4; j>=i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
                if(k>=1)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();

        }
       
    }
}