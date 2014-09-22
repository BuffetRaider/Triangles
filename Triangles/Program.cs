using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {

             for (int i = 0; i < 10; i++)           //  *
             {                                      //  **
                     for(int n = 0; n < i; n++)     //  ***
                     {                              //  ****
                         Console.Write('*');        //  *****
                     }                              //  ******
                 Console.WriteLine();               //  *******
             }                                      //  ********

            Console.WriteLine();                    // blank line before next pattern

             for (int i = 0; i < 10; i++)           //  ********
             {                                      //  *******
                    for (int n = 0; n < 9 - i; n++) //  ******
                     {                              //  *****
                         Console.Write('*');        //  ****
                     }                              //  ***
                 Console.WriteLine();               //  **
             }                                      //  *

            Console.WriteLine();                    // blank line before next pattern

            for (int i = 0; i < 10; i++)
            {
                    for (int n = 0; n < 9 - i; n++) //       *
                     {                              //      **
                         Console.Write(' ');        //     ***
                                                    //    ****
                     }                              //   *****
                    for (int x = 0; x <= i; x ++)   //  ******
                    {                               // *******
                        Console.Write('*');
                    }
                Console.WriteLine();
            }

            Console.WriteLine();                    // blank line before next pattern

            for (int i = 0; i < 10; i++)            // *******
            {                                       //  ******
                for (int n = 0; n < i; n++)         //   *****
                {                                   //    ****
                    Console.Write(' ');             //     *** 
                                                    //      **
                }                                   //       *
                for (int x = 0; x <= 9 - i; x++)    
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
                Console.Read();              
            }

        } 
    }

