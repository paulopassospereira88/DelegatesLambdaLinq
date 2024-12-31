List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Paulo"
};

Console.WriteLine("Sintaxe de consulta");
var resultado1 = from m in nomes where m.Contains('o') select m;
ExibirResultado(resultado1);

Console.WriteLine("Sintaxe de metodo");
var resultado2 = nomes.Where(m => m.Contains('o')).ToList();
ExibirResultado(resultado2);

static void ExibirResultado(IEnumerable<string> enumerable)
{
    foreach (var item in enumerable)
    {
        Console.WriteLine(item);
    }
}