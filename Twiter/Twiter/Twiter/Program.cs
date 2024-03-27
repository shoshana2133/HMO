using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twiter
{
    public class Program

    {//Print function by character and counter
        public static void print(int count, char ch)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(ch);
            }
           
        }
        static void Main(string[] args)
        {

            int width, height, option, optionTrianle, num, rows, remainder;
            double hypotenuse;
            Console.WriteLine("Press 1 for a rectangular tower and 2 for a triangular tower, press 3 to exit");
            option = int.Parse(Console.ReadLine());
            while (option != 3)
            {
                Console.WriteLine("Enter width");
                width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter height");
                height = int.Parse(Console.ReadLine());
                if (option == 1)
                    if (Math.Abs(width - height) < 5)
                        Console.WriteLine("The area of the rectangle is: " + (width * height));
                    else Console.WriteLine("The perimeter of the rectangle is: " + (width * 2 + height * 2));
                else
                {
                    Console.WriteLine("To calculate the perimeter of the triangle press 1. To print the triangle press 2");
                    optionTrianle = int.Parse(Console.ReadLine());
                    if (optionTrianle == 1)
                    {//Calculating the perimeter of a triangle according to the Pythagorean theorem
                        hypotenuse = Math.Sqrt(Math.Pow((width / 2), 2) + Math.Pow((height), 2));
                        Console.WriteLine("The perimeter of the triangle is: "+(width + hypotenuse * 2));
                    }

                    else if (optionTrianle == 2)
                    {
                        if (width % 2 == 0 || width / 2 > height)
                        {
                            Console.WriteLine("The triangle cannot be printed");

                        }
                        else
                        {
                            int count = 0;
                            //The first odd number after one
                            num = 3;
                            //Calculation of the number of possible odd numbers in the inner rows
                            while (num != width)
                            {
                                count++;
                                num += 2;
                            }


                            //Auxiliary calculations for printing the triangle
                            //The first odd number after one
                            num = 3;
                            //Calculation of the number of rows for each odd number
                            rows = (height - 2) / count;
                            //Calculation of the number of rows remaining in the remainder of the division to the top of the tower
                            remainder = (height - 2) % count;


                            //The triangle print
                            print(height / 2, ' ');
                            Console.WriteLine('*');
                          
                            for (int i = 0; i < remainder; i++)
                            {
                                print(height / 2-(num/2), ' ');
                                print(num,'*');
                                Console.WriteLine();
                            }
                            while (num != width)
                            {
                                for (int i = 0; i < rows; i++)
                                {
                                    print(height / 2 - (num / 2), ' ');
                                    print(num, '*');
                                    Console.WriteLine();
                                }
                                num += 2;
                            }
                            print(width, '*');
                           Console.WriteLine();
                        }
                    }
                  
                }
                Console.WriteLine("Press 1 for a rectangular tower and 2 for a triangular tower, press 3 to exit");
                option = int.Parse(Console.ReadLine());
            }
   
        }
    }
}
