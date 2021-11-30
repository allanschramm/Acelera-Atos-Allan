// See https://aka.ms/new-console-template for more information

/* 5) Evoluir o programa (4) para incluir na struct que define o aluno a data do cadastro, usando um tipo datetime.
 * 
 * a) A informação da data deve ser recuperada do sistema no exato momento que o cadastro esta sendo realizado.
 * b) E deve ser exibida no relatorio onde todas as informações dos alunos são exibidas.
 * 
 */

// 4) Evoluir o programa console (3) desta lista para permitir a busca dos dados de um aluno pelo nome.

using _05_Ex;

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
        string busca;

        double CalcularMedia()
        {
            double media = Aluno.totalNota / Aluno.TotalDeAlunos;

            foreach (Aluno aAluno in alunos)
            {
                if (aAluno.Nota < (media + 3) || aAluno.Nota > (media - 3))
                {
                    aAluno.Situacao = ESituacaoAluno.Recuperacao;
                }
                if (aAluno.Nota > (media + 3))
                {
                    aAluno.Situacao = ESituacaoAluno.Aprovado;
                }
                if (aAluno.Nota < (media - 3))
                {
                    aAluno.Situacao = ESituacaoAluno.Reprovado;
                }
            }
            return media;
        }

        int opcao = ChamarMenu();

        while (opcao != 5)
        {
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
                    Console.WriteLine($"\nA media da turma é: {CalcularMedia()}");
                    foreach (Aluno aAluno in alunos)
                    {
                        aAluno.Imp();
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    opcao = ChamarMenu();
                    break;

                case 4:
                    Console.WriteLine($"\nPesquisar Aluno");
                    busca = Console.ReadLine();
                    foreach (Aluno aAluno in alunos)
                    {
                        if (aAluno.Nome.Contains(busca))
                        {
                            aAluno.Imp();
                        }
                        else
                        {
                        }
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    opcao = ChamarMenu();
                    break;

                case 5:
                    Console.WriteLine($"\nSair");
                    break;

                default:
                    Console.WriteLine("Opção invalida!");
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadLine();
                    opcao = ChamarMenu();
                    break;

            }

        }
    }
}