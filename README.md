# Game Of Life Starter Kit C#

Esta Kata se trata de calcular la próxima generación del juego de la vida de Conway, dada cualquier posición inicial. Consulte http://en.wikipedia.org/wiki/Conway%27s_Game_of_Life para conocer los antecedentes.
Comienza con una cuadrícula bidimensional de celdas, donde cada celda está viva o muerta. En esta versión del problema, la cuadrícula es finita y no puede existir vida fuera de los bordes. Al calcular la próxima generación, siga estas reglas:

   1. Cualquier célula viva con menos de dos vecinas vivas muere, como si la causa fuera la subpoblación.
   2. Cualquier célula viva con más de tres vecinos vivos muere, como por superpoblación.
   3. Cualquier célula viva con dos o tres vecinos vivos vive en la próxima generación.
   4. Cualquier célula muerta con exactamente tres vecinos vivos se convierte en una celda viva.

Debe escribir un programa que pueda aceptar una cuadrícula arbitraria de celdas y generará una cuadrícula similar que muestre la próxima generación.

Ejemplo de tablero:

```
Generación #0
 *  -  -  -  * 
 *  *  *  -  * 
 *  -  *  -  - 
 -  *  -  -  - 
 *  -  -  *  - 
 ```


_Referencia: https://codingdojo.org/kata/GameOfLife/_
