namespace _08Exercicio;

public class Service
{
    public static List<Pessoa> GetPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa("Paulo", 35),
            new Pessoa("Jose", 30),
            new Pessoa("Maria", 25),
            new Pessoa("Pedro", 15),
            new Pessoa("Lucas", 55),
        };
        return pessoas;
    }
}