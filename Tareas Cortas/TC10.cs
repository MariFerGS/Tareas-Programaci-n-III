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
	Tarea Corta 10
	Estudiante: [M.Fernanda González Sánchez.]
	
	Enunciado:
	Inversion de un string: Al recibir un string S, retornar un string cuyas palabras estan invertidas, sin invertir el orden de las palabras.
	"The Sky is Blue" -> "ehT ykS si eulB"
*/

//Your code starts here
using System;

namespace TC10
{//class containing the function stringOfWords.
    public class reversedWwords
    {//Function that receives a string of words, returns a string whose words are reversed, without reversing the word order.
        public string stringOfWords(string wordsEntered)
        {

            string newStringReversed = "";//variable that helps us to store new words reversed
            char[] delimiterChars = { ' ' };//delimits through spaces
            string[] words = wordsEntered.Split(delimiterChars);//defines the phrase entered through spaces
            Console.WriteLine("Phrase entered: " + wordsEntered);//displays a message
            Console.WriteLine("\n");//space
            Console.WriteLine("Inverted sentence: ");//displays a message
            foreach (var word in words)//runs the array for each element delimited space
            {
                string newString = "";//variable that will help us to store the new string
                foreach (var pieceOfWord in word.ToCharArray())
                {//runs the arrangement and extract each word element of the variable and assigns it to the new Variable

                    newString = pieceOfWord + newString;
                }
                // variable that stores the string in reverse
                newStringReversed = newStringReversed + newString + " ";

            }
            Console.Write(newStringReversed);//shows the new string

            Console.ReadKey();// Stop the program until a key is pressed
            return newStringReversed;//returns the new string

        }


    }
}
    //I performed this function because it is a quick way to tour the string entered by two foreach.
    //The first foreach tour the sentence taking into account the delimiter, which are the spaces.
    //The second foreach extracts stored word on the word and then through a concatenation inverts the words without changing the order.