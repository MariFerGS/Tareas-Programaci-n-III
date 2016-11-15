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
	Tarea Corta 7
	Estudiante: [M.Fernada Gonzalez Sánchez]
	
	Enunciado:
	Dado un arreglo de longitud N, retornar un arreglo que contenga los K caracteres mas frecuentes.
	Ejemplo:
	[1,2,3,4,3,2,5], 2 -> Queremos los dos caracteres mas frecuentes del arrelgo
	Resultado -> [2,3] 
*/

//Your code starts here
using System;

namespace TC07
{//class containing the method repeatedNumbers
    public class repeatedNumbersInTheArray
    {
        //Function that given an array, returns an array containing the most common characters.
        public int[] repeatedNumbers(int[] chainOfNumbers)
        {

            Console.WriteLine("Chain Original:");//displays on-screen message
            for (int i = 0; i < chainOfNumbers.Length; i++)//travel array from position 0
            {
                Console.Write(chainOfNumbers[i] + " ");//array numbers entered sample
            }
            Console.WriteLine("\n");//Space
            Console.WriteLine("Repeated Numbers in the chain:");//displays on-screen message

            for (int i = 0; i < chainOfNumbers.Length; i++)//travel array from position 0
            {
                for (int j = i + 1; j < chainOfNumbers.Length - 1; j++) //runs through the settlement taking into account the previous position
                {


                    if (chainOfNumbers[i] == chainOfNumbers[j])// The last element of the array with the current is compared to see if they are equal
                    {
                        // Shows the numbers repeated on screen
                        Console.Write(chainOfNumbers[i] + " ");
                    }
                }

            }

            Console.ReadKey();// Stop the program until a key is pressed
            return chainOfNumbers;// Returns the repeated numbers in the array
        }

    }
}

    //I decided to perform this function because it is an easy way to traverse the array entered by two for.
    //One starts from the position for 0 to the length of the array, the other for runs starting from the next position to be compared.
    //Then compare if stored if arrangements are the same.