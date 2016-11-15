/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 1
	Estudiante: [María Fernanda González S.]
	
	Enunciado:
	Formar el numero mas grande:
	Al recibir un arreglo de enteros, debe ordenarlos para formar el numero mas grande posible.
	Ejemplo:
	[3, 30, 34, 5, 9] -> 9534330
	Notese que el numero formado puede ser muy grande, entonces debe retornar un string en vez de un entero.
*/

//Your code starts here

using System;


namespace TC13
{//class containing the method largestNumber
    public class largestNumberWithArray
    {
        //method that takes an array of integers and must be ordered to form the largest number possible.
        public string largestNumber(int[] arrayOfNumbers)
        {
            int accountant = 0; //variable that helps us store numbers from highest to lowest

            int i = 0;// variable start cycles
            string chainOfNumbers = ""; //stores the new string of numbers



            // Loop through the array from position 0 to the length of the array entered
            for (i = 0; i < arrayOfNumbers.Length; i++)
            {// Cycle that increases a position taking into account the variable i go comparing to the previous item with the following
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {// Asks if the previous number is less than the next number
                    if (arrayOfNumbers[i] < arrayOfNumbers[j])
                    {
                        // If met will go accommodating the high to low
                        accountant = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[j];
                        arrayOfNumbers[j] = accountant;
                    }


                }

            }


            // Runs the numbers in the variable arrayOfNumbers
            for (i = 0; i < arrayOfNumbers.Length; i++)
            {
                chainOfNumbers = Convert.ToString(arrayOfNumbers[i]);// Converts the array of numbers in string
                Console.Write(chainOfNumbers); // Print to screen numbers stored in the variable arrayOfNumbers

            }


            Console.ReadKey();// Stop the program until a key is pressed
            return chainOfNumbers;//returns string of numbers

            // I chose this solution Because it is a simple way to receive an array and 
            //then a sort high to low by a display for result to the array Become a bigger number.



        }
    }
}
