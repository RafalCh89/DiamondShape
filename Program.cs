using System;

class triangle_one
{
    public static void Main()
    {
        /* 
          
        int num;
         int p;

         while (true)
         {
             Console.Write("Pease enter a number between 1 to 9 : ");
             num = Convert.ToInt32(Console.ReadLine());
             if ((num <= 9) && (num > 0))
             {
                 break;
             }
             Console.WriteLine("You have entered inccorect value. Please enter a number between 1 to 9");
         }

         for (int row = 1; row <= num; row++)
         {
             p = row;
             for (int col = 1; col <= row; col++)
             {
                 Console.Write("" + "*");  
                 p--;
             }
             Console.Write("\n");
         }
         Console.ReadLine();

     }*/

        
       int num;
         int p;

         while (true)
         {
             Console.Write("Pease enter a number between 1 to 9 : ");
             num = Convert.ToInt32(Console.ReadLine());
             if ((num <= 9) && (num > 0))
             {
                 break;
             }
             Console.WriteLine("You have entered inccorect value. Please enter a number between 1 to 9");
         }

  
      {
           
            int i, j, k;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= num - i; j++)
                {
                    // Console.Write(" ");
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
    

    }

