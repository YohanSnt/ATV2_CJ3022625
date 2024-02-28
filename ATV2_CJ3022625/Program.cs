namespace ATV2_CJ3022625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reais = 1000, n, triplo, dobro, soma;
            float prcntg, inv, inv1, inv2, inv3, inv4, salario, ptg = 25, ptg1, s1;
          
            //Exercício1
           
            Console.WriteLine("<<EX.1>>\n");
            Console.WriteLine("\nDigite o salário: ");
            salario=float.Parse(Console.ReadLine());
            ptg1 = ptg / 100 * salario;
            s1 = salario + ptg1;
            Console.WriteLine("\nNovo salário com aumento de 25% = {0}", s1);

           //Exercício2

            Console.WriteLine("\n<<EX.2>>\n");
            Console.WriteLine("Digite um número: ");
            n= int.Parse(Console.ReadLine());
            triplo = n * 3 + 1;
            Console.WriteLine("Sucessor do triplo de {0}: {1}",n, triplo);
            dobro = n * 2 - 1;
            Console.WriteLine("Antecessor do dobro de {0}: {1}",n, dobro);
            soma = triplo + dobro;
            Console.WriteLine("Soma final: {0}", soma);



            //Exercício3

            Console.WriteLine("\n<<EX.3>> \n");
            Console.WriteLine("\nValor inicial: {0}\n", reais);
            Console.WriteLine("Primeiro dia, queda percentual: ");
            prcntg=float.Parse(Console.ReadLine());
            inv = prcntg / 100 * reais;
            inv1 = reais - inv;
            Console.WriteLine("Novo valor= {0}", inv1);
            Console.WriteLine("Segundo dia, aumento percentual: ");
            prcntg = float.Parse(Console.ReadLine());
            inv = prcntg / 100 * reais;
            inv2 = inv1 + inv;
            Console.WriteLine("Novo valor= {0}", inv2);
            Console.WriteLine("Terceiro dia, aumento percentual: ");
            prcntg = float.Parse(Console.ReadLine());
            inv = prcntg / 100 * reais;
            inv3 = inv2 + inv;
            Console.WriteLine("Novo valor= {0}", inv3);
            Console.WriteLine("Quarto dia, queda percentual: ");
            prcntg = float.Parse(Console.ReadLine());
            inv = prcntg / 100 * reais;
            inv4 = inv3 - inv;
            Console.WriteLine("Valor FINAL= {0}", inv4);


        }
    }
}
