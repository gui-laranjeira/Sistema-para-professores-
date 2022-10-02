namespace Sistema_para_escolas.Model;

public class Aluno : Pessoa
{
    public decimal nota1;
    public decimal nota2;
    private decimal media;
    public decimal somaNota = 0;
    public int numeroAluno = 0;
    

    public Aluno(string nome, string sobrenome) : base(nome, sobrenome)
    {
    }

    public decimal Nota1
    {
        get => nota1;
        set
        {
            nota1 = value;
        }
    }
    
    public decimal Nota2
    { 
        get => nota2;
        set
        {
            nota2 = value;
        }
    }

    public decimal MediaAluno()
    {
        somaNota = nota1 + nota2;
        media = somaNota / 2;
        return media;
    }

    public void InserirNotas(decimal nota1, decimal nota2)
    {
        this.Nota1 = nota1;
        this.Nota2 = nota2;
    }
}