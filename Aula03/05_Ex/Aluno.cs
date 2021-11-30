using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ex
{
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
