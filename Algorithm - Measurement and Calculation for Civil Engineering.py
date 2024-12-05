
''' Author: PHNO - Technologist | Postgraduate
    Release Date: 29/11/2024
    Version: 0.0.0.2v
    Replit: @PHNO, @PHREPLIT
    E-mail: phreplit@gmail.com  '''

''' Algorithm: Measurement and Calculation for Civil Engineering, algorithm built in python, built for students and professionals in civil engineering and related areas, such as topography. '''

import os # import lib - os clear
import sys
import json

def reset_text():
    os.system('cls' if os.name=='nt' else 'clear')

op = 0 
while op != -1:
  print('')
  print('Measurement and Calculation for Civil Engineering')
  print('')
  print('')
  print('1.Calculate Land Area (4 Equal Sides)')
  print('2.Calculate Land Area (4 Different Sides)')
  print('3.Calculate Property Perimeter (4 Equal Sides)')
  print('4.Calculate Property Perimeter (4 Different Sides)')
  print('5.Calculate How Many Square Meters a Wall Has')
  print('6.Calculate How Many Blocks per M² a Wall Will Have')
  print('7.Exit')
  print('')
  print('[8] Info')
  print('[9] About')
  print('')
  op = int(input('Enter with your choice: '))
  if op == 1:
   print('')
   v1 = int(input('Enter the length of the land: '))
   print('')
   v2 = int(input('Enter the width of the land: '))
   result = v1 * v2
   print('')
   print('The land area is: {} square meters.'.format(result))
   print('')
   print('Press enter to return to the menu...')
   a1 = str(input(''))
   reset_text()
  elif op == 2:
   print('')
   v1 = int(input('Enter the length of side 1 of the land: '))
   print('')
   v2 = int(input('Enter the length of side 2 of the land: '))
   print('')
   v3 = int(input('Enter the width of side 3 of the land: '))
   print('')
   v4 = int(input('Enter the width of side 4 of the land: '))
   resultado = int((v1 + v2) / 2)
   resultado2 = int((v3 + v4) / 2)
   resultadofinal = int(resultado * resultado2)
   print('')
   print('The area of ​​the land with different sides is {} square meters.'.format(resultadofinal))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 3:
   v6 = int(4)
   print('')
   v5 = int(input('Type one side of the property: '))
   print('')
   result3 = v5 * v6
   print('')
   print('The perimeter of the property with equal sides is {} sequence meters.'.format(result3))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 4:
   print('')
   v1 = int(input('Enter the length of side 1 of the property: '))
   print('')
   v2 = int(input('Enter the length of side 2 of the property: '))
   print('')
   v3 = int(input('Enter the width of side 3 of the property: '))
   print('')
   v4 = int(input('Enter the width of side 4 of the property: '))
   resultado = int(v1 + v2)
   resultado2 = int(v3 + v4)
   resultadofinal = int(resultado + resultado2)
   print('')
   print('The perimeter of the property with different sides has {} sequence meters.'.format(resultadofinal))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 5:    
   print('')
   v1 = int(input('Enter how many meters high the wall has: '))
   print('')
   v2 = int(input('Enter how many meters wide the wall has: '))
   result5 = v1 * v2
   print('')
   print('The wall is {} square meters.'.format(result5))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 6:
   v12 = int(25) # one square meter has 25 blocks
   print('')
   v11 = int(input('Enter how many square meters the wall has: '))
   print('')
   result6 = v11 * v12
   print('')
   print('It will take {} blocks to build a wall with {} square meters.'.format(result6,v11))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 7:
   print('')
   print('Finished Algorithm!')
   print('')
   break
  elif op == 8:
   reset_text()
   print('')
   print('Info')
   print('')
   print('To calculate the area of ​​a land with equal sides in square meters, we use Width x Length.')
   print('To calculate the area of ​​a land with different sides, we add two parallel sides, width by width, and divide by 2, thus obtaining the average. With the values ​​of the average of the parallel sides, we multiply the two and thus obtain the square meters of a plot of land with different sides.')
   print('To calculate the perimeter of both a property with equal sides and a property with different sides, simply add the values ​​of all sides. If a property has more than 4 sides, simply add (N) more sides to the 4 existing sides to obtain the perimeter.')
   print('To Calculate the Number of Blocks in a Wall:')
   print('Taking as example on a concrete block with dimensions (19Hx19Wx9C) in centimeters in horizontal axis view, and knowing that calculating a square meter of a wall will be H x W then 1 cement block has 19cm, so height with 5 blocks x width with 5 blocks = 25 blocks, so a square meter has 25 blocks so this will be the standard measurement. 25 x so many square meters = the amount of blocks to build a wall. ')
   print('Important information: ')
   print('')
   print('This algorithm was built with integer variables so it does not accept numbers with commas e.g.: 2.90 meters change to 3 meters.')
   print('This algorithm was built in Python 3 and by default always requires that its syntax and indentation are always correct for its correct compilation in the console.')
   print('')
   print('Press enter to return to the menu...')
   a5 = str(input(''))
   reset_text()
  elif op == 9:
   reset_text()
   print('')
   print('Algorithm: Measurement and Calculation for Civil Engineering')
   print('')
   print('Author: PHNO')
   print('Release Date: 29/11/2024')
   print('Version: 0.0.0.2v')
   print('Replit: @PHNO, @PHREPLIT')
   print('E-mail: phreplit@gmail.com')
   print('')
   print('Press enter to return to the menu...')
   a5 = str(input(''))
   reset_text()
  else: 
   print('')
   print('Error. Wrong Choice!')
   print('')
   print('Press enter to return to the menu...')
   a6 = str(input(''))
   reset_text()