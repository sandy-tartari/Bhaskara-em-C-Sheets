using System;


namespace bhaskara
{
    partial class Program
    {
        static void Main(string[] args)
       
        {
        // Faça um algoritmo que calcule as duas raízes da fórmula de Bhaskara
        int a, b, c;
        double delta, raiz, x1, x2;
        
        Console.WriteLine("Digite um valor para a");
        a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite um valor para b");
        b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite um valor para c");
        c = int.Parse(Console.ReadLine());

        delta = (b * b) - (4 * a * c);
        Console.WriteLine(" O delta é {0}", delta);

        raiz = Math.Sqrt(delta);
        Console.WriteLine(" A raiz do delta é {0}", raiz);
        
        x1 = ((-(b)) + raiz) / (2 * a);
        x2 = ((-(b)) - raiz) / (2 * a);
        
        Console.WriteLine("O resultado de X1 é {0}", x1);
        Console.WriteLine("o resultado de X2 é {0}", x2);
        }
    }
}
