using System.Diagnostics;

namespace _5ti_triTableau_andras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable utile
            int[] tableau;
            string message;

            //Ma librairie
            traitement programmeTableau = new traitement();

            //Les stopwatch
            Stopwatch stopWatch = new Stopwatch();  // de base
            Stopwatch stopWatch1 = new Stopwatch(); // pour les comparaisons de 1 à 6, j'ai pas trouvé de stopwatch.Reset()
            Stopwatch stopWatch2 = new Stopwatch();
            Stopwatch stopWatch3 = new Stopwatch();
            Stopwatch stopWatch4 = new Stopwatch();
            Stopwatch stopWatch5 = new Stopwatch();
            do
            {
                Console.Clear();
                // Aficher les options possibles
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        programmeTableau.CreerTableau(out tableau);

                        // Tableau sans tri
                        Console.WriteLine("\n Tableau non trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // LANCER LE CHRONO
                        stopWatch.Start();

                        // Tri par sélection
                        programmeTableau.TriSelection(tableau);

                        // FIN DU CHRONO
                        stopWatch.Stop();

                        // Tableau avec tri
                        Console.WriteLine("\n \n Tableau trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement : " + stopWatch.ElapsedMilliseconds + " ms");
                        break;

                    case "2":
                        programmeTableau.CreerTableau(out tableau);
                        
                        // Tableau sans tri
                        Console.WriteLine("\n Tableau non trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // LANCER LE CHRONO
                        stopWatch.Start();

                        // Tri à bulles
                        programmeTableau.TriBulle(tableau);

                        // FIN DU CHRONO
                        stopWatch.Stop();

                        // Tableau avec tri
                        Console.WriteLine("\n \n Tableau trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement : " + stopWatch.ElapsedMilliseconds + " ms");
                        break;

                    case "3":
                        programmeTableau.CreerTableau(out tableau);

                        // Tableau sans tri
                        Console.WriteLine("\n Tableau non trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // LANCER LE CHRONO
                        stopWatch.Start();

                        // Tri par insertion
                        programmeTableau.TriInsertion(tableau);

                        // FIN DU CHRONO
                        stopWatch.Stop();

                        // Tableau avec tri
                        Console.WriteLine("\n \n Tableau trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement : " + stopWatch.ElapsedMilliseconds + " ms");
                        break;

                    case "4":
                        programmeTableau.CreerTableau(out tableau);
                        
                        // Tableau sans tri
                        Console.WriteLine("\n Tableau non trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));
                        // LANCER LE CHRONO
                        stopWatch.Start();

                        // Tri intuitif
                        programmeTableau.TriIntuitif(tableau);

                        // FIN DU CHRONO
                        stopWatch.Stop();

                        // Tableau avec tri
                        Console.WriteLine("\n \n Tableau trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement : " + stopWatch.ElapsedMilliseconds + " ms");
                        break;

                    case "5":
                        programmeTableau.CreerTableau(out tableau);

                        // Tableau sans tri
                        Console.WriteLine("\n Tableau non trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // LANCER LE CHRONO
                        stopWatch.Start();

                        // Tri shell
                        programmeTableau.TriShell(tableau);

                        // FIN DU CHRONO
                        stopWatch.Stop();

                        // Tableau avec tri
                        Console.WriteLine("\n \n Tableau trié \n");
                        Console.Write(message = programmeTableau.AfficherTableau(tableau, out message));

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement : " + stopWatch.ElapsedMilliseconds + " ms");
                        break;

                    case "6":
                        programmeTableau.CreerTableau(out tableau);

                        int[] tableau2 = programmeTableau.CopierTableau(tableau);

                        // LANCER LE CHRONO
                        stopWatch1.Start();

                        // Tri par sélection
                        programmeTableau.TriSelection(tableau2);

                        // FIN DU CHRONO
                        stopWatch1.Stop();

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement du Tri par sélection : " + stopWatch1.ElapsedMilliseconds + " ms");
                        programmeTableau.SupprimerTableau(ref tableau2);

                        tableau2 = programmeTableau.CopierTableau(tableau);

                        // LANCER LE CHRONO
                        stopWatch2.Start();

                        // Tri à bulle
                        programmeTableau.TriBulle(tableau2);

                        // FIN DU CHRONO
                        stopWatch2.Stop();

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement du Tri à bulle : " + stopWatch2.ElapsedMilliseconds + " ms");
                        programmeTableau.SupprimerTableau(ref tableau2);

                        tableau2 = programmeTableau.CopierTableau(tableau);

                        // LANCER LE CHRONO
                        stopWatch3.Start();

                        // Tri par insertion
                        programmeTableau.TriInsertion(tableau2);

                        // FIN DU CHRONO
                        stopWatch3.Stop();

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement du Tri par insertion : " + stopWatch3.ElapsedMilliseconds + " ms");
                        programmeTableau.SupprimerTableau(ref tableau2);

                        tableau2 = programmeTableau.CopierTableau(tableau);

                        // LANCER LE CHRONO
                        stopWatch4.Start();

                        // Tri intuitif
                        programmeTableau.TriIntuitif(tableau2);

                        // FIN DU CHRONO
                        stopWatch4.Stop();

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement du Tri intuitif : " + stopWatch4.ElapsedMilliseconds + " ms");
                        programmeTableau.SupprimerTableau(ref tableau2);

                        tableau2 = programmeTableau.CopierTableau(tableau);

                        // LANCER LE CHRONO
                        stopWatch5.Start();

                        // Tri shell
                        programmeTableau.TriShell(tableau2);

                        // FIN DU CHRONO
                        stopWatch5.Stop();

                        // Temps en milisecondes
                        Console.WriteLine("\n \n Temps de traitement du Tri shell  : " + stopWatch5.ElapsedMilliseconds + " ms");
                        programmeTableau.SupprimerTableau(ref tableau2);
                        break;

                    case "Q":
                        Console.WriteLine("Programme terminé.");
                        break;

                    default:
                        Console.WriteLine("Choix non valide. Veuillez réessayer.");
                        break;
                }
                Console.Write("\n Voulez-vous recommencer? (O/N) ");
            } while (Console.ReadLine().Trim().ToUpper() == "O");
        }

        static void AfficherMenu()
        {
            Console.WriteLine("1. Tri par sélection");
            Console.WriteLine("2. Tri à bulles");
            Console.WriteLine("3. Tri par insertion");
            Console.WriteLine("4. Tri intuitif");
            Console.WriteLine("5. Tri Shell");
            Console.WriteLine("6. Comparaison");
            Console.WriteLine("Q. Quitter");
            Console.Write("Choix : ");
        }
    }
}