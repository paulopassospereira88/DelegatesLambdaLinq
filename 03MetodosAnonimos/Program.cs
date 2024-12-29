List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

var resultado = nomes.Find(delegate(string nome)
{
    return nome.Equals("Maria");
});

Console.WriteLine(resultado);

Console.ReadKey();

static bool VerificaNomeNaLista(string nome)
{
    Console.WriteLine($"Consulta nome na lista : {nome}");
    return nome.Equals("Paulo");
}