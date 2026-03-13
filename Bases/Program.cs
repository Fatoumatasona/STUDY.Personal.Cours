Console.WriteLine("Bonjour ! Comment t'appeles-tu ?");
string? rep = Console.ReadLine();

Console.WriteLine("Bonjour " + rep + " !");

Console.WriteLine("Quelle est ton année de naissance ?");
rep = Console.ReadLine();

int annéeNais = int.Parse(rep);

const int annéeMin = 1900;

if (annéeNais >= annéeMin && annéeNais <= DateTime.Today.Year)
{

    int age = DateTime.Today.Year - annéeNais;
    Console.WriteLine($"Tu as ou vas avoir {age} ans en {DateTime.Today.Year}");

    string tranche = string.Empty;

    /*
    if (age <= 25)
        tranche = "Tu as moins de 25 ans";
    else if (age >= 25 && age < 40)
        tranche = "25 - 40 ans ";
    else if (age >= 40 && age < 55)
        tranche = "40 - 55 ans ";
    else
        tranche = "plus de 55 ans ";*/

    switch (age)
    {
        case < 25:
            tranche = "moins de 25 ans";
            break;

        case < 40:
            tranche = "25 - 40 ans";
            break;

        case < 55:
            tranche = "40 - 55 ans";
            break;

        default:
            tranche = "plus de 55 ans";
            break;
    }

    Console.WriteLine($"Ta tranche d'âge est : {tranche}");
}
else
{
    Console.WriteLine($"Ton année de naissance doit être comprise entre {annéeMin} et {DateTime.Today.Year}");
}

Console.WriteLine("As tu un code de reduction (O/N)");
rep = Console.ReadLine();

bool reduc = (rep == "O");

Console.WriteLine(annéeNais < 2000 ? "Tu es né au 20ème siècle" : "Tu es née au 21 ème siècle");


/** 
 * Astuces visual studio
 * 
 * Intellisense est un système d'aide à la saisie de code que possède visual studio.
 * Depuis 2022, visual studio a embarqué une IA qui vient complèter intellisense classique pour complèter des 
 * lignes de commandes et des blocs de codes entiers.
 * Mais cette IA consomme cependant pas de ressources (et donc la batterie si tu as un ordi portable), 
 * et le code proposé n'est pas toujours pertinent
 * 
 * Réindenter du code avec ctrl + K+ D
 * 
 * Déplacement de code avec ALT + flèche haut ou bas
 * 
 * Insérer un extrait de code 
 * Visual studio propose un certain nombre de raccourci appélé snippets en anglais comme cw suivi de 2 tabulations
 */