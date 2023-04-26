using Celular_Cel;

Celular novoCel = new Celular();

Console.WriteLine($"Modelo:");
novoCel.Modelo = Console.ReadLine();

Console.WriteLine($"Cor:");
novoCel.Cor = Console.ReadLine();

Console.WriteLine($"Tamanho:");
novoCel.Tamanho = Console.ReadLine();

string opcao;
do
{
   Console.WriteLine(@$"
o========{novoCel.Modelo}========o
┈┈┈╲┈┈┈┈╱
┈┈┈╱ ▔▔╲                                 
┈┈┃┈▇┈┈▇┈┃                             
╭╮┣━━━━━━┫╭╮           
┃┃┃┈┈┈┈┈┈┃┃┃              
╰╯┃┈┈┈┈┈┈┃╰╯
┈┈╰┓┏━━┓┏╯
");
Console.WriteLine(@$"
╭═══════════════╮                     
 {novoCel.Modelo}
 {novoCel.Cor}
 {novoCel.Tamanho}

1. Ligar                 
2. Desligar
3. Ligação
4. Mensagem
0. Sair

╰═══════════════╯
");
opcao = Console.ReadLine().ToLower();

switch (opcao)
{
    case "1":
        novoCel.Ligar();
    break;
    
    case "2":
        novoCel.Desligar();
    break;

    case "3":
        if (novoCel.Ligado == true)
        {
            Console.WriteLine($"Digite o número:");
            string numeroLigar = Console.ReadLine();
            novoCel.FazerLigacao(numeroLigar);
        }
        else
        {
            Console.WriteLine($"Celular desligado!");
        }
    break;

    case "4":
        if (novoCel.Ligado == true)
        {
            Console.WriteLine($"Digite a mensagem:");
            string mensagem = Console.ReadLine();
            novoCel.EnviarMensagem(mensagem);
        }
        else
        {
            Console.WriteLine($"Celular desligado!");
        }
    break;

    case "0":
        Console.WriteLine($"Celular desligado!");
    break;
    default:
        Console.WriteLine($"Opção inválida!");
        
    break;
} 
} while (opcao != "0");