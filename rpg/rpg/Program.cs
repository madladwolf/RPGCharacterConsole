using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Program
    {
        enum opcao { Criar_Player = 1, Mostrar_Player = 2, Sair = 3};

        static int MenuPrincipal()
        {
            int aux = 0;
            Console.WriteLine("Escolha uma opcao: ");
            foreach (opcao val in Enum.GetValues(typeof(opcao)))
            {
                Console.WriteLine(++aux + " - " + val);
            }
            return Valor();
        }

        static int Valor()
        {
            int val = 0;
            bool flag = false;
            do
            {
                try
                {
                    val = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor incorrecto, digite novamente:");
                    flag = false;
                }
            } while (!flag);
            return val;
        }

        static void Main(string[] args)
        {
            int op = MenuPrincipal();
            switch (op)
            {
                case 1:
                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("Insira um numero");
                    break;

            }
            
        }
    }
}
