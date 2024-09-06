using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrafos
{
    internal class ClasseGrafo
    {
        private int[,] MatrizGrafo;


        public ClasseGrafo(int V)
        {
            MatrizGrafo1 = new int[V,V];
        }
        public int[,] MatrizGrafo1 { get => MatrizGrafo; set => MatrizGrafo = value; }

        public String Multigrafo()
        {
            string aux = "";
            int numero_lacos = 0;
            int numero_paralelas = 0;
            bool multigrafo = false;

            for (int i = 0; i < MatrizGrafo1.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizGrafo1.GetLength(1); j++)
                {
                    if (i == j && MatrizGrafo1[i, j] > 0)
                    {
                        numero_lacos++;
                        multigrafo = true;
                    }

                    if (i != j && MatrizGrafo1[i, j] > 1)
                    {
                        numero_paralelas++;
                        multigrafo = true;
                    }
                }
            }

            if(multigrafo == true)
            {
                aux = $"É um multigrafo\n" +
                    $"Número de laços: {numero_lacos}\n" +
                    $"Número de arestas paralelas: {numero_paralelas}";
            }
            else
            {
                aux = "Não é um multigrafo, portanto não tem nenhuma aresta paralela e nenhum laço";
            }
            return aux;
        }
    }
}
