Console.WriteLine("Digite um numero : ");
var numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrado = Math.Sqrt;

var resultado = raizQuadrado(numero);

Console.WriteLine("\nA raiz quadrada de " +numero+ " e : "  +resultado);