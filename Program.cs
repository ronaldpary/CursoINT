using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoINT
{
    class Progam
    {
        static void Main(string[] args)
        {
            // CICLOS ANIDADOS
            List<string> lista_de_alumnos = new List<string>()
            {
                "Paco",
                "Lupita",
                "Joel",
                "Luis"
            };

            List<string> lista_de_alumnos2 = new List<string>()
            {
                "Paco",
                "Lupita",
                "Joel",
                "Luis",
                "Paco",
                "Paco",
                "Lupita",
                "Luis"
            };

            for (int i = 0; i < lista_de_alumnos.Count; i++)
            {
                int contador = 0;

                for (int h = 0; h < lista_de_alumnos2.Count; h++)
                {
                    if (lista_de_alumnos[i] == lista_de_alumnos2[h])
                    {
                        contador++;
                    }
                    
                }

                Console.WriteLine("EL nombre" + lista_de_alumnos[i] + "aparece" + contador + "veces");
            }

            // LISTAS 
            //List<string> lista_de_alumnos = new List<string>();

            //lista_de_alumnos.Add("Luis");
            //lista_de_alumnos.Add("Jaimre");
            //lista_de_alumnos.Add("Laura");

            //List<string> lista_de_alumnos2 = new List<string>()
            //{
            //    "Paco",
            //    "Lupita",
            //    "Joel",
            //    "Luis"
            //};

            //if (lista_de_alumnos[0] == lista_de_alumnos2[3])
            //{
            //    Console.WriteLine("Son el mismo");
            //}

            //lista_de_alumnos2.Insert(2, "Kevi");
            //lista_de_alumnos2.Add("JIL");

            //lista_de_alumnos2.RemoveAt(0);
            //lista_de_alumnos2.RemoveAt(0);

            //lista_de_alumnos2.Remove("Joel");

            //lista_de_alumnos2.RemoveAll(nombre => {
            //    if (nombre.StartsWith("J"))
            //        return true;
            //    else
            //        return false;
            //});


            //lista_de_alumnos2.Add("Alber");

            //lista_de_alumnos2.Sort();
            //lista_de_alumnos2.Reverse();

            //foreach (string alumno in lista_de_alumnos)
            //{
            //    Console.WriteLine(alumno);
            //}

            //Console.WriteLine("\n");

            //for (int cont = 0; cont < lista_de_alumnos2.Count; cont++)
            //{
            //    Console.WriteLine(lista_de_alumnos2[cont]);
            //}


            //PILAS Y FILAS

            //Queue miFila = new Queue();
            ////primera persona en llegar luis
            //miFila.Enqueue("Luis");
            //miFila.Enqueue("Pedrio");
            //miFila.Enqueue("Laura");

            //Stack miPila = new Stack();

            //miPila.Push("Luis");
            //miPila.Push("Laura");
            //miPila.Push("David");

            //Console.WriteLine(miPila.Count);

            //miPila.Clear();

            //Console.WriteLine(miPila.Count);

            //int tamannioPila = miPila.Count;

            //for (int i = 0; i < tamannioPila; i++)
            //{
            //    Console.WriteLine("Los valores de la pila son" + miPila.Pop());
            //}

            //Queue filaClon = (Queue)miFila.Clone();


            //Console.WriteLine(miFila.Count);
            //for (int i = 0; i < 3; i ++)
            //{
            //    Console.WriteLine("La señora atendera a:" + miFila.Dequeue());
            //}

            //Console.WriteLine(miFila.Count);

            //Console.WriteLine("Los valores de filaclon son: " + filaClon.Count);

            //filaClon.Clear();

            //Console.WriteLine("Los valores de filaclon son: " + filaClon.Count);
        }
    }
}