using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ti_triTableau_andras
{
    public struct traitement
    {
        public void CreerTableau(out int[] tableau)
        {
            string valeurTaille;
            int taille;
            do
            {
                Console.Write("Entrez la taille du tableau : ");
                valeurTaille = Console.ReadLine();
            } while (!int.TryParse(valeurTaille, out taille));

            tableau = GenererTableauAleatoire(taille);
        }

        public int[] GenererTableauAleatoire(int taille)
        {
            int[] tableau = new int[taille];
            Random random = new Random();

            for (int i = 0; i < taille; i++)
            {
                tableau[i] = random.Next(1, 101);
            }
            return tableau;
        }

        public int[] CopierTableau(int[] tableau)
        {
            int[] tableau2 = new int[tableau.Length];
            Array.Copy(tableau, tableau2, tableau.Length);
            return tableau2;
        }

        public void SupprimerTableau(ref int[] tableau2)
        {
            tableau2 = null; 
        }

        public string AfficherTableau(int[] tableau, out string message)
        {
            message = "";
            foreach (var nombre in tableau)
            {
                message = message + " " + nombre;
            }
            return message;
        }

        public void TriSelection(int[] tableau2)
        {
            for (int i = 0; i < tableau2.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < tableau2.Length; j++)
                {
                    if (tableau2[j] < tableau2[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = tableau2[i];
                tableau2[i] = tableau2[minIndex];
                tableau2[minIndex] = temp;
            }
        }
        public void TriBulle(int[] tableau2)
        {
            int n = tableau2.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (tableau2[i - 1] > tableau2[i])
                    {
                        int temp = tableau2[i - 1];
                        tableau2[i - 1] = tableau2[i];
                        tableau2[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }
        public void TriInsertion(int[] tableau2)
        {
            int n = tableau2.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = tableau2[i];
                int j = i - 1;

                while (j >= 0 && tableau2[j] > key)
                {
                    tableau2[j + 1] = tableau2[j];
                    j = j - 1;
                }
                tableau2[j + 1] = key;
            }
        }
        public void TriIntuitif(int[] tableau2)
        {
            for (int i = 0; i < tableau2.Length - 1; i++)
            {
                for (int j = i + 1; j < tableau2.Length; j++)
                {
                    if (tableau2[j] < tableau2[i])
                    {
                        int temp = tableau2[i];
                        tableau2[i] = tableau2[j];
                        tableau2[j] = temp;
                    }
                }
            }
        }
        public void TriShell(int[] tableau2)
        {
            int n = tableau2.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = tableau2[i];
                    int j;
                    for (j = i; j >= gap && tableau2[j - gap] > temp; j -= gap)
                    {
                        tableau2[j] = tableau2[j - gap];
                    }
                    tableau2[j] = temp;
                }
                gap /= 2;
            }
        }
    }
}
