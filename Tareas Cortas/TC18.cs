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
	Tarea Corta 18
	Estudiante: [María Fernanda González Sánchez]
	
	Enunciado:
	Retorne los elementos comunes en dos arreglos de enteros
	Ejemplo:
	[1,2,3,4,5,6,7],[6,7,8,9,0] -> [6,7]
*/

//Your code starts here

using System;

namespace TC18
{//class that contains the function common Elements
    public class commonElementsInArrays
    {
        //Function that returns the common elements in two arrays of integers
        public int[] commonElements(int[] array1, int[] array2)
        {
           
            Console.Write("Array 1: \n");//message on the screen
            for (int i = 0; i < array1.Length; i++)//runs the entered pursuant to print on screen
            {
                Console.Write(array1[i] + ",");
            }
            Console.Write("\n\n");//space
            Console.Write("Array 2: \n");//message on the screen
            for (int i = 0; i < array2.Length; i++)// runs the second entered pursuant to print on screen
            {
                Console.Write(array2[i] + ",");
            }
            Console.Write("\n\n");//space
            Console.Write("The common elements are: \n");//message on the screen
            for (int i = 0; i < array1.Length; i++)//runs the first arrangement
            {
                for (int j = 0; j < array2.Length; j++)//runs through the second array
                {
                    if (array1[i] == array2[j])//if the first array has the same elements to the second array
                    {//If prints are it meets the common elements
                        Console.Write(array1[i] + ",");
                    }
                }

            }


            Console.ReadKey();// Stop the program until a key is pressed
            return array1;//returns the elements in common
        }

    }
}
    //I decided to do the exercise this way because it is an easy way to compare each element in the array by two for.
    //The first entered for walking the first array, the second runs for the second entered under one condition then the elements of each arrangement is compared.