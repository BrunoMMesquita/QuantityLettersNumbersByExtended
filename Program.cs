using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string numeroPorExtenso = string.Empty;
                char continua = 's';

                List<string> numeros = new List<string>();
                int quantidade = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (continua.ToString().ToLower().Equals("s"))
                    {
                        string valor = string.Empty;
                        Console.WriteLine($"Digite o {i + 1}º numero");
                        valor = Console.ReadLine();
                        bool isInt = int.TryParse(valor, out int numero);
                        if (isInt && numero < 100 && numero > 0)
                        {
                            numeroPorExtenso = new Util().BuscarExtenso(numero, " e ");
                            Console.WriteLine($"Numero por extenso: {numeroPorExtenso}");
                            numeros.Add(numeroPorExtenso);
                            Console.WriteLine($"Deseja Continuar?(s / n)");
                            continua = char.Parse(Console.ReadLine());
                            while(!continua.ToString().ToLower().Equals("s") && !continua.ToString().ToLower().Equals("n"))
                            {
                                Console.WriteLine($"Apenas s ou n");
                                continua = char.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            var msg = numero > 100 || numero == 0 ? "Apenas é permitido de 1 a 100" : "É permitido apenas numeros";
                            Console.WriteLine(msg);
                            break;
                        }
                    }
                    else
                        break;
                }
                if (numeros.Any())
                {
                    numeros.ForEach(x => quantidade += x.Length);
                    Console.WriteLine($"Quantidade de letras dos numeros digitados por extenso é: {quantidade}");
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("erro ao inicializar");
            }
        }

    }
}

