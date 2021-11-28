// See https://aka.ms/new-console-template for more information



// 4) Evoluir o programa console (3) desta lista para permitir a busca dos dados de um aluno pelo nome.

using _04_Ex;

enum ESituacaoAluno
{
    NaoAvaliado,
	Aprovado,
	Reprovado,
	Recuperacao
}

// 3.2) A entrada dos dados deve ser um metodo da struct. 

internal class Program
{
    static int ChamarMenu()
    {
        Console.Clear();
        Console.WriteLine("Sistema de gerenciamento de Alunos!");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Para Cadastrar um Aluno");
        Console.WriteLine("2 - Para Cadastrar listar todos alunos");
        Console.WriteLine("3 - Para Calcular a média e atualizar situação dos alunos");
        Console.WriteLine("4 - Pesquisar aluno pelo nome");
        Console.WriteLine("5 - Para sair do programa");
 
        return int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        /*
        * 4.1) Construir um menu para acionar as funcioalidades do programa. (Lembre - se de utilizar metodos para segmentar as responsabilidades do programa)
        * Que seriam:
        * a) Cadastrar um aluno
        * b) Listar todos alunos
        * c) Calcular a media e atualizar situação dos alunos
        * d) Pesquisar aluno pelo nome
        * e) Sair do programa
        */

        List<Aluno> alunos = new List<Aluno>();

        int opcao = ChamarMenu();

        while(opcao != 5){
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"\nCadastrar Aluno");
                    alunos.Add(new Aluno());
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    opcao = ChamarMenu();
                    break;

                case 2:
                    Console.WriteLine($"\nListar Alunos");
                    foreach (Aluno aAluno in alunos)
                    {
                        aAluno.Imp();
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    opcao = ChamarMenu();
                    break;

                case 3:
                    Console.WriteLine($"\nCalcular Media");
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    ChamarMenu();
                    break;

                case 4:
                    Console.WriteLine($"\nPesquisar Aluno");
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    ChamarMenu();
                    break;

                case 5:
                    Console.WriteLine($"\nSair");
                    break;

                default:
                    Console.WriteLine("Opção invalida!");
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    ChamarMenu();
                    break;

                
                
            }

        }
    }
}