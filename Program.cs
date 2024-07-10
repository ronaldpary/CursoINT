using System;
using System.Collections;

namespace CursoINT
{
    class Progam
    {
        static void Main(string[] args)
        { 
            Queue miFila = new Queue();
            //primera persona en llegar luis
            miFila.Enqueue("Luis");
            miFila.Enqueue("Pedrio");
            miFila.Enqueue("Laura");

            Stack miPila = new Stack();

            miPila.Push("Luis");
            miPila.Push("Laura");
            miPila.Push("David");

            Console.WriteLine(miPila.Count);

            miPila.Clear();

            Console.WriteLine(miPila.Count);

            int tamannioPila = miPila.Count;

            for (int i = 0; i < tamannioPila; i++)
            {
                Console.WriteLine("Los valores de la pila son" + miPila.Pop());
            }

            Queue filaClon = (Queue)miFila.Clone();


            Console.WriteLine(miFila.Count);
            for (int i = 0; i < 3; i ++)
            {
                Console.WriteLine("La señora atendera a:" + miFila.Dequeue());
            }

            Console.WriteLine(miFila.Count);

            Console.WriteLine("Los valores de filaclon son: " + filaClon.Count);

            filaClon.Clear();

            Console.WriteLine("Los valores de filaclon son: " + filaClon.Count);
        }
    }
}