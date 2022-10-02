namespace Sistema_para_escolas.Model;

public class Sala : Pessoa
{
    public List<Aluno> alunos = new List<Aluno>();
    private decimal somaNotasAlunos;
    private decimal mediaSala;

    //Um método de adicionar para o sistema, por isso sem feedback para o usuário
    public void AddAlunoSistema(Aluno a)
    {
        alunos.Add(a);
        a.numeroAluno = alunos.IndexOf(a) + 1;
    }
    
    //Um método de adicionar com feedback para o usuário
    public void AdicinarAluno()
    {
        Aluno novo = CriarAluno();
        alunos.Add(novo);
        Console.WriteLine($"\n \n Aluno {novo.NomeCompleto} adicionado!\n ");
        
        //dar um número para cada aluno de acordo com a posição na lista
        novo.numeroAluno = alunos.IndexOf(novo) + 1;
    }

    //n vai precisar
    public int TamanhoSala()
    {
        int tamanho = alunos.Count();
        return tamanho;
    }
    
    public Aluno CriarAluno()
    {
        Console.WriteLine("Insira o nome do aluno: \n");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira o sobrenome do aluno: \n");
        string sobrenome = Console.ReadLine();
        Aluno x = new Aluno(nome, sobrenome);
        return x;
    }

    public void ListarSala()
    {
        Console.Clear();
        Console.WriteLine("\n \nAlunos na sala: ");
        foreach (Aluno a in alunos)
        {
            Console.WriteLine($"{a.numeroAluno} - {a.NomeCompleto}");
        }
        Console.WriteLine();
    }

    public void RemoverAluno(string nomeAlunoRemover)
    {
        List<string> temporaria = new List<string>();
        foreach (Aluno x in alunos)
        {
            temporaria.Add(x.NomeCompleto);
        }
        if (temporaria.Contains(nomeAlunoRemover))
        {
            int indexAlunoRemover = temporaria.IndexOf(nomeAlunoRemover);

            alunos.RemoveAt(indexAlunoRemover);
            Console.WriteLine($"\n \nAluno {nomeAlunoRemover} removido!\n");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado na sala. Tente novamente.");
        }
    }
    

    public void InserirNotasSala()
    {
        foreach (Aluno a in alunos)
        {
            Console.WriteLine($"\nInsira a primeira nota de {a.NomeCompleto}");
            string primeiraNota = Console.ReadLine();
            Console.WriteLine($"\nInsira a segunda nota de {a.NomeCompleto}");
            string segundaNota = Console.ReadLine();
            bool convert1 = decimal.TryParse(primeiraNota, out decimal nota1);
            bool convert2 = decimal.TryParse(segundaNota, out decimal nota2);
            if (convert1 && convert2 && nota1 <= 10 && nota2 <= 10)
            {
                a.InserirNotas(nota1, nota2);
            }
            else
            {
                Console.WriteLine("Insira notas válidas!");
            }
            
        }
        Console.WriteLine("\n \nNotas atualizadas para todos os alunos!\n");
    }

    public void TodasNotasSala()
    {
        foreach (Aluno a in alunos)
        {
            Console.WriteLine($"\n{a.NomeCompleto}. Nota 1: {a.Nota1}. Nota 2: {a.Nota2}. Média: {a.MediaAluno()}");
        }
        Console.WriteLine();
    }
    public decimal MediaSala()
    {
        foreach (Aluno a in alunos)
        {
            somaNotasAlunos += a.MediaAluno();
            mediaSala = somaNotasAlunos / alunos.Count();
        }
        return mediaSala;
    }
}