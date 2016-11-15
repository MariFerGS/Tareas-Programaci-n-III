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
	Estudiante: [M.Fernanda González S.]
	
	Enunciado:
	Dado un string S, encuentre todos los caracteres repetidos en el string, imprima una linea con cada caracter repetido y cuantas veces aparece
	Ejemplo:
	"abcdabeacd"
	>a,3
	>b,2
	>c,2
	>d,2
*/

//Your code starts here

using System;
namespace TC17
{//class containing the function repeat
    public class repeatedLetters
    {
        //function that given a string, finds all repeated characters in the string and how many times it appears
        public string repeat(string words)
        {
            string lowercaseWord = words.ToLower();//convert uppercase to lowercase 
            char[] repeated = lowercaseWord.ToCharArray();//converts the input string into an array of characters
            int chainSize = repeated.Length;//variable that stores the size of the chain length
            //initializing variables for
            int i = 0;
            int j = 0;
            int counterLetters = 0;//variable that helps to store the number of times repeating the letters

            // Displays messages on screen
            Console.WriteLine("String entered: " + words);
            Console.WriteLine("Repeated letters:");

            for (i = 0; i < chainSize; i++)
            {//two for that help walk the arrangement entered


                counterLetters = 0;//it restates the variable to zero
                for (j = 0; j < chainSize; j++)
                {
                    if (j < i && repeated[i] == repeated[j])//condition asking if the letter is in a lower position that i equals the letter that is in the position j
                    {

                        break;
                    }
                    if (repeated[j] == repeated[i])
                    {//asks whether the character is in a position that is the same as the other character
                        counterLetters++;//if so increments the counter

                    }
                    if (j == chainSize - 1)//condition that compares the position and size of char from back to front
                    {
                        if (counterLetters >= 2)
                        {//question if the letters are repeated more than twice
                            Console.WriteLine(">"+repeated[i] + "," + counterLetters);//if so the prints
                        }

                    }

                }
            }
            if (counterLetters == 1)//if the number of repeated characters is equal to 1, displays a message
            {
                Console.WriteLine("No repeated letters");

            }

            Console.ReadKey();// Stop the program until a key is pressed
            return words;//returns the response


        }
    }
}
    //I chose to perform this function because it is an easy way to find repeated letters by walking for the input array.
    //Also I implemented conditions, the first condition evaluates if repeated letters, the second condition evaluates that if they are repeated count the repeated letters, the last condition evaluates if the counter of letters is greater than or equal to two print letters, otherwise display a message indicating that no repeated numbers.