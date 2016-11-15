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
	Estudiante: [M.Fernanda González Sánchez.]
	
	Enunciado:
	Identificador de numeros primos, escriba una funcion que indique si un numero recibido es primo o no, tome en cuenta que el numero recibido estará en un rago de 
	1 a 5000.
*/

//Your code starts here
using System;

namespace TC20
{//class containing the function primeNumbers
    public class identifyPrimeNumbers
    {
        // function indicating whether a number is prime or not received, taking into account that the number received will range from 1 to 5000.
        public bool primeNumbers(int number)
        {
            bool answer = false;//variable that helps to give the answer, is initialized to false
            int count = 0;//variable that helps us count the number of numbers that have the remainder of the division
            if (number >= 1 && number <= 5000)//evaluates whether the entered number is in the range of 1 to 5000
            {
                Console.Write(number + ": ");//shows the number entered on the screen
                for (int i = 1; i <= number; i++)//for helping us to increase dividers.
                {

                    if (number % i == 0)//if the residue is zero
                    {//increases the counter
                        count++;
                    }
                }
                if (count == 2)//if the counter is equal to two
                {//prints true if satisfied
                    answer = true;
                    Console.WriteLine(answer);

                }
                else
                {// otherwise false shows
                    answer = false;
                    Console.WriteLine(answer);

                }

            }
            else
            {//if the number entered is not between the range set displays a message
                Console.WriteLine("Enter a number between 1 and 5000");
            }

            Console.ReadKey();// Stop the program until a key is pressed
            return answer;//returns the response
        }

    }
}
    //I performed this function because it is a quick and easy way to find out whether a number is prime or not.
    //I used position to assess if the number had entered a zero residue, is implemented for increased divisor.
    //The second condition evaluates if the counter equals two, as the prime numbers are only divisible by itself and one number.