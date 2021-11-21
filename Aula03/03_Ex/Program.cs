// See https://aka.ms/new-console-template for more information

/* 
 * 3) Construa um programa console para receber o cadastro de alunos (Utilizando uma Struct), como nome, idade, nota e situação (aprovado,reprovado, recuperação),
 */


// 3.1) Um enum deve ser utilizado para representar a situação do aluno.

enum ESituacaoAluno
{
	Aprovado = 1,
	Reprovado = 2,
	Recuperacao = 3
}

// 3.2) A entrada dos dados deve ser um metodo da struct. 

struct Aluno
{
    //Propriedades
    public string Nome;
    public int Situacao;
    public double Nota;

    public Aluno (string Nome, int Situacao, double Nota)
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

// 3.3) O programa deve receber a entrada de informações de 10 alunos, e ao termino imprimir na saida do console:
// 3.4) Uma listagem contendo todos os dados de todos os alunos.
// 3.5) A maior e a menor nota, e a média aritmetica das notas dos alunos. 
// 3.6) Uma ultima listagem deve ser exibida onde os alunos serão exibidos juntamente com seu status que será calculado da seguinte forma:
// a) Nota do aluno 3 pontos acima ou abaixo da media da turma ele é considerado em recuperação
// b) Nota acima da média da turma+3 pontos aprovado
// c) Nota abaixo da média da turma-3 pontos reprovado

internal class Program
{
    static void Main(string[] args)
    {
        Aluno alu = new Aluno();
        alu.Nome = "Ryu";
        alu.Nota = 10;

        Aluno alu2 = new Aluno();
        alu2.Nome = "Ken";
        alu2.Nota = 6;

        Aluno alu3 = new Aluno();
        alu3.Nome = "Blanka";
        alu3.Nota = 2;


        List<Aluno> alunos = new List<Aluno>();
        alunos.Add(alu);

        foreach (var aluno in alunos)
        {
            aluno.Imp();
        }
    }
}


