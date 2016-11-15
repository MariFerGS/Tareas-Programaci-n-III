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
	Tarea Corta 3
	Estudiante: [María Fernanda González Sánchez]
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/

//Your code starts here

using System;


namespace TC03
{// Class containing the function identifyRepeatedNumber
    public class repeatedNumber
    {

        // Function that takes a number and compares the number of times the number appears in the input array
        public int identifyRepeatedNumber(int number, int[] array)
        {//initialization variable in 0
            //variable that counts how many times it appears the number in the array
            int i = 0, accountNumberRepeated = 0;


            while (i < array.Length)// It will repeat the cycle if it is less than the size of the array, starting at position 0
            {
                if (array[i] == number)// Asks whether the number is in a position equal to the number that was saved in the variable number
                    accountNumberRepeated++;// Store is many times that number in the array

                i++;// Cycle counter
            }

            // Displays the number of times it appears the number
            Console.WriteLine("The amount of times it appears the number " + number + " is: " + accountNumberRepeated);
            Console.ReadKey();// Stop the program until a key is pressed
            return accountNumberRepeated;//returns the number of times it repeats the number
        }
}
}
        // I Implemented this solution because it is a quick way to compare the number entered with all the 
        //elements in an array; through a cycle the number of times that the item appears in the array is determined

