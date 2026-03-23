namespace Fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbMots = OutilsTexte.CompterMots("j'aime le C#");

            //double[] tabNombres = { 4.21, 5.54, 2.13, 3.47 };
            double max1 = OutilsMaths.GetValeurMaxi(4.21, 5.54, 2.13, 3.47, 4.58, 69);
            Console.WriteLine("Valeur maxi : " + max1);

            string traduction = OutilsTexte.Traduire("J'aime le C#");

        }
    }
}
