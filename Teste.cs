using System;

class Teste
{
    static void Main(string[] args)
    {
        string nome = "Aluna: Livs Vilela ";
        Console.WriteLine(nome);
        Console.WriteLine("Você quer saber um segredo?\n 1) Sim \n 2) Não");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao!=1 || opcao!=2) 
        {
            Console.WriteLine("Bobinho(a)... Essa opção não existe.");
        }
        else if (opcao == 1)
        {
            Console.WriteLine("DS é o melhor curso");
        }
        else
        {
            Console.WriteLine("Nossa... que grosseria.");
            string nome2 = "Aluna: Mafes ";
            Console.WriteLine(nome2);
            Console.WriteLine("Lívia mas e a projete? ");
        }

    }
}