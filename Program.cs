using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Em uma eleição presidencial, existem quatro candidatos. Os votos são informados através de códigos.
Os códigos utilizados são:
• 1,2,3,4 votos para os respectivos candidatos;
• 5 voto nulo;
• 6 voto em branco.

Assim, escreva um programa para receber um único voto e imprima:
• Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
• Se o usuário votou nulo: "Voto nulo contabilizado..."
• Se o usuário votou em branco: "Voto branco contabilizado...

Até aqui valem as soluções de 1 a 7

Daqui em diante elas não atendem o requisito.

@ Caso o usuário informe um código diferente, escreva: "Voto inválido!"

*/


namespace eleicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----ELEIÇÃO-----");

            int voto = 0;
            Console.WriteLine("Digite seu voto:");
            Console.WriteLine("(1)- 1°Candidato");
            Console.WriteLine("(2)- 2°Candidato");
            Console.WriteLine("(3)- 3°Candidato");
            Console.WriteLine("(4)- 4°Candidato");
            Console.WriteLine("(5)- Voto nulo");
            Console.WriteLine("(6)- Voto em branco");
            Console.Write("Voto:");
            voto = int.Parse(Console.ReadLine());

            switch (voto)
            {

                case 1:
                    Console.WriteLine("Voto contabilizado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Voto contabilizado com sucesso!");
                    break;


                case 3:
                    Console.WriteLine("Voto contabilizado com sucesso!");
                    break;

                case 4:
                    Console.WriteLine("Voto contabilizado com sucesso!");
                    break;

                case 5:
                    Console.WriteLine("Voto nulo contabilizado com sucesso!");
                    break;

                case 6:
                    Console.WriteLine("Voto em branco com sucesso!");
                    break;

                default:
                    Console.WriteLine("Voto inválido!");
                    break;
            }




        }
    }
}
