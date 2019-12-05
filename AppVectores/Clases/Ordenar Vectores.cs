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
        public static int[] generar(int tamanio)
        {
            //inicializar el generador de números aleatorios
            //con una semilla
            var contador = Environment.TickCount;
            var random = new Random(contador);

            int[] vector = new int[tamanio];
            for(int i=0;i<tamanio;i++)
            {
                vector[i] = random.Next(1, 101);
            }
            return vector;
        }
        
        /// <summary>
        /// Ordenamiento burbuja
        /// </summary>
        /// <returns></returns>
        public static  void ordenar(int[] vector,int tamanio)
        {
            
            //int MAX = 20;
            //int[] vector = new int[MAX];
            int aux;
            for (int i = 0; i < tamanio; i++)
            {
                for (int j = i+1; j < tamanio; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }
    }
}
