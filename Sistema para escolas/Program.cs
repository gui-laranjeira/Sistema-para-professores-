using Sistema_para_escolas.Model;

Professor prof = new Professor("Manuel", "Alvez", "admin", "admin");

Sala sala1 = new Sala();

Aluno a0 = new Aluno("Guilherme", "Perez");
Aluno a1 = new Aluno("Andre", "Sevilha");
Aluno a2 = new Aluno("Matheus", "Gonçalves");
Aluno a3 = new Aluno("Matheus", "Damião");
Aluno a4 = new Aluno("Victoria", "Olodum");
Aluno a5 = new Aluno("Miguel", "Soares");
Aluno a6 = new Aluno("Carlos", "Gomes");
Aluno a7 = new Aluno("Jorge", "da Silva");
Aluno a8 = new Aluno("Milenna", "Souza");
Aluno a9 = new Aluno("Gabriela", "Lima");

sala1.AddAlunoSistema(a0); sala1.AddAlunoSistema(a1); sala1.AddAlunoSistema(a2);
sala1.AddAlunoSistema(a3); sala1.AddAlunoSistema(a4); sala1.AddAlunoSistema(a5);
sala1.AddAlunoSistema(a6); sala1.AddAlunoSistema(a7); sala1.AddAlunoSistema(a8);
sala1.AddAlunoSistema(a9);

int validador = 0;

while (validador != 9)
{
    Console.WriteLine("\nBem vindo(a) ao sistema do professor!\n \n");
    Console.WriteLine("Escolha uma opção: \n1 - Fazer login.\n2 - Alterar a senha.\n9 - Encerrar");
    string inputUsuario = Console.ReadLine();
    bool convert = int.TryParse(inputUsuario, out validador);

    if (convert)
    {
        if (validador == 1)
        {
            Console.Clear();
            Console.WriteLine("Fazer login: ");
            if (prof.Login())
            {

                int validador1 = 0;
                
                while (validador1 != 9)
                {
                    Console.WriteLine("O que deseja fazer?\n");
                    Console.WriteLine("Digite 1 - Ver os alunos da sala\nDigite 2 - Adicionar um aluno na sala\n" +
                                      "Digite 3 - Remover um aluno da sala\nDigite 4 - Inserir notas\nDigite 5 - Ver as " +
                                      "notas de todos os alunos\nDigite 6 - Ver a média da sala\nDigite 9 - Encerrar");

                    string inputUsuario1 = Console.ReadLine();
                    bool convert1 = int.TryParse(inputUsuario1, out validador1);
                    
                    if (convert1 && validador1 >= 1 && validador1 <= 6)
                    {
                        switch (validador1)
                        {
                            case 1:
                                sala1.ListarSala();
                                break;
                        
                            case 2:
                                sala1.AdicinarAluno();
                                break;
                        
                            case 3:
                                Console.WriteLine("Digite o nome completo do aluno que quer remover: ");
                                string alunoRemover = Console.ReadLine();
                                sala1.RemoverAluno(alunoRemover);
                                break;
                        
                            case 4:
                                sala1.InserirNotasSala();
                                break;
                        
                            case 5:
                                sala1.TodasNotasSala();
                                break;

                            case 6:
                                Console.WriteLine($"\n \n A média da sala é: {sala1.MediaSala()}\n");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Digite um número válido!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Tente novamente!\n \n");
            }
        }
        if (validador == 2)
        {
            prof.RedefinirSenha();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Por favor, insira uma opção válida!");
    }
}







