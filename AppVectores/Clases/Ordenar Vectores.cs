using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores.Clases
{
    class Ordenar_Vectores
    {
        /// <summary>
        /// Generador de Datos
        /// </summary>
        /// <returns></returns>
        public static int generar()
        {
            int n = 0;
            Random aleatorio = new Random();
            n = aleatorio.Next(1, 101);        
            return n;
        }
        
        /// <summary>
        /// Ordenamiento burbuja
        /// </summary>
        /// <returns></returns>
        public static int ordenar()
        {
            int MAX = 20;
            int[] vector = new int[MAX];
            int i,auxi;
            for (i = 0; i < MAX; i++)
            {
                for (int x = 0; x < MAX; x++)
                {
                    if (vector[x] > vector[x + 1])
                    {
                        auxi = vector[x];
                        vector[x] = vector[x + 1];
                        vector[x + 1] = auxi;
                    }
                }
            }
            return vector[MAX];
        }
    }
}
