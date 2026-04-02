using System.Text;
namespace Chaines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc"; // syntaxe la plus commune
            string s2 = new string('*', 7); // N fois le même caractères

            char [] ar = {'e', 'f','g'};
            string s3 = new string(ar);

            Console.WriteLine(s1); // abc
            Console.WriteLine(s2); // *******
            Console.WriteLine(s3); // efg

            string s4 = "Chemin complet du fichier \"essai\": \nC:\\Temp\\essai.txt";
            Console.WriteLine(s4);

            string s5 = "Chemin complet du fichier \"essai\": \n";
                s5+= "C:\\Temp\\essai.txt";
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
            string symboles = "✎ 🗘 ✓ ⎌ ℹ ⮐ 🗙 ≠";
            string flèches = "⯅ ⯇ ⯈ ⯆";

            Console.WriteLine(symboles);
            Console.WriteLine(flèches); 

           

            string symbole2 = "\u2713 \u2B6E \u2B6F";
            Console.WriteLine(symbole2);
                

        }
    }
}
