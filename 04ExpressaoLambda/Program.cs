List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

var resultado = nomes.Find(nome => nome.Equals("Maria"));

Console.WriteLine(resultado);

Console.ReadKey();