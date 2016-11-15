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
	Estudiante: [M.Fernanda González Sánchez]
	
	Enunciado:
	Haga una funcion que imprima los primeros 100 elementos de la secuencia de fibonacci
	Fibonacci -> https://en.wikipedia.org/wiki/Fibonacci_number
*/

//Your code starts here
using System;

namespace TC16
{
    // class containing the method fibonacci
    public class Fibonacci
    {//function that prints the first 100 elements of the Fibonacci sequence
        public int fibonacci()
        {//variables that help us add and give the answer
            int number1 = 1, number2 = 0, answer = 0;

            Console.WriteLine("0");//prints the zero because so begins the Fibonacci sequence
            for (int i = 0; i < 100; i++)//way through the 100 elements entered from the position 0
            {
                number2 = number1;//the variable number 2 take the value of the variable number1
                number1 = answer;//the variable number 1 is assigned the value of the variable asnwer
                answer = number1 + number2;//adds the number in the variable 1 and variable 2
                Console.WriteLine(answer);//printed answers
            }

            Console.ReadKey();// Stop the program until a key is pressed
            return answer;//returns the response
        }
}
    }
    //I performed this function because it is a short and quick way to go through a for the input array.
    //In addition, exchange variables to make the sum of the previous numbers of the Fibonacci sequence