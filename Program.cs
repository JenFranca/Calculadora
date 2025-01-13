using System;

namespace Calculator
{
    class Program
    {
        // Este é o ponto de entrada principal do programa
        // Chama o método Menu para iniciar o programa
        static void Main(string[] args)
        {
            Menu();  // Chama o método Menu que exibe as opções de operação
        }

        // Método que exibe o menu com as opções de operação e recebe a escolha do usuário
        static void Menu()
        {
            Console.Clear();  // Limpa a tela para uma visualização limpa

            // Exibe as opções de operações para o usuário
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");

            // Tenta converter a entrada do usuário para um número (opção de operação)
            if (short.TryParse(Console.ReadLine(), out short res))
            {
                // Dependendo da escolha do usuário, chama o método correspondente
                switch (res)
                {
                    case 1: Soma(); break;  // Se o usuário escolher '1', chama o método Soma
                    case 2: Subtracao(); break;  // Se o usuário escolher '2', chama o método Subtracao
                    case 3: Divisao(); break;  // Se o usuário escolher '3', chama o método Divisao
                    case 4: Multiplicacao(); break;  // Se o usuário escolher '4', chama o método Multiplicacao
                    case 5:
                        // Se o usuário escolher '5', o programa será encerrado
                        Environment.Exit(0); break;
                    default:
                        // Se a escolha não for válida, chama o método Menu novamente para o usuário tentar novamente
                        Menu(); break;
                }
            }
            else
            {
                // Se o usuário inserir um valor não numérico, exibe a mensagem de erro e chama o menu novamente
                Console.WriteLine("Opção inválida! Tente novamente.");
                Console.ReadLine();  // Aguarda o usuário pressionar Enter
                Menu();  // Retorna ao menu para nova tentativa
            }
        }

        // Método para realizar a operação de soma
        static void Soma()
        {
            Console.Clear();  // Limpa a tela antes de mostrar os resultados

            // Solicita o primeiro valor e tenta converter para um número do tipo float
            Console.WriteLine("Primeiro valor: ");
            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                // Solicita o segundo valor
                Console.WriteLine("Segundo valor:");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    // Realiza a soma e exibe o resultado
                    float resultado = v1 + v2;
                    Console.WriteLine($"O resultado da soma é {resultado}");
                }
                else
                {
                    // Caso o segundo valor não seja válido, exibe a mensagem de erro
                    Console.WriteLine("Valor inválido para o segundo número.");
                }
            }
            else
            {
                // Caso o primeiro valor não seja válido, exibe a mensagem de erro
                Console.WriteLine("Valor inválido para o primeiro número.");
            }

            // Aguarda o usuário pressionar Enter antes de retornar ao menu
            Console.ReadLine();
            Menu();  // Retorna ao menu principal
        }

        // Método para realizar a operação de subtração
        static void Subtracao()
        {
            Console.Clear();  // Limpa a tela antes de mostrar os resultados

            // Solicita o primeiro valor
            Console.WriteLine("Primeiro valor:");
            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                // Solicita o segundo valor
                Console.WriteLine("Segundo valor:");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    // Realiza a subtração e exibe o resultado
                    float resultado = v1 - v2;
                    Console.WriteLine($"O resultado da subtração é {resultado}");
                }
                else
                {
                    // Caso o segundo valor não seja válido, exibe a mensagem de erro
                    Console.WriteLine("Valor inválido para o segundo número.");
                }
            }
            else
            {
                // Caso o primeiro valor não seja válido, exibe a mensagem de erro
                Console.WriteLine("Valor inválido para o primeiro número.");
            }

            // Aguarda o usuário pressionar Enter antes de retornar ao menu
            Console.ReadLine();
            Menu();  // Retorna ao menu principal
        }

        // Método para realizar a operação de divisão
        static void Divisao()
        {
            Console.Clear();  // Limpa a tela antes de mostrar os resultados

            // Solicita o primeiro valor
            Console.WriteLine("Primeiro valor:");
            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                // Solicita o segundo valor
                Console.WriteLine("Segundo valor:");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    // Verifica se o segundo valor não é zero, para evitar divisão por zero
                    if (v2 != 0)
                    {
                        // Realiza a divisão e exibe o resultado
                        float resultado = v1 / v2;
                        Console.WriteLine($"O resultado da divisão é {resultado}");
                    }
                    else
                    {
                        // Caso o segundo valor seja zero, exibe mensagem de erro (não é possível dividir por zero)
                        Console.WriteLine("Não é possível dividir por zero.");
                    }
                }
                else
                {
                    // Caso o segundo valor não seja válido, exibe a mensagem de erro
                    Console.WriteLine("Valor inválido para o segundo número.");
                }
            }
            else
            {
                // Caso o primeiro valor não seja válido, exibe a mensagem de erro
                Console.WriteLine("Valor inválido para o primeiro número.");
            }

            // Aguarda o usuário pressionar Enter antes de retornar ao menu
            Console.ReadLine();
            Menu();  // Retorna ao menu principal
        }

        // Método para realizar a operação de multiplicação
        static void Multiplicacao()
        {
            Console.Clear();  // Limpa a tela antes de mostrar os resultados

            // Solicita o primeiro valor
            Console.WriteLine("Primeiro valor: ");
            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                // Solicita o segundo valor
                Console.WriteLine("Segundo valor: ");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    // Realiza a multiplicação e exibe o resultado
                    float resultado = v1 * v2;
                    Console.WriteLine($"O resultado da multiplicação é {resultado}");
                }
                else
                {
                    // Caso o segundo valor não seja válido, exibe a mensagem de erro
                    Console.WriteLine("Valor inválido para o segundo número.");
                }
            }
            else
            {
                // Caso o primeiro valor não seja válido, exibe a mensagem de erro
                Console.WriteLine("Valor inválido para o primeiro número.");
            }

            // Aguarda o usuário pressionar Enter antes de retornar ao menu
            Console.ReadLine();
            Menu();  // Retorna ao menu principal
        }
    }
}
