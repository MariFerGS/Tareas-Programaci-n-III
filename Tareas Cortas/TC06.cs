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
	Tarea Corta 6
	Estudiante: [M.Fernanda González S.]
	
	Enunciado:
	El palindromo mas corto, 
	Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
	"aace" -> aacecaa
	"abcd" -> "abcdcba"
*/

//Your code starts here

using System;

namespace TC06
{//class palindrome
    public class shorterPalindrome
    {
        //function that returns the shortest palindrome from a string entered
        public string palindrome(string word)
        {
            string chainOfLetters = "";//variable that helps us store the new string reversed
            string palindrome = "";//variable that serves to raise the string I entered the string invested

            int i = word.Length;//keeps the size of the string entered

            for (int j = i - 2; j >= 0; j--)//runs along the string back and forth from position 2
            {
                chainOfLetters = chainOfLetters + word[j];//stores each letter of the word traveled to the contrary in the variable string of letters.
            }
            palindrome = word + chainOfLetters;//board the entered string with the new string
            Console.Write(palindrome);//screen printed on the palindrome
            Console.ReadKey();// Stop the program until a key is pressed
            return palindrome; //returns the string made a palindrome
        }
    }
}
    //I made this function because it is a quick way to go through a string for the back forward, in order to form a new string. 
    //In order to form the palindrome he began to travel the word from the poscion two and then joined the original input string.