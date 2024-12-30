
using _08Exercicio;

var listaDePessoas = Service.GetPessoas();

Console.WriteLine("1 - Imprimir o nome/idade de cada pessoa usando um delegate Action<Pessoa>");

Action<Pessoa> imprimirPessoa = (pessoa) => Console.WriteLine(pessoa.Nome + " - " + pessoa.Idade);
listaDePessoas.ForEach(imprimirPessoa);

Console.WriteLine("2 - Filtra pessoas maiores de 30 anos usando delegate Predicate<Pessoa>");

Predicate<Pessoa> filtrarPorIdade = pessoa => pessoa.Idade >= 30;
var resultFilter = listaDePessoas.FindAll(filtrarPorIdade);
resultFilter.ForEach(imprimirPessoa); 

Console.WriteLine("3- Obtem nome/idade da pessoa mais velha utilizando delegate Func<Pessoa>");

Func<Pessoa, int> pessoasVelhas = (pessoa) => pessoa.Idade;
var idadeMax = listaDePessoas.Max(pessoasVelhas);
var pessoaMaisVelha = listaDePessoas.Find(pessoa => pessoa.Idade == idadeMax);
Console.WriteLine($"A pessoa mais velha e : {pessoaMaisVelha.Nome} idade: {idadeMax}");