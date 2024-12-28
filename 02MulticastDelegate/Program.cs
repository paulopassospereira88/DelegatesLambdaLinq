MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

delegateMulticast("Ola multicast delegate!");

delegateMulticast -= Metodo3;
delegateMulticast("Metodo 3 removido");

Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine("Metodo 1: " +mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Metodo 2: " +mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Metodo 3: " +mensagem);
}

public delegate void MeuDelegate(string mensagem);