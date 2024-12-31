Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("paulo@paulo.com.br", 789456123);

Console.ReadKey();

class PedidoEventArgs : EventArgs
{
    public string Email { get; set; }
    public int Telefone { get; set; }
}

class Pedido
{
    public event EventHandler<PedidoEventArgs> OnCriarPedido;

    public void CriarPedido(string email, int fone)
    {
        Console.WriteLine("Pedido criado !!!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs {Email = email, Telefone = fone });
        }
    }
}

class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando e-mail {e.Email}");
    }
}

class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando SMS {e.Telefone}");
    }
}