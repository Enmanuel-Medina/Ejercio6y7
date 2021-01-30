using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_6_y_7.Capitulo6y7
{
    class Menu
    {
        public ejer7_1()
        {




            string Entrada = "";
            int Calificacion, Cantidad = 0;
            float Suma = 0.0f, Promedio = 0.0f, Minimo = 0.0f, Maximo = 0.0f;

            Console.Write("Ingrese la cantidad de alumnos: ");
            Entrada = Console.ReadLine();
            Cantidad = Convert.ToInt32(Entrada);
            ArrayList ListaCali = new ArrayList(Cantidad);

            for (int X = 0; X < Cantidad; X++)
            {
                Console.WriteLine("Ingrese la calificación: ");
                Entrada = Console.ReadLine();
                Calificacion = Convert.ToInt32(Entrada);
                ListaCali.Add(Calificacion);
                Suma += Calificacion;
                if (X == 0)
                {
                    Maximo = Calificacion;
                    Minimo = Calificacion;
                }
                if (Calificacion < Minimo)
                    Minimo = Calificacion;
                if (Calificacion > Maximo)
                    Maximo = Calificacion;
            }
            Promedio = Suma / Cantidad;

            Console.WriteLine("\n\nEl promedio es: {0}", Promedio);
            Console.WriteLine("La calificación mínima es: {0}", Minimo);
            Console.WriteLine("La calificación máxima es: {0}", Maximo);

        }

    }
}