
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Measurement and Calculation for Civil Engineering, algorithm built in java, built for students and professionals in civil engineering and related areas, such as topography.

import java.io.IOException;
import java.util.Scanner; // import lib

public class Main {

public static void main(String[] args) throws IOException, InterruptedException {

loop: // choice Menu
while (true) {

  System.out.println("\n");
  System.out.println("\n");
  System.out.println(" Measurement and Calculation for Civil Engineering ");
  System.out.println("");
  System.out.println("");
  System.out.println("1.Calculate Land Area (4 Equal Sides)");
  System.out.println("2.Calculate Land Area (4 Different Sides)");
  System.out.println("3.Calculate Property Perimeter (4 Equal Sides)");
  System.out.println("4.Calculate Property Perimeter (4 Different Sides)");
  System.out.println("5.Calculate How Many Square Meters a Wall Has");
  System.out.println("6.Calculate How Many Blocks per M² a Wall Will Have");
  System.out.println("7.Exit\n");
  System.out.println("");
  System.out.println("[8] Info");
  System.out.println("[9] About "); // about
  
  System.out.println("\nEnter your choice: ");

Scanner scanner = new Scanner(System.in);

int choice = scanner.nextInt();

try {
  
switch (choice) {
  case 1:
    System.out.println("\nEnter the length of the land: "); 
    int v1 = scanner.nextInt();
    System.out.println("\nEnter the width of the land: "); 
    int v2 = scanner.nextInt();
    int result = (v1 * v2); 
    System.out.println("\n");
    System.out.println("\nThe land area is " + (result) + " square meters.\n");
    Scanner scanner1 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter = scanner1.nextLine();
    clear(); 
    break;
  case 2:
    System.out.println("\nEnter the length of side 1 of the land: ");  
    int v3 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the length of side 2 of the land: ");  
    int v4 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the width of side 3 of the land: ");  
    int v5 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the width of side 4 of the land: ");  
    int v6 = scanner.nextInt();
    System.out.println("\n");
    int resultado = (v3 + v4) / 2;
    int resultado2 = (v5 + v6) / 2;
    int resultadofinal = (resultado * resultado2);
    System.out.println("\nThe area of ​​the land with different sides is " + (resultadofinal) + " square meters.");
    Scanner scanner2 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter2 = scanner2.nextLine();
    clear(); 
    break;
  case 3:	  
    int v8 = 4;
    System.out.println("\nType one side of the property: ");  
    int v7 = scanner.nextInt();
    System.out.println("\n");
    int result2 = v7 * v8;
    System.out.println("\nThe perimeter of the property with equal sides is " + (result2) + " sequence meters.");
    Scanner scanner3 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter3 = scanner3.nextLine();
    clear();
  break;
  case 4:
    System.out.println("\nEnter the length of side 1 of the property: ");   
    int v9 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the length of side 2 of the property: ");   
    int v10 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the width of side 3 of the property: ");   
    int v11 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the width of side 4 of the property: ");   
    int v12 = scanner.nextInt();
    System.out.println("\n");
    int result3 = (v9 + v10);
    int result4 = (v11 + v12);
    int finalresult = (result3 + result4);
    System.out.println("\nThe perimeter of the property with different sides has " + (finalresult) + " sequence meters.");
    Scanner scanner4 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter4 = scanner4.nextLine();
    clear(); 
  break;
  case 5:
    System.out.println("\nEnter how many meters high the wall has: ");   
    int v13 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter how many meters wide the wall has: ");   
    int v14 = scanner.nextInt();
    System.out.println("\n");
    int result5 = v13 * v14;
    System.out.println("\nThe wall is " + (result5) + " square meters.");
    Scanner scanner5 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter5 = scanner5.nextLine();
    clear(); 
  break;
 case 6:
    int v16 = 25; // one square meter has 25 blocks
    System.out.println("\nEnter how many square meters the wall has: ");   
    int v15 = scanner.nextInt();
    System.out.println("\n");
    int result6 = v15 * v16;
    System.out.println("\nIt will take " + (result6) + " blocks to build a wall with " + (v15) + " square meters. \n");
    Scanner scanner6 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter6 = scanner6.nextLine();
    clear();
  break;
  case 7:
    System.out.println("\n Finished Algorithm! ");
  break loop;
  case 8:
  clear();
  System.out.println("\n");
  System.out.println("Info");
  System.out.println("");
  System.out.println("To calculate the area of ​​a land with equal sides in square meters, we use Width x Length.");
  System.out.println("To calculate the area of ​​a land with different sides, we add two parallel sides, width by width, and divide by 2, thus obtaining the average. With the values ​​of the average of the parallel sides, we multiply the two and thus obtain the square meters of a plot of land with different sides.");
  System.out.println("To calculate the perimeter of both a property with equal sides and a property with different sides, simply add the values ​​of all sides. If a property has more than 4 sides, simply add (N) more sides to the 4 existing sides to obtain the perimeter.");
  System.out.println("");
  System.out.println("To Calculate the Number of Blocks in a Wall:");
  System.out.println("Taking as example on a concrete block with dimensions (19Hx19Wx9C) in centimeters in horizontal axis view, and knowing that calculating a square meter of a wall will be H x W then 1 cement block has 19cm, so height with 5 blocks x width with 5 blocks = 25 blocks, so a square meter has 25 blocks so this will be the standard measurement. 25 x so many square meters = the amount of blocks to build a wall.");
  System.out.println("");
  System.out.println("Important information: ");
  System.out.println("This algorithm was built with integer variables so it does not accept numbers with commas e.g.: 2.90 meters change to 3 meters.");
  System.out.println("");
  Scanner scanner7 = new Scanner(System.in);
  System.out.println("\nPress enter to return to the menu...\n");
  String enter7 = scanner7.nextLine();
  clear();
  break;
  case 9:
  clear();
  System.out.println("\n");
  System.out.println("Algorithm: Measurement and Calculation for Civil Engineering");
  System.out.println("");
  System.out.println("Author: PHNO");
  System.out.println("Release Date: 29/11/2024");
  System.out.println("Version: 0.0.0.2v");
  System.out.println("Replit: @PHNO, @PHREPLIT");
  System.out.println("E-mail: phreplit@gmail.com");
  System.out.println("");
  Scanner scanner8 = new Scanner(System.in);
  System.out.println("\nPress enter to return to the menu...\n");
  String enter8 = scanner8.nextLine();
  clear();
  break;
  default:
    Scanner scanner9 = new Scanner(System.in);
    System.out.println("\n Error, choose again. ");
    System.out.println("\nPress enter to return to the menu...\n");
    String enter9 = scanner9.nextLine();
    clear();
}
  } catch (Exception e) {
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nError, system failure!");
  System.out.println("\nPress enter to return to the menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  }            
}
}
public static void clear() {
     System.out.print("\033[H\033[2J"); // clear screen
     System.out.flush();
}
}