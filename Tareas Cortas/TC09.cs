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
	Estudiante: [María Fernanda González Sánchez.]
	
	Enunciado:
	Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
	Ejemplo:
	"the sky is blue" -> "blue is sky the"
	
	
*/

//Your code starts here

using System;


namespace TC09
{//class RotationOfWordsInAString
    public class RotationOfWordsInAString
    {//function that receives a string and returns a new string in which his words are rotated.
        public string reverseOrderOfSentence(string sentence)
        {
            char[] space = { ' ' };//save the blank arrangement
            string[] words = sentence.Split(space);//It makes split when you have blanks
            string newString = "";//variable that will store the new string
            Console.WriteLine("Original String:");//prints the message
            for (int i = 0; i < words.Length; i++)//runs along the string entered
            {
                Console.Write(words[i] + " ");//shows the original arrangement
            }
            Console.WriteLine("\n");//space


            Console.WriteLine("Chain in a different order:");//prints the message
            for (int i = words.Length - 1; i >= 0; i--)//arrangement runs back and forth
            {
                newString = words[i];
                Console.Write(newString + " ");//prints the inverted arrangement
            }

           

            Console.ReadKey();// Stop the program until a key is pressed
            return newString;//returns the new string values

        }
    }
}
    //I made this function because it is a quick way to reverse a string by a for. 
    //I used the runs for the string entered from back to front and is storing each separated by a space in a new variable word.