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
	Retorne la combinacion de los elementos unicos de dos arreglos de enteros
	Ejemplo
	[1,2,3,4,5,6],[5,6,7,8,9] -> [1,2,3,4,5,6,7,8,9]
	
*/

//Your code starts here
using System;

using System.Linq;//reference that allows me to use the concat methods, List and distinct

namespace TC19
{////class containing the function 
    public class uniqueCombinationOfElements
    {
        //Function that returns the combination of the unique elements of two arrays of integers
        public int[] combinationOfElements(int[] array1, int[] array2)
        {
            int lowToHigh = 0;//variable that helps us sort the numbers from lowest to highest
            int[] chainOfNumbers = { };//auxiliary array that will help us to store the new chain of elements

            chainOfNumbers = array1.ToList().Concat(array2.ToList()).ToArray();//method linking the two arrangements

            Console.Write("Array 1: \n");//message on the screen
            for (int i = 0; i < array1.Length; i++)//runs the entered pursuant to print on screen
            {
                Console.Write(array1[i] + " ");
            }
            Console.Write("\n\n");//space
            Console.Write("Array 2: \n");//message on the screen
            for (int i = 0; i < array2.Length; i++)// runs the second entered pursuant to print on screen
            {
                Console.Write(array2[i] + " ");
            }
            Console.Write("\n\n");//space


            for (int i = 0; i < chainOfNumbers.Length; i++)//runs the arrangement from the position 0 to the length of the array.
            {
                for (int j = i + 1; j < chainOfNumbers.Length; j++)//runs through the settlement taking into account the previous position 
                {
                    if (chainOfNumbers[i] > chainOfNumbers[j])//asks whether stored in the variable i is greater than the number variable j
                    {//The accommodates low to high
                        lowToHigh = chainOfNumbers[i];
                        chainOfNumbers[i] = chainOfNumbers[j];
                        chainOfNumbers[j] = lowToHigh;
                    }


                }
            }

            int[] eliminateRepeated = chainOfNumbers.Distinct().ToArray();//removing the number under repeated
            Console.WriteLine("\n");//space

            Console.WriteLine("Combination of arrangements");
            //Prints the chain together without repeating numbers
            for (int i = 0; i < eliminateRepeated.Length; i++)
            {
                Console.Write(eliminateRepeated[i] + " ");
            }




            Console.ReadKey();// Stop the program until a key is pressed
            return chainOfNumbers;

        }

    }
}
    //I chose this way of doing this because it is an easy way to sort arrays for admitted through.
    //Using two methods, concat to join the admitted and the distinct arrangements to remove repeated numbers.