
using _01Delegates;

DelegateCalculadora calc1 = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = calc1.Invoke(20, 30);
Console.WriteLine($"Somar {resultado1}");

DelegateCalculadora calc2 = Calculadora.Somar;
var resultado2 = calc1.Invoke(20, 40);
Console.WriteLine($"Somar {resultado2}");

DelegateCalculadora calc3 = (float x, float y) => Calculadora.Dividir(x, y);
var resultado3 = calc3.Invoke(40, 2);
Console.WriteLine($"Dividir {resultado3}");

Console.ReadKey();

public delegate float DelegateCalculadora(float x, float y);