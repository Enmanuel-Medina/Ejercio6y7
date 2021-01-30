using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_6_y_7.Capitulo6y7
{
   public class ejer6_4
    {
        // varaiables necesarias
        int cantidad = 0; //cantidad de alumnos
        int salones = 0; //  cantidad de salones
        int n = 0; // variables de control de ciclo salones
        int m = 0; // variables de control de ciclo alumnos
        string valor = "";
        // variables para el promedio
        float suma = 0.0f;
        float promedio = 0.0f;
        // variables para la  calificacion minima
        float minima = 0.0f;
        float mayor = 0.0f;
        // variables para la calificacion maxima
        float[][] calif;
        public ejer6_4()
        {
            Inicializar();
        }
        void Inicializar()
        {

            //pedimos la cantidad de salones

            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            calif = new float[salones][];
            PedirAlumnos(calif);
            PedirCalificaciones(calif);
            Promedio(calif);
            NotaMenor(calif);
            NotaMayor(calif);
            Imprimir(calif);
        }
        public void NotaMayor(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                mayor = calificaciones[n][0];
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    if (calificaciones[n][m] > mayor)
                        mayor = calificaciones[n][m];

                }
                Console.WriteLine($"La nota mayor del salon {n + 1} es {mayor}");
            }
        }

        public void NotaMenor(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                minima = calificaciones[n][0];
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    if (calificaciones[n][m] < minima)
                        minima = calificaciones[n][m];

                }
                Console.WriteLine($"La nota minima del salon {n + 1} es {mayor}");
            }
        }

        public void Promedio(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                suma = 0;
                for (m = 0; m < calificaciones[n].GetLength(0); m++) //Ciclo alumnos
                {
                    suma += calificaciones[n][m];
                }
                promedio = suma / calificaciones[n].GetLength(0);
                Console.WriteLine($"El promedio del salon {n + 1} es {promedio}");
            }
        }

        public void Imprimir(float[][] calificaciones)
        {
            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Salon {n}");
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    Console.WriteLine($"El alumno {m} tiene {calificaciones[n][m]} ");
                }

            }
        }
        public void PedirCalificaciones(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Salon {n}");
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificación ");
                    valor = Console.ReadLine();
                    calificaciones[n][m] = Convert.ToSingle(valor);
                }
            }
            calif = calificaciones;
        }
        public void PedirAlumnos(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Dame la cantidad de alumnos para el salon {n}: ");
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                calificaciones[n] = new float[cantidad];
            }
            calif = calificaciones;
        }

    }
}

