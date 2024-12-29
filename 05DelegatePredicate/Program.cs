Console.WriteLine("Informe um numero inteiro :");
var numero = Convert.ToInt32(Console.ReadLine());

// Predicate<int> delegatePar = VerificarPar;
/*
Predicate<int> delegatePar = delegate(int x)
{
    return x % 2 == 0;
};
*/

Predicate<int> delegatePar = x => numero % 2 == 0;

if (delegatePar(numero))
{
    Console.WriteLine($"O numero {numero} e PAR");
}
else
{
    Console.WriteLine($"O numero {numero} e IMPAR");
}

Console.ReadKey();

static bool VerificarPar(int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}