using System.Security.Cryptography.X509Certificates;

namespace libreria
{
    internal class Program
    {
        static void Main(string[] args)

        {
            {

                static int funzione(string testo)
                {
                    string[] vocali = { "a", "e", "i", "o", "u" };
                    int valore = 0;
                    for (int i = 0; i < vocali.Length; i++)
                    {
                        if (testo.Contains(vocali[i]))
                            valore  += 1;

                    }
                    return valore;
                }
                Console.WriteLine("inserisci una parola");
                string parola = Console.ReadLine();
                int valotefunzione = funzione(parola);
                Console.WriteLine(valotefunzione);


            }
            //Aggiungere un libro: L'utente può aggiungere un libro fornendo le informazioni necessarie (titolo, autore, ISBN, anno).
            // Rimuovere un libro: L'utente può rimuovere un libro tramite il suo ISBN.
            //Cercare un libro: L'utente può cercare un libro per titolo o autore.
            //Visualizzare tutti i libri: L'utente può visualizzare l'elenco completo dei libri presenti nella libreria.
            Console.WriteLine("aggiunggi il libto ");
            Console.Write("titolo : ");
            string titolo = Console.ReadLine();

            Console.Write("Nome autore :");
            string nome = Console.ReadLine();

            Console.Write("Cognome autore :");
            string cognome = Console.ReadLine();
            Autore autore = new Autore(nome,cognome);


            Console.Write("ISBN :");
            string isbn = Console.ReadLine();

            Console.Write("Data di rilascio  (yyyy-mm-dd): ");
            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.Write("Formato non valido. Inserisci la data nel formato yyyy-mm-dd: ");
            }

            Libro libro = new Libro (titolo, autore , isbn ,data);
            Console.WriteLine($"nuovo libro aggiunto {libro}");


        }
    }
}
