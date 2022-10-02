namespace Sistema_para_escolas.Model;

public class Pessoa
{
    //TO DO deixar os critérios de entrada mais seguros
    
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    
    public string NomeCompleto
    {
        get => $"{Nome} {Sobrenome}";
    }
    
    public Pessoa(){}

    public Pessoa(string nome, string sobrenome)
    {
        this.Nome = nome;
        this.Sobrenome = sobrenome;
    }
    
}