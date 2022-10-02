namespace Sistema_para_escolas.Model;

public class Professor : Pessoa
{
    private string usuario;
    private string senha;
    private int ID;

    public Professor (string nome, string sobrenome, string usuario, string senha):base(nome, sobrenome)
    {
        this.usuario = usuario;
        this.senha = senha;
    }

    public bool Login()
    {
        Console.WriteLine("Entre seu usuário: ");
        string usuario = Console.ReadLine();
        Console.WriteLine("Entre sua senha: ");
        string senha = Console.ReadLine();
        if (this.usuario == usuario && this.senha == senha)
        {
            Console.Clear();
            Console.WriteLine("\n \nLogin realizado!\n \n");
            return true;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\n \nUsuário ou senha incorreto!");
            return false;
        }
    }
    public void RedefinirSenha()
    {
        Console.WriteLine("Insira seu nome de usuário: ");
        string input = Console.ReadLine();
        if (usuario == input)
        {
            Console.WriteLine("\nDigite sua nova senha: ");
            string novaSenha = Console.ReadLine();
            this.senha = novaSenha;
            Console.Clear();
            Console.WriteLine("\n \nSenha alterada com sucesso! \n \n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\n \nUsuário incorreto. Não podemos confirar sua identidade, contate o setor de TI\n \n");
        }
    }
}