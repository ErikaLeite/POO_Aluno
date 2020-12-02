using System;
using POO_Aluno.classes;//quando uma página de atributos e métodos estiverem em pastas diferentes, é necessário chamá-la no programa principal

namespace POO_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();//sintaxe de link entre atributos e objetos
            

            //CADASTRO
            System.Console.WriteLine("CADASTRO DE ALUNO");
            System.Console.WriteLine("\nNOME COMPLETO:");
            aluno.nome = Console.ReadLine();

            System.Console.WriteLine("\nRG:");
            aluno.rg = Console.ReadLine();
            
            System.Console.WriteLine("\nQUAL O CURSO?");
            aluno.curso = Console.ReadLine();

            System.Console.WriteLine("\nQUAL A MÉDIA FINAL?");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            System.Console.WriteLine("\nQUAL O VALOR DA MENSALIDADE?");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            System.Console.WriteLine("\nO ALUNO É BOLSISTA? S/N");
            string resposta = Console.ReadLine();
            if(resposta == "S"){
                aluno.bolsista=true;
            }else{
                aluno.bolsista = false;
            }


            //MENU
            int opcao = 0;
            do
            {
                System.Console.WriteLine("Selecione uma opção abaixo");
                System.Console.WriteLine("[1] - Média do Aluno");
                System.Console.WriteLine("[2] - Valor da Mensalidade");
                System.Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
            {
                case 1:
                    System.Console.WriteLine($"A Média Final do aluno é: {aluno.VerMediaFinal()}");
                    break;
                 case 2:
                    System.Console.WriteLine($"O valor a ser pago é: {aluno.VerMensalidade()}");
                    break;
                 case 0:
                    System.Console.WriteLine("Obrigado e volte sempre!");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }

            } while (opcao !=0);
            
        }
    }
}
