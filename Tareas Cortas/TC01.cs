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
	Estudiante: [María Fernanda González Sánchez]
	
	Enunciado:
	Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
*/

//Your code starts here

using System;


namespace TC01
{
    public class LargeNumber
    {

        public int LargeNumber(int[] numbers)//feature an array of integers
        {
            // Declaration of variables to 0.
            int largenumber = 0;


            for (int i = 0; i < numbers.Length; i++)// Walk the array from the zero position until i is greater than the length of the array

            {

                if (numbers[i] > largenumber) // Question for each number if greater than the previous

                {
                    largenumber = numbers[i]; // The assessed number is assigned to the variable number as the new big number, so on until the cycle is met
                }

            }
           //shows the largest number of array
            Console.WriteLine(string.Format("The Large number is: {0} ",largenumber));
             Console.ReadKey();// Stop the program until a key is pressed
            return largenumber;//returns the largest number in the list



        }



    }
}
//I chose this solution because it is a simple and fast way to do.
//Also, when using arrangements no mistaking the number of component parts and are easier to follow some cycle.