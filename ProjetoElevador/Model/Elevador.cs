using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        //Abaixo estão os atributos da classe Elevador.
        private int andarAtual { get; set; } //É o andar atual.
        private int andarTotal { get; set; } //É o total de andares não contando com o térreo.
        private int capacidadeElevador { get; set; } //Quantas pessoas o elevador comporta.
        private int pessoasElevador { get; set; } //Quantas pessoas estão no elevador.

        public Elevador() // Construtor com os parâmetros iniciais
        {
            andarAtual = 0; // O elevador começa no andar térreo (0).
            pessoasElevador = 0; //O elevador começa sem passageiros (0).   
        }

        public void Inicializar() //Método que recebe os parâmetros da capacidade do elevador e total de andares.
        {
            Console.WriteLine("Qual a capacidade de pessoas do elevador:");
            capacidadeElevador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantos andares (desconsidere o térreo):");
            andarTotal = Convert.ToInt32(Console.ReadLine());
        }

        public void Entrar() // Método que soma um passageiro no elevador; gera aviso se não houver espaço. Não faz retorno de variável.
        {
            if (pessoasElevador < capacidadeElevador)
            {
                pessoasElevador++;
                Console.WriteLine("Entrou 1 pessoa, Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, pessoasElevador);
            }
            else
            {
                Console.WriteLine("Elevador lotado! Aguarde.");
            }
        }

        public void Sair() // Método que subtrai um passageiro no elevador; gera aviso se já estiver vazio. Não faz retorno de variável.
        {
            if (pessoasElevador > 0)
            {
                pessoasElevador--;
                Console.WriteLine("Saiu 1 pessoa. Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, pessoasElevador);
            }
            else
            {
                Console.WriteLine("Elevador já está vazio!");
            }
        }

        public void Subir() // Método que sobe um andar; gera aviso se já estiver no último. Não faz retorno de variável.
        {
            if (andarAtual < andarTotal)
            {
                andarAtual++;
                Console.WriteLine("Subiu um andar. Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, pessoasElevador);
            }
            else
            {
                Console.WriteLine("Elevador já está no último andar!");
            }
        }

        public void Descer() // Método que desce um andar; gera aviso se já estiver no térreo. Não faz retorno de variável.
        {
            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine("Desceu um andar. Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, pessoasElevador);
            }
            else
            {
                Console.WriteLine("Elevador já está no térreo!");
            }
        }

    }
}
