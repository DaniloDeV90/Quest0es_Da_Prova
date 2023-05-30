
using VA;

namespace Prova

{
    public class Program
    {
        public static void Main(string[] args)
        {

            int opcao = 0;
            do
            {
                Console.WriteLine("Digite o código da questão que deseja mostrar");
                opcao= int.Parse(Console.ReadLine());



                VA2 VA2 = new VA2();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(VA2.Aluno());
                        break;

                    case 2:
                        Console.WriteLine(VA2.Professor());
                        break;
                    case 3:
                        Console.WriteLine(VA2.Lanchonete());
                        break;

                    default:
                        if (opcao == -1) Console.WriteLine("Código finalizado.");
                        else { Console.WriteLine("ERRO, digite novamente"); }


                        break;
                }


            } while (opcao != -1);
        }
    }
}