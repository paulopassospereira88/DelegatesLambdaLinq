namespace _08Exercicio;

public class Pessoa
{
    public Pessoa(string? nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    private string? nome;
    private int idade;

    public string? Nome
    {
        get => nome;
        set => nome = value;
    }

    public int Idade
    {
        get => idade;
        set => idade = value;
    }
    
    
}