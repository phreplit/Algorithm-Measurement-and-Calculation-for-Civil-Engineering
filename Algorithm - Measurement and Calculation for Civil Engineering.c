
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Measurement and Calculation for Civil Engineering, algorithm built in c, built for students and professionals in civil engineering and related areas, such as topography.

#include <stdio.h> // import lib
#include <stdlib.h> 
#include <math.h> 

int menu(); 
void op1(); // header
void op2(); 
void op3();
void op4();
void op5();
void op6();
void op8();
void reset_screen();
int menu_programmer();

int menu() { // Function Menu  
int op, c;

printf("\n Measurement and Calculation for Civil Engineering \n");

printf("\n");
printf("\n\t     Menu    \n");
printf("\n");

printf("\n1.Calculate Land Area (4 Equal Sides)");
printf("\n2.Calculate Land Area (4 Different Sides)");
printf("\n3.Calculate Property Perimeter (4 Equal Sides)");
printf("\n4.Calculate Property Perimeter (4 Different Sides)");
printf("\n5.Calculate How Many Square Meters a Wall Has");
printf("\n6.Calculate How Many Blocks per M² a Wall Will Have");
printf("\n7.Exit\n");
printf("\n[8] Info\n");
printf("\n[9] About \n");

printf("\nEnter your choice: "); // option
scanf("%d", &op);

while ((c = getchar()) != '\n' && c != EOF) {
} // clear keyboard buffer.   
return op; 
}

int main() { // main function

int op = 0, c;

while (op != -1) { 
op = menu(); 
switch (op) { 
case 1: 
op1(); // function
break; 
case 2: 
op2(); // function
break; 
case 3: 
op3(); // function
break;
case 4:
op4(); // function
break;
case 5:
op5(); // function
break;
case 6:
op6(); // function
break;
case 7:
printf("\n");
printf("\n Finished Algorithm! \n"); // exit
printf("\n");
return 0;
break;
case 8:
op8(); // function
break;
case 9:
menu_programmer(); // function
break; 
default: 
printf("\n");
printf("Wrong Option!\n");
printf("\n");
//printf("\n");
printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
} 
} 
return 0; 
} 

void op1() { 
int v1;
int v2;
int resultado;
printf("\n");
printf("\nEnter the length of the land: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nEnter the width of the land: ");
scanf("%d", &v2, stdin);
resultado = v1 * v2;
printf("\nThe land area is %d square meters.\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op2() { 
int v1;
int v2;
int v3;
int v4;
int resultado;
int resultado2;
int resultadofinal;

printf("\n");
printf("\nEnter the length of side 1 of the land: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nEnter the length of side 2 of the land: ");
scanf("%d", &v2, stdin);
printf("\n");
printf("\nEnter the width of side 3 of the land: ");
scanf("%d", &v3, stdin);
printf("\n");
printf("\nEnter the width of side 4 of the land: ");
scanf("%d", &v4, stdin);

resultado = (v1 + v2) / 2;
resultado2 = (v3 + v4) / 2;
resultadofinal = (resultado * resultado2);

printf("\nThe area of ​​the land with different sides is %d square meters.\n", resultadofinal);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op3() { 
int v1;
int v2 = 4;
int resultado;
printf("\n");
printf("\nType one side of the property: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = v1 * v2;
printf("\nThe perimeter of the property with equal sides is %d meters.\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op4() {

int v1;
int v2;
int v3;
int v4;
int resultado;
int resultado2;
int resultadofinal;

printf("\n");
printf("\nEnter the length of side 1 of the property: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nEnter the length of side 2 of the property: ");
scanf("%d", &v2, stdin);
printf("\n");
printf("\nEnter the width of side 3 of the property: ");
scanf("%d", &v3, stdin);
printf("\n");
printf("\nEnter the width of side 4 of the property: ");
scanf("%d", &v4, stdin);

resultado = (v1 + v2);
resultado2 = (v3 + v4);
resultadofinal = (resultado + resultado2);

printf("\nThe perimeter of the property with different sides has % of meters.\n", resultadofinal);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op5() { 
int v1;
int v2;
int resultado;
printf("\n");
printf("\nEnter how many meters high the wall has: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nEnter how many meters wide the wall has: ");
scanf("%d", &v2, stdin);
resultado = v1 * v2;
printf("\nThe wall is %d square meters \n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op6() { 
int v1;
int v2 = 25; // one square meter has 25 blocks
int resultado;
printf("\n");
printf("\nEnter how many square meters the wall has: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = v1 * v2;
printf("\nIt will take %d blocks to build a wall with %d square meters. \n", resultado, v1);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op8() {
reset_screen();
printf("\nInfo\n");
printf("\nTo calculate the area of ​​a land with equal sides in square meters, we use Width x Length.\n");
printf("\nTo calculate the area of ​​a land with different sides, we add two parallel sides, width by width, and divide by 2, thus obtaining the average. With the values ​​of the average of the parallel sides, we multiply the two and thus obtain the square meters of a plot of land with different sides.\n");
printf("\nTo calculate the perimeter of both a property with equal sides and a property with different sides, simply add the values ​​of all sides. If a property has more than 4 sides, simply add (N) more sides to the 4 existing sides to obtain the perimeter.\n");
printf("\nTo Calculate the Number of Blocks in a Wall:\n");
printf("\nTaking as example on a concrete block with dimensions (19Hx19Wx9C) in centimeters in horizontal axis view, and knowing that calculating a square meter of a wall will be H x W then 1 cement block has 19cm, so height with 5 blocks x width with 5 blocks = 25 blocks, so a square meter has 25 blocks so this will be the standard measurement. 25 x so many square meters = the amount of blocks to build a wall. \n");
printf("\nImportant information: \n");
printf("\nThis algorithm was built with integer variables so it does not accept numbers with commas e.g.: 2.90 meters change to 3 meters.\n");
printf("\nPress enter to return menu...\n ");
getchar();
scanf("c\n");
reset_screen();
return;
}

void reset_screen(){
system("clear");      // linux
system("tput reset"); // linux
system("Cls"); // windows clear screen
return;
}

int menu_programmer(){
  reset_screen();
  printf("\n Algorithm: Measurement and Calculation for Civil Engineering \n");
  printf("\n Author: PHNO ");
  printf("\n Release Date: 29/11/2024 ");
  printf("\n Version: 0.0.0.2v");
  printf("\n Replit: @PHNO, @PHREPLIT");
  printf("\n E-mail: phreplit@gmail.com \n");
  printf("\n Press enter to return menu...\n ");
  getchar();
  scanf("c\n");
  reset_screen();
  return 0;
}
