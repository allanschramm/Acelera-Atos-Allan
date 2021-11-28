// See https://aka.ms/new-console-template for more information



/* 4) Evoluir o programa console (3) desta lista para permitir a busca dos dados de um aluno pelo nome.
 * 4.1) Construir um menu para acionar as funcioalidades do programa. (Lembre - se de utilizar metodos para segmentar as responsabilidades do programa)
 * Que seriam:
 * a) Cadastrar um aluno
 * b) Listar todos alunos
 * c) Calcular a media e atualizar situação dos alunos
 * d) Pesquisar aluno pelo nome
 * e) Sair do programa
 */

enum ESituacaoAluno
{
    NaoAvaliado,
	Aprovado,
	Reprovado,
	Recuperacao
}

// 3.2) A entrada dos dados deve ser um metodo da struct. 

struct Aluno
{
    //Propriedades
    public string Nome;
    public double Nota;
    public ESituacaoAluno Situacao;
    public DateTime DataRegistro;

    public Aluno (string Nome, ESituacaoAluno Situacao, double Nota, DateTime DataRegistro)
    {
        this.Nome = Nome;
        this.Situacao = Situacao;
        this.Nota = Nota;
        this.DataRegistro = DateTime.Now;
    }

    //Metodos
    public void Imp()
    {
        Console.WriteLine($"Nome = {Nome} Nota = {Nota} Situação = {Situacao} Registro = {DataRegistro}");
    }


}



internal class Program
{
    const int NUM_ALUNOS = 3;
    static Aluno[] arrAluno = new Aluno[NUM_ALUNOS];

    static void Main(string[] args)
    {
        // 3.3) O programa deve receber a entrada de informações de 10 alunos

        double somaNota = 0, mediaTurma;

        Console.WriteLine("\nSistema de Calculo de Media dos Alunos, você precisará digitar o nome e a nota de 10 alunos:\n");

        for (int i = 0; i < arrAluno.Length; i++)
        {
            Console.WriteLine("\nDigite o nome do aluno: ");
            arrAluno[i].Nome = Console.ReadLine();
            Console.WriteLine("\nDigite a nota do aluno: ");
            arrAluno[i].Nota = double.Parse(Console.ReadLine());

            somaNota += arrAluno[i].Nota;
        }

        mediaTurma = somaNota / arrAluno.Length;

        // 3.4) Uma listagem contendo todos os dados de todos os alunos.

        for (int i = 0; i < arrAluno.Length; i++)
        {
            arrAluno[i].Imp();
        }

        // 3.5) A maior e a menor nota, e a média aritmetica das notas dos alunos. 

        Console.WriteLine($"\nA soma das notas dos alunos é: {somaNota}");
        Console.WriteLine($"\nA média dos alunos é: {mediaTurma}");

        // 3.6) Uma ultima listagem deve ser exibida onde os alunos serão exibidos juntamente com seu status que será calculado da seguinte forma:
        // a) Nota do aluno 3 pontos acima ou abaixo da media da turma ele é considerado em recuperação
        // b) Nota acima da média da turma+3 pontos aprovado
        // c) Nota abaixo da média da turma-3 pontos reprovado

        Console.WriteLine("\nSituação dos alunos da turma: \n");

        for (int i = 0; i < arrAluno.Length; i++)
        {
            if (arrAluno[i].Nota < (mediaTurma + 3) || arrAluno[i].Nota > (mediaTurma - 3))
            {
                arrAluno[i].Situacao = ESituacaoAluno.Recuperacao;
            }
            if (arrAluno[i].Nota > (mediaTurma + 3))
            {
                arrAluno[i].Situacao = ESituacaoAluno.Aprovado;
            }
            if (arrAluno[i].Nota < (mediaTurma - 3))
            {
                arrAluno[i].Situacao = ESituacaoAluno.Reprovado;
            }

            arrAluno[i].Imp();
        }
    }
}