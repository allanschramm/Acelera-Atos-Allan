using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex
{

    /*
     * 
     * 5) Evoluir o programa (4) para incluir na struct que define o aluno a data do cadastro, usando um tipo datetime.
     * 
     * a) A informação da data deve ser recuperada do sistema no exato momento que o cadastro esta sendo realizado.
     * b) E deve ser exibida no relatorio onde todas as informações dos alunos são exibidas.
     * 
     */

    internal class Aluno
    {
        //Propriedades
        public string Nome;
        public double Nota;
        public ESituacaoAluno Situacao;
        public DateTime DataRegistro;
        public double mediaNota { get; set; }
        public static double totalNota { get; private set; }
        public static int TotalDeAlunos { get; private set; }

        public Aluno()
        {
            Console.WriteLine("Digite um nome");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a nota");
            Nota = int.Parse(Console.ReadLine());

            DataRegistro = DateTime.Now;

            totalNota += Nota;
            TotalDeAlunos++;
        }
        
        //Metodos
        public void Imp()
        {
            Console.WriteLine($"Nome = {Nome} Nota = {Nota} Situação = {Situacao} Registro = {DataRegistro}");
        }
    }
}
