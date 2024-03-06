namespace ATV2_CJ3022625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int reais = 1000, n, triplo, dobro, soma;
            float prcntg, inv, inv1, inv2, inv3, inv4, salario, ptg = 25, ptg1, s1;

            
             
            //Exercício1
            int m, cm, mm;
            Console.WriteLine("EX.1\n");
            Console.WriteLine("Valor em metros: ");
            m=int.Parse(Console.ReadLine());
            cm = m * 100;
            Console.WriteLine("M em CM: {0} ", cm);
            mm = m * 1000;
            Console.WriteLine("M em MM: {0} ", mm);
           
           


            //Exercício2
            float f, c;
            Console.WriteLine("EX.2\n");
            Console.WriteLine("Valor em Fahrenheit: ");
            f=float.Parse(Console.ReadLine());
            c = (f - 32) * (5 / 9);
            Console.WriteLine("Valor em Celcius = {0}", c);
            Console.WriteLine("\nSempre resulta em 0 pois a fórmula tem de ser 9/5, e não 5/9.\nNesse caso:\n");
            c = (f - 32) * (9 / 5);
            Console.WriteLine("Valor correto em Celcius: {0}", c);

            



            //Exetcício3
            float peso, altura,a1, imc;
            Console.WriteLine("EX.3\n");
            Console.WriteLine("Diga seu peso: ");
            peso=float.Parse(Console.ReadLine());
            Console.WriteLine("Diga sua altura: ");
            altura= float.Parse(Console.ReadLine());
            a1 = altura * altura;
            imc = (peso / a1);
            Console.WriteLine("Seu IMC = {0}", imc);

            


            //Exercício4
            float n1, n2, n3, m1, m2;
            Console.WriteLine("EX.4\n");
            Console.WriteLine("Digite um número qualquer: ");
            n1=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2=float.Parse(Console.ReadLine());
            Console.WriteLine("Outro número: ");
            n3=float.Parse(Console.ReadLine());
            m1 = n1 + n2 + n3;
            m2 = m1 / 3;
            Console.WriteLine("Média pondera: {0}", m2);

           

            //Exercício5
            float s, t, v;
            Console.WriteLine("EX.5\n");
            Console.WriteLine("<<Fórmula de Velocidade Média>>\n v = Δs/Δt");
            Console.WriteLine("\nDigite a distância(variação de espaço): ");
            s=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo que levou do início até o fim do movimento de variação: ");
            t = float.Parse(Console.ReadLine());
            v = s / t;
            Console.WriteLine("Velocidade média do objeto = {0}", v);



            //Exercício6
            Console.WriteLine("EX.6\n");
            Console.WriteLine("\nDigite o salário: ");
            salario=float.Parse(Console.ReadLine());
            ptg1 = ptg / 100 * salario;
            s1 = salario + ptg1;
            Console.WriteLine("\nNovo salário com aumento de 25% = {0}", s1);
           
            

            //Exercício7
            float r, d, c1;
            Console.WriteLine("EX.7\n");
            Console.WriteLine("Digite o valor em real: ");
            r=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do dólar: ");
            d=float.Parse(Console.ReadLine());
            c1 = r * d;
            Console.WriteLine("Conversão em dólar = {0}", c1);

            

            //Exercício8
            Console.WriteLine("EX.8\n");
            Console.WriteLine("\nDigite um número: ");
            n= int.Parse(Console.ReadLine());
            triplo = n * 3 + 1;
            Console.WriteLine("Sucessor do triplo de {0}: {1}",n, triplo);
            dobro = n * 2 - 1;
            Console.WriteLine("Antecessor do dobro de {0}: {1}",n, dobro);
            soma = triplo + dobro;
            Console.WriteLine("Soma final: {0}", soma);
           


            //Exercício9
            int nn;
            Console.WriteLine("EX.9\n");
            Console.WriteLine("Digite um número inteiro de 4 dígitos: ");
            nn = int.Parse(Console.ReadLine());

          

            
            //Exercício10
            Console.WriteLine("EX.10\n");
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

            


            //Exercício11
            Console.WriteLine("EX.11\n");
            float nm, cb, q;
            Console.WriteLine("Digite um número: ");
            nm=float.Parse(Console.ReadLine());
            q = nm * nm;
            Console.WriteLine("Número ao quadrado: {0}", q);
            cb = nm * nm * nm;
            Console.WriteLine("\nNúmero ao cubo: {0} ",cb);

            






        }
    }
}
