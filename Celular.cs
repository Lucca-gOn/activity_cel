// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_Cel
{
    public class Celular
    {
        public string Modelo;
        public string Cor;
        public string Tamanho;
        public bool Ligado;

        public void Ligar()
        {
            Console.WriteLine($"Celular ligado!");
            Ligado = true;
        }

        public void Desligar()
        {
            Console.WriteLine($"Celular desligado!");
            Ligado = false;
            
        }

        public void FazerLigacao(string numero)
        {
            if (Ligado == true)
            {
                Console.WriteLine($"Ligando para {numero}.");
                
            }
            else
            {
                Console.WriteLine($"Celular desligado!");
                
            }
        }

        public void EnviarMensagem(string mensagem)
        {
            if (Ligado == true)
            {
                Console.WriteLine($"Enviando mensagem: {mensagem}");
                
            }
            else
            {
                Console.WriteLine($"Celular desligado!");
                
            }
        }

    }
}