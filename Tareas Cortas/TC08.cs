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
	Estudiante: [M. Fernanda González Sáchez.]
	
	Enunciado:
	Validez de parentesis:
	Se va a recibir un string S que contienen unicamente los caracteres '(' y ')', ustedes deben escribir una funcion que valida si la secuencia de parentesis es valida,
	esto quiere decir que cada parentesis abierto tenga un parentesis que lo cierre.
	Por ejemplo:
	"()" -> True
	"((" -> False
	"(()(()))" -> True
	"(()(())))" -> False
*/

//Your code starts here

using System;

namespace TC08
{//class sequenceInParentheses
    public class sequenceInParentheses
    {//function that receives a string of parentheses and determines whether they are closed or open
        public bool parentheses(string chainParentheses)
        { 
            //variable that helps us keep track of parentheses
            int firstCounter = 0;
            int secondCounter = 0;
           // boolean variable that stores the answer
            bool answer = false;

            Console.Write(chainParentheses + "\n");//Displays the string in parentheses entered

            for (int i = 0; i < chainParentheses.Length; i++)//loop through the string entered from the 0 position to the length of the string
            {

                if (chainParentheses[i] == '(')//It asks the question if the parenthesis is open
                {
                    firstCounter++;//if it meets increments the counter

                }

                if (chainParentheses[i] == ')')// It asks the question if the parenthesis is closed
                {

                    secondCounter++;//if it meets increments the counter 

                }

            }

            if (firstCounter == secondCounter)//compares both counters to see if they are equal
            {
                answer = true;//if the variable is true answer is fulfilled
            }
            else
            {
                answer = false;//otherwise it is false
            }

            Console.WriteLine(answer);//Displays the answer

            Console.ReadKey();// Stop the program until a key is pressed
            return answer;//returns whether false or true

        }
    }
}
    //I chose this way of doing this because it is a simple way to go comparing each character in the string by a for, 
    //then to know if they are closed or open use conditions that evaluate counters parentheses.