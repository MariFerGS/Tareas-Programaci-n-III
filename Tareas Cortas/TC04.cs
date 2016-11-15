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
	Tarea Corta 4
	Estudiante: [M.Fernanda González Sánchez]
	
	Enunciado:
	Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
	La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
	Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
*/

//Your code starts here

using System;

namespace TC04
{// Class that contains the function palindrome
    public class palindrome {
        // Method receives a string and returns a Boolean
        public bool palindromeword(string word) { 
            bool answer = false; //It is initialized to false variable indicating whether it is a palindrome
            string chainOfLetters = "";// Store the new string, it is initialized empty


            int i = word.Length; //variable that stores the length of the input string
            string lowerCase = word.ToLower(); //converts lowercase word entered and assigned to the variable Lowercase
            for (int j = i - 1; j >= 0; j--)// chain travels back and forth
            {
               // it stores each letter in the new chain chainOfLetters
                   chainOfLetters = chainOfLetters + lowerCase[j];
            }
            if (chainOfLetters == lowerCase)// Asks if the word stored upside is equal to the entered
            {//It shows true if the condition is met
                answer = true;
            }
            //if false sample is not met
            else
            {
                answer= false;
                    
            }
            Console.WriteLine(answer);//Displays the answer
            Console.ReadKey();// Stop the program until a key is pressed
            return answer;
            // Returns a Boolean
        }
}
    }
    // I chose this solution because it is a quick and safe way to get around the word entered through a cycle, 
    //the method further ToLower was implemented to convert all letters to lowercase to avoid the error when comparing,
    //as the cycle runs with capital, but when it returns ignores the uppercase and lowercase recognized as one.
    //conditions were also used to assess whether the entered word is a palindrome.