/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 2
	Estudiante: [María Fernanda González S.]
	
	Enunciado:
	Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
	Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
*/

//Your code starts here

using System;


namespace TC02
{
    public class InvestingChainNumbers
    {//function reverses the numbers array
        public int[] InvestingArrayNumbers(int[] chainOfNumbers)
        {
            int[] invertedChainOfNumbers = new int[chainOfNumbers.Length];//the variable will have the size that is entered in the main array
            Console.Write("Entered array: ");//displays on-screen message

            for (int i = 0; i < chainOfNumbers.Length; i++)//travel array from position 0
            {
                Console.Write(chainOfNumbers[i] + " ");//array numbers entered sample
            }

            Console.WriteLine("\n");//Displays screen space between the two message
            Console.Write("Invested array numbers: ");//displays on-screen message
            for (int i = (chainOfNumbers.Length - 1), j = 0; i >= 0; i--, j++)
            //The array starts to go backwards
            //Then retraces and store the new array in the variable invertedChainOfNumbers
            {
                invertedChainOfNumbers[j] = chainOfNumbers[i];

                Console.Write(invertedChainOfNumbers[j] + " ");//Shows the new array on screen

            }
               Console.ReadKey();// Stop the program until a key is pressed
            //returns the new chain of numbers
            return chainOfNumbers;

        }
}
}
        //It is very easy to implement, because we're going through the numbers 
        //from the last character to the first and we saved each letter in a new array,
        //which is the restore function.