
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Measurement and Calculation for Civil Engineering, algorithm built in c sharp, built for students and professionals in civil engineering and related areas, such as topography.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Measurement_and_Calculation_for_Civil_Engineering
{
    class Program
    { // classe

        public static void Main(string[] args)
        {

            while (true)
            {
                // class, method, string
                Console.WriteLine("\n"); 
                Console.WriteLine(" Measurement and Calculation for Civil Engineering ");
                Console.WriteLine("");
                Console.WriteLine("\n\t     Menu    \n");
                Console.WriteLine("");
                Console.WriteLine("1.Calculate Land Area (4 Equal Sides)");
                Console.WriteLine("2.Calculate Land Area (4 Different Sides)");
                Console.WriteLine("3.Calculate Property Perimeter (4 Equal Sides)");
                Console.WriteLine("4.Calculate Property Perimeter (4 Different Sides)");
                Console.WriteLine("5.Calculate How Many Square Meters a Wall Has");
                Console.WriteLine("6.Calculate How Many Blocks per M² a Wall Will Have");
                Console.WriteLine("7.Exit");
                Console.WriteLine("");
                Console.WriteLine("[8] Info");
                Console.WriteLine("[9] About");

                Console.WriteLine("\nEnter your choice: "); // choice

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the length of the land: ");
                            int v1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the width of the land: ");
                            int v2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            int resultado = v1 * v2;
                            Console.WriteLine("The land area is " + (resultado) + " square meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 2:
                            Console.WriteLine("Enter the length of side 1 of the land: ");
                            int v3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the length of side 2 of the land: ");
                            int v4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the width of side 3 of the land: ");
                            int v5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the width of side 4 of the land: ");
                            int v6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado1 = (v3 + v4) / 2;
                            int resultado2 = (v5 + v6) / 2;
                            int resultadofinal = (resultado1 * resultado2);
                            Console.WriteLine();
                            Console.WriteLine("The area of ​​the land with different sides is " + (resultadofinal) + " square meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 3:
                            int v8 = 4;
                            Console.WriteLine("Type one side of the property: ");
                            int v7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado3 = v7 * v8;
                            Console.WriteLine();
                            Console.WriteLine("The perimeter of the property with equal sides is " + (resultado3) + " sequence meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 4:
                            Console.WriteLine("Enter the length of side 1 of the property: ");
                            int v9 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the length of side 2 of the property: ");
                            int v10 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the width of side 3 of the property: ");
                            int v11 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the width of side 4 of the property: ");
                            int v12 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado4 = (v9 + v10);
                            int resultado5 = (v11 + v12);
                            int resultadofinal1 = (resultado4 + resultado5);
                            Console.WriteLine();
                            Console.WriteLine("The perimeter of the property with different sides has " + (resultadofinal1) + " sequence meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 5:
                            Console.WriteLine("Enter how many meters high the wall has: ");
                            int v13 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter how many meters wide the wall has: ");
                            int v14 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado6 = v13 * v14;
                            Console.WriteLine();
                            Console.WriteLine("The wall is " + (resultado6) + " square meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 6:
                            int v16 = 25; // one square meter has 25 blocks
                            Console.WriteLine("Enter how many square meters the wall has: ");
                            int v15 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado7 = v15 * v16;
                            Console.WriteLine();
                            Console.WriteLine("It will take " + (resultado7) + " blocks to build a wall with " + (v15) + " square meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 7:
                            Exit();
                            break;
                        case 8:
                            Clear();
                            Console.WriteLine();
                            Console.WriteLine("Info");
                            Console.WriteLine();
                            Console.WriteLine("To calculate the area of ​​a land with equal sides in square meters, we use Width x Length.");
                            Console.WriteLine("To calculate the area of ​​a land with different sides, we add two parallel sides, width by width, ");
                            Console.WriteLine("and divide by 2, thus obtaining the average. With the values ​​of the average of the parallel sides, we multiply the two and thus obtain the square meters of a plot of land with different sides.");
                            Console.WriteLine("To calculate the perimeter of both a property with equal sides and a property with different sides, simply add the values ​​of all sides. ");
                            Console.WriteLine("If a property has more than 4 sides, simply add (N) more sides to the 4 existing sides to obtain the perimeter.");
                            Console.WriteLine();
                            Console.WriteLine("To Calculate the Number of Blocks in a Wall:");
                            Console.WriteLine("Taking as example on a concrete block with dimensions (19Hx19Wx9C) in centimeters in horizontal axis view, ");
                            Console.WriteLine("and knowing that calculating a square meter of a wall will be H x W then 1 cement block has 19cm, so height with 5 blocks x width with 5 blocks = 25 blocks, ");
                            Console.WriteLine("so a square meter has 25 blocks so this will be the standard measurement. 25 x so many square meters = the amount of blocks to build a wall.");
                            Console.WriteLine();
                            Console.WriteLine("Important information: ");
                            Console.WriteLine();
                            Console.WriteLine("This algorithm was built with integer variables so it does not accept numbers with commas, example: 2.90 meters change to 3 meters.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 9:
                            Clear();
                            Console.WriteLine();
                            Console.WriteLine("Algorithm: Measurement and Calculation for Civil Engineering");
                            Console.WriteLine();
                            Console.WriteLine("Author: PHNO");
                            Console.WriteLine("Release Date: 29/11/2024");
                            Console.WriteLine("Version: 0.0.0.2v");
                            Console.WriteLine("Replit: @PHNO, @PHREPLIT");
                            Console.WriteLine("E-mail: phreplit@gmail.com");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        default:
                            Console.WriteLine("Error, Wrong Option! ");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro, system failure.");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return menu...");
                    Console.ReadKey();
                    Clear();
                }
            }
        }
        public static void Exit()
        { // exit method
            Console.WriteLine();
            Console.WriteLine(" Finished Algorithm! ");
            System.Environment.Exit(-1);
            return;
        }
        public static void Clear()
        { // method 
            Console.Clear();
            return;
        }
    }
}
