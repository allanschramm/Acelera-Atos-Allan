// See https://aka.ms/new-console-template for more information

/* 
 * 3) Construa um programa console para receber o cadastro de alunos (Utilizando uma Struct), como nome, idade, nota e situação (aprovado,reprovado, recuperação),
 */


// 3.1) Um enum deve ser utilizado para representar a situação do aluno.

enum ESituacaoAluno
{
	Aprovado,
	Reprovado,
	Recuperacao
}

// 3.2) A entrada dos dados deve ser um metodo da struct. 

struct Aluno
{
    //Propriedades
    public string Nome;
    public ESituacaoAluno Situacao;
    public double Nota;

    public Aluno (string Nome, ESituacaoAluno Situacao, double Nota)
    {
        this.Nome = Nome;
        this.Situacao = Situacao;
        this.Nota = Nota;
    }

    //Metodos
    public void Imp()
    {
        Console.WriteLine($"Nome = {Nome} Nota = {Nota} Situação = {Situacao}");
    }
}



internal class Program
{
    static void Main(string[] args)
    {
        // 3.3) O programa deve receber a entrada de informações de 10 alunos

        Aluno[] arrAluno = new Aluno[10];
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
            Console.WriteLine($"Nome: {arrAluno[i].Nome} | Nota: {arrAluno[i].Nota}");
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

            Console.WriteLine($"Aluno: {arrAluno[i].Nome} | Situação: {arrAluno[i].Situacao}");
        }
    }
}


