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
	Haga una funcion que compare versiones, retornando -1 si el primer numero es mayor, 1 si el segundo numero es mayor y 0 y son iguales.
	Pueden asumir que los strings solo contienen numeros y el caracter '.'
	No hay un limite para la cantidad de subversiones que se pueden enviar: 1.1.1.1.1.1.1.1.1.1 es valido.
	0.1 < 1.0 < 1.0.1
	
*/

//Your code starts here
using System;

namespace TC05
{//class Version Comparison 
    public class versionComparison
    {//comparing versions function, returning -1 if the first number is greater, 1 if the second number is higher and 0 and are equal.

        public int versions(string version1, string version2)
        {
            //Convert the string entered double
            double firstNumber = Convert.ToDouble(version1);
            double secondNumber = Convert.ToDouble(version2);
            int answer = 0; //variable that helps give us the answer
            //screen printed on versions entered
            Console.WriteLine("Versions:");
            Console.WriteLine(version1);

            Console.Write(version2);
            Console.WriteLine("\n");//space
            //asks whether the first number is greater than the second number
            if (firstNumber > secondNumber)
            {// if the condition is met prints -1
                answer = -1;
                Console.WriteLine("Return: " + answer + ", the first version is more");
            }
            //asks whether the first number is less than the second
            if (firstNumber < secondNumber)
            {// if the condition is met prints 1
                answer = 1;
                Console.WriteLine("Return: " + answer + ", the second version is more");
            }
            //question whether the versions are the same
            if (firstNumber == secondNumber)
            {// if the condition is met prints 0
                answer = 0;
                Console.WriteLine("Return: " + answer + ", the versions are equals");
            }

            Console.ReadKey();// Stop the program until a key is pressed
            return answer;//returns 1, -1 or 0

        }
    }
}
    //I decided to perform the function is a simple way to compare versions conviertiendolas first numbers
    //by the method Convert toDouble, then through if compared the numbers
    //and returns 1, -1 or 0 depending on that condition is fulfilled