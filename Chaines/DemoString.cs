using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Chaines
{
    internal class DemoString
    {
        public static void construireChaines()
        {
            string s1 = "abc"; // syntaxe la plus commune
            string s2 = new string('*', 7); // N fois le même caractères

            char[] ar = { 'e', 'f', 'g' };
            string s3 = new string(ar);

            Console.WriteLine(s1); // abc
            Console.WriteLine(s2); // *******
            Console.WriteLine(s3); // efg

            string s4 = "Chemin complet du fichier \"essai\": \nC:\\Temp\\essai.txt";
            Console.WriteLine(s4);

            string s5 = "Chemin complet du fichier \"essai\": \n";
            s5 += "C:\\Temp\\essai.txt";
            Console.WriteLine(s5);

            // Chaînes Verbatim
            string texte = @"Dans une chaîne verbatim :
- les retours à la ligne sont bien interprétés 
- pas besoin d'échapper les caractères spéciaux (ex : C\Temp\essai.txt)
- mais il faut ""doubler"" les guillemets";

            Console.WriteLine(texte);

            // Litteraux de chaînes bruts
            string texte2 = """
                 Dans un litteral de chaîne brut :
                 - pas besoin d'échapper les caractères spéciaux, y compris les "guillemets"
                 - on peut indenter la chaîne comme le reste du code
                
                """;

            Console.WriteLine(texte2);
            /**
             * Pour que la console affiche correctement les caractères UnicodeUTF16, il faut affecter sa propriété 
             * OutputEncoding avec une valeur adéquate. C'est ce qui est fait sur la première ligne.
             */
            Console.OutputEncoding = new UnicodeEncoding();

            /*
             * Les symboles unicode sont un moyen simple d'ajouter des icônes dans une application!
             */

            // Caractères ASCII et Unicode
            string symboles = "✎ 🗘 ✓ ⎌ ℹ ⮐ 🗙 ≠ 🖫 🖉 🗑 ✓ 🛈 🗙 ⭮ ⭯";
            string flèches = "⯅ ⯇ ⯈ ⯆";

            Console.WriteLine(symboles);
            Console.WriteLine(flèches);

            string symbole2 = "\u2713 \u2B6E \u2B6F";
            Console.WriteLine(symbole2);
        }

        // Indexeur (accès aux caractères de la chaîne par leurs indices)
        public static void TesterIndexeur()
        {
            string mot = "abracadabra";
            int cpt = 0;
            for (int c = 0; c < mot.Length; c++)
            {
                if (mot[c] == 'a') cpt++;
            }
            Console.WriteLine($"Il y a {cpt} 'a' dans {mot}"); // Il y a 5 'a' dans abracadabra
        }

        // Méthodes statiques
        public static void TesterMéthodesStatiques()
        {
            string s1 = "Un texte";
            string s2 = "découpé en plusieurs morceaux";
            string s3 = "pour la démo";

            // Concaténation
            string res1 = string.Concat(s1, " ", s2, "\n", s3, " !");
            Console.WriteLine($"Concat :\n{res1}\n");

            // Assemblage en utilisant un séparateur donné
            string res2 = string.Join('\n', s1, s2, s3);
            Console.WriteLine($"Join :\n{res2}\n");

            // Assemblage via une chaîne de format et des jetons
            string res3 = string.Format("Le {0:dd MMMM} est le {1}ème jour de l'année", DateTime.Today, DateTime.Today.DayOfYear);
            Console.WriteLine($"Format :\n{res3}\n");

            // Séparation d'une chaîne en 

            // Vérifier si une chaîne est null, vide ou constituée d'espaces blancs
            Console.WriteLine();
            string? rep;
            do
            {
                Console.WriteLine("Saisissez votre nom :");
                rep = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(rep));
            Console.WriteLine($"Bonjour {rep} !");
        }

        // Méthodes d'instances
        public static void TesterMéthodesInstances()
        {
            string s = "Chaîne de caractères";

            Console.WriteLine(s.Contains("car"));  // True
            Console.WriteLine(s.StartsWith("Ch")); // True
            Console.WriteLine(s.EndsWith("es"));   // True
            Console.WriteLine(s.IndexOf('h'));     // 1
            Console.WriteLine(s.LastIndexOf('c')); // 14
            Console.WriteLine(s.Substring(4, 2));  // ne
            Console.WriteLine(s.Replace(' ', '\n'));  // espaces remplacés par des retours à la ligne
            Console.WriteLine(s.ToLower());  // chaîne de caractères
            Console.WriteLine(s.ToUpper());  // CHAÎNE DE CARACTÈRES

            // Séparation d'une chaîne en plusieurs éléments et stockage dans un tableau
            string phrase = "J'aime le C#";
            string[] mots = phrase.Split('\'', ' ');

            foreach (string mot in mots)
            {
                Console.WriteLine(mot);
            }
        }
    }
}
