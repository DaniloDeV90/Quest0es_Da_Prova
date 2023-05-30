using System.Net;

namespace VA
{
    public class VA2
    {
        public string Aluno()
        {
            double[] notas = new double[4];
            int contador = 0;
            do
            {

                Console.WriteLine("Digite a nota do aluno");

                notas[contador] = double.Parse(Console.ReadLine());

                if (notas[contador] > 10 || notas[contador] < 0) { return "Valor inválido, retornando ao menu"; }
                contador++;

            } while (contador != 4);

            double resultado = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            string Mostrar = "";
            if (resultado >= 6) Mostrar = ("Aprovado!");
            if (resultado < 6) Mostrar = ("Reprovado");

            return ("Sua média foi: " + resultado + "--A média da escola é 6 e você está " + Mostrar);

        }

        public string Professor()
        {

            Console.WriteLine("Níveis de professores \n" +
                "Nível 1 R$ 12,00 \n" +
                "Nível 2 R$ 17,00  \n" +
                "Nível 3 R$ 25,00 " +
                "Digite o seu nível ");
            int Nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidades de hora trabalhada");
            int Horas = int.Parse(Console.ReadLine());


            if (Nivel < 1 || Nivel > 3) return "Valor inválido, retornando ao menu";

            int resultado = 0;
            switch (Nivel)
            {
                case 1:
                    resultado = 12 * Horas;
                    break;
                case 2:
                    resultado = 17 * Horas;
                    break;
                case 3:
                    resultado = 25 * Horas;
                    break;
            }

            return "Seu salário é: " + resultado;


        }

        public string Lanchonete()
        {
            Console.WriteLine("----CÓDIGOS---- \n" +
           "---100 CACHORRO QUENTE 1,10   \n" +
           "---101 BAURU SIMPLES 1,30  \n" +
           "---102 BAURU C/OVO 1,50  \n" +
           "---103 HAMBURGUER 1,10  \n" +
           "---104 CHEESEBURGER 1,30  \n" +
           "--105 REFRIGERANTE 1,00  \n");
            int codigo = int.Parse(Console.ReadLine());


            if (codigo > 105 || codigo < 100) return "Valor inválido, retornando ao menu";

            Console.WriteLine("Digite a quantidade que você quer");
            int qnt = int.Parse(Console.ReadLine());

            double valortot = 0;
            string nomeDoPedido = "";
            
            switch (codigo)
            {

                case 100:
                    nomeDoPedido = "CACHORRO QUENTE";
                    valortot = qnt * 1.10;
                    break;
                case 101:
                    nomeDoPedido = "BAURU SIMPLES";
                    valortot = qnt * 1.30;
                    break;
                case 102:
                    nomeDoPedido = "BAURU C/OVO";
                    valortot = qnt * 1.50;
                    break;
                case 103:
                    nomeDoPedido = "HAMBURGUER";
                    valortot = qnt * 1.10;
                    break;
                case 104:
                    nomeDoPedido = "CHEESEBURGER";
                    valortot = qnt * 1.30;
                    break;
                case 105:
                    nomeDoPedido = "REFRIGERANTE";
                    valortot = qnt * 1.00;
                    break;
            }

            return "O seu pedido foi " + nomeDoPedido + "\n" +
            "o código do seu pedido foi  " + codigo + "\n" +
            "O valor total do pedido foi: " + valortot + "\n";
            
        }
    }
}