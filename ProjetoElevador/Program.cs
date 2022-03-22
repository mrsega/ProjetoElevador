
using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string acaoEscolhida; // A variável reflete a ação selecionada.
            bool continuar = true; // A variável permite o loop do programa enquanto verdadeira.

            Elevador elevador = new Elevador(); //Instância da classe elevador para rodar seus métodos.

            elevador.Inicializar(); //Faz a chamada do método para receber parâmetros.

            //Menu do console; dentro da estrutra de repetição até ser encerrrado com a opção 5.
            do
            {
                Console.WriteLine(@" Escolha uma opção:
1 - Entrar
2 - Sair
3 - Subir
4 - Descer
5 - Encerrar");

                acaoEscolhida = Console.ReadLine();
                Console.Clear();

                switch (acaoEscolhida) // Estrutura de controle baseado na ação escolhida.
                {
                    case "1": Console.WriteLine("Ação escolhida: Entrar"); elevador.Entrar(); break;
                    case "2": Console.WriteLine("Ação escolhida: Sair"); elevador.Sair(); break;
                    case "3": Console.WriteLine("Ação escolhida: Subir"); elevador.Subir(); break;
                    case "4": Console.WriteLine("Ação escolhida: Descer"); elevador.Descer(); break;
                    case "5": Console.WriteLine("Ação escolhida: Encerrar"); continuar = false; break;
                    default: Console.WriteLine("Escolha inválida."); break;
                }
                Console.WriteLine("");
            }

            while (continuar);


        }

    }
}
