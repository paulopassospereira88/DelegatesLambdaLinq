Console.WriteLine("Informe um numero inteiro");
var numero = Convert.ToInt32(Console.ReadLine());

Action<int> dobra = x => Console.WriteLine(x * 2);
dobra(numero);
Duplicar(numero);

Console.ReadKey();

static void Duplicar(int numero)
{
    int resultado = numero * 2;
    Console.WriteLine(resultado);
}