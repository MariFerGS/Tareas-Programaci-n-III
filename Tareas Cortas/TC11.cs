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
	Tarea Corta 11
	Estudiante: [M.Fernanda González Sánchez.]
	
	Enunciado:
	Sub arreglo de suma minima:
	Si se recibe un arreglo con N enteros positivos, y se recibe un numero K, retornar el subarreglo mas corto de numeros cuya sumatoria es mayor o igual al numero K.
	Ejemplo
	[2,3,1,2,4,3], 7 -> [4,3] tiene el largo minimo de numeros que sumados son iguales o mayores a 7.
*/

//Your code starts here
using System;

namespace TC11
{
    // class containing the function subarrayShorterNumbers
    public class smallerArrangement
    {
        //Function that receives an array with positive integers and receives a number, return the shortest subarray of numbers whose sum is greater than or equal to the number entered.
        public int[] subarrayShorterNumbers(int[] arrangementOfNumbers, int number)
        {
            int ordersNumbers = 0;//variable that helps us to store the numbers in order
            int sum = 0;//variable that helps us store the result of the sum
            Console.WriteLine("Entered array: ");//message on the screen
            for (int l = 0; l < arrangementOfNumbers.Length; l++)//recorre el arreglo ingresado 
            {
                Console.Write(arrangementOfNumbers[l]+ " ");//runs the arrangement from the position 0 to the length of the array.
            }
            Console.WriteLine("\n");//space
            Console.WriteLine("Entered number: "+ number);//sample number entered
            Console.WriteLine("\n");//space
            for (int i = 0; i < arrangementOfNumbers.Length; i++)//runs the arrangement from the position 0 to the length of the array.
            {
                for (int j = i + 1; j < arrangementOfNumbers.Length; j++)//runs through the settlement taking into account the previous position 
                {
                    if (arrangementOfNumbers[i] < arrangementOfNumbers[j])//if the number is less than previous
                    {//The accommodates high to low
                        ordersNumbers = arrangementOfNumbers[i];
                        arrangementOfNumbers[i] = arrangementOfNumbers[j];
                        arrangementOfNumbers[j] = ordersNumbers;
                    }


                }

            }

            //sample message
            Console.WriteLine("Smaller Array:");
            //runs the new arrangement and it adds up to become greater than or equal to the number entered

            for (int k = 0; k < arrangementOfNumbers.Length; k++)
                {
                    Console.Write(arrangementOfNumbers[k] + " ");//smaller sample arrangement
                sum = sum + arrangementOfNumbers[k];//sum of the numbers of the array smaller
                if (sum >= number)//if the sum is greater than or equal to the number entered
                {//if satisfied sale
                    break;
                    }
                }

            
            Console.ReadKey();// Stop the program until a key is pressed
            return arrangementOfNumbers;//returns the smallest settlement
        }

    }
}
    //I chose this because it is easy salución accommodate the arrangement entered high to low, then made a sum to find out which numbers in the array can be greater than or equal to the number entered.