Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

class Pedido
{
    public event EventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado !!!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}

class Email
{
    public static void Enviar(object? sender, EventArgs args)
    {
        Console.WriteLine("Enviando e-mail");
    }
}

class SMS
{
    public static void Enviar(object? sender, EventArgs args)
    {
        Console.WriteLine("Enviando SMS");
    }
}