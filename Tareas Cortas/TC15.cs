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
	Estudiante: [Maria Fernanda González Sánchez]
	
	Enunciado:
	Encontrar duplicado: Usted va a recibir un arreglo de 100 elementos, que contiene numeros del 1 al 100, exactamente un elemento esta duplicado, 
	debe retornar el numero duplicado en el arreglo
*/

//Your code starts here
using System;
namespace TC15
{//class containing the function
    public class findDuplicateNumbers
    {//Function that receives an array of 100 elements, which contains numbers from 1 to 100, exactly one element is doubled, returning the number doubled in the arrangement
        public int duplicateNumbers(int[] chainOfNumbers)
        {
            int number = 0;//variable that helps us to return the duplicate number.
            Console.WriteLine("The input array is: ");//print message on screen
            for (int a=0;a<chainOfNumbers.Length;a++)
            {//for walking the input array to display on screen
                Console.Write( chainOfNumbers[a] + " ");
            }
            Console.WriteLine("\n");//space
            for (int i = 0; i < chainOfNumbers.Length - 1; i++)//tour the array from 0.
            {
                for (int j = i + 1; j < chainOfNumbers.Length; j++)//runs through the settlement taking into account the previous position
                {//asks if the previous item is equal to the stored position j
                    if (chainOfNumbers[i].Equals(chainOfNumbers[j]))
                    {
                        //shows the number doubled in the arrangement
                        Console.WriteLine("The duplicate number is: " + chainOfNumbers[j]);
                    }
                }

            }

            Console.ReadKey();// Stop the program until a key is pressed
            return number;//returns the number doubled.
        }
    }
}
    //Chose this solution because it is an easy way to traverse the array entered by two and go for comparing a number with all of the above to see if it is repeated.
