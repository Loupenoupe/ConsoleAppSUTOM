namespace ConsoleAppSUTOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trouvez le mot mystère");
            string[] tableauMots = {"ANANAS", "BANANE", "CAHIER", "DESSIN", "ETOILE", "FLAMME", "GARAGE", "JARDIN", "MAISON", "SOLEIL",
                                    "ABEILLE", "BATEAUX", "CAMIONS", "DAUPHIN", "FENETRE",
                                    "GUITARE", "JOURNAL", "LUMIERE", "OISEAUX", "VOITURE",
                                    "ARAIGNEE", "CHOCOLAT", "ESCALIER", "FROMAGES", "IMMEUBLE",
                                    "MONTAGNE", "PANTALON", "SANDWICH", "TABOURET", "VOYAGEUR",
                                    "AVENTURES", "CROCODILE", "DINOSAURE", "ELEPHANTS", "PARAPLUIE",
                                    "TELEPHONE", "CROISSANT", "CHAUSSURE", "CHAMPIONS", "PAPILLONS"};

            Random random = new Random();
            string motMystere = tableauMots[random.Next(tableauMots.Length)];
            Char[] motsDeviner = motMystere.ToUpper().ToCharArray();

            for (int i = 0; i < motsDeviner.Length; i++)
            {
                Console.Write($"{i+1} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"{motsDeviner[0]}");
            for (int i = 0; i < 6; i++)
            {
                string reponse = Console.ReadLine();
                Char[] guess = reponse.ToUpper().ToCharArray();

                if (guess.Length != motsDeviner.Length)
                {
                    Console.WriteLine("Pas le même nombre de lettres que le mot mystère !");
                }
                else
                {
                    if (guess.SequenceEqual(motsDeviner))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{motMystere}");
                        Console.WriteLine("Félicitations ! Vous avez trouvé le mot mystère !");
                        Console.ResetColor();
                        Environment.Exit(0);
                    }
                    else
                    {

                        for (int z = 0; z < motsDeviner.Length; z++)
                        {
                            if (guess[z] == motsDeviner[z])
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{guess[z]}");
                                Console.ResetColor();
                            }
                            else if (motsDeviner.Contains(guess[z]) && motsDeviner[z] != guess[z])
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write($"{guess[z]}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"{guess[z]}");
                                Console.ResetColor();
                            }
                        }
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine($"Vous avez perdu :( !\nLe mot mystère était : {motMystere}");
        }
    }
}
