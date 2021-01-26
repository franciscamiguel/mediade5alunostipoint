using System;


namespace mediade5alunostipoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            
            int idade1 = 0;
            int idade2 = 0;
            int idade3 = 0;
            int idade4 = 0;
            int idade5 = 0;
            Console.WriteLine("programa que calcula a idade media de cinco alunos");
            Console.Write("informe a idade do 1 alunos : ");
            idade1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("informe a idade do 2 alunos : ");
            idade2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("informe a idade 3 alunos : ");
            idade3 = Convert.ToInt16(Console.ReadLine ());
            Console.Write("informe a idade do 4 alunos : ");
            idade4 = Convert.ToInt16(Console.ReadLine());
            Console.Write("informe a idade do 5 alunos : ");
            idade5 = Convert.ToInt16(Console.ReadLine());
            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine(" A idade média dos alunos é " + media);
            Console.ReadLine();


        }
    }
}
