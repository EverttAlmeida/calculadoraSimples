namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, calculo;
            string simbolo;
            bool status = true;

            while (status)
            {
                Console.Write("Qual o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Qual o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual das operações?\n+ Adição\n- Subtração\n* Multiplicação\n/ Divisão ");
                simbolo = Console.ReadLine();

                if (simbolo == "+")
                {
                    calculo = valor1 + valor2;
                    Console.WriteLine($"O valor da Adição foi: {calculo}");
                }
                else if (simbolo == "-")
                {
                    calculo = valor1 - valor2;
                    Console.WriteLine($"O valor da Subtração foi: {calculo}");
                }
                else if (simbolo == "*")
                {
                    calculo = valor1 * valor2;
                    Console.WriteLine($"O valor da Multiplicação foi: {calculo}");
                }
                else if (simbolo == "/")
                {
                    if (valor1 != 0 && valor2 != 0)
                    {
                        calculo = valor1 / valor2;
                        Console.WriteLine($"O valor da Divisão foi: {calculo.ToString("F2")}");
                    }
                    else
                    {
                        Console.WriteLine("A divisão por zero é indefinida");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou algo errado...");
                }

                Console.WriteLine("Sair?\nS ou N");
                simbolo = Console.ReadLine().ToUpper();

                if (simbolo == "S")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }

            }
            Console.WriteLine("Obrigado por me usar ! :D");
        }
    }
}