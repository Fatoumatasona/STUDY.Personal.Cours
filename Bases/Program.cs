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
    if (age <= 25)
        tranche = "Tu as moins de 25 ans";
    else if (age >= 25 && age < 40)
        tranche = "25 - 40 ans ";
    else if (age >= 40 && age < 55)
        tranche = "40 - 55 ans ";
    else
        tranche = "plus de 55 ans ";

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
