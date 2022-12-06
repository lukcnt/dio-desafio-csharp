using System.IO;
using System.Linq;
using System;

class Program {

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];
        for (int count = 1; count <= qt; count++)
        {
            v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}