Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

delegate void PedidoEventHandler();

class Pedido
{
    public event PedidoEventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado !!!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class Email
{
    public static void Enviar()
    {
        Console.WriteLine("Enviando e-mail");
    }
}

class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("Enviando SMS");
    }
}