using System;

namespace Projeto_Bingo2020_v1._0
{
    // PROJETO BINGO 2020 v1.0


    class Program
    {
        static void ler_cartao(int[] cartao1)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                cartao1[i] = rnd.Next(1, 99);

                for (int j = 0; j < i; j++)
                {
                    if (cartao1[j] == cartao1[i])
                    {
                        cartao1[i] = rnd.Next(1, 99);
                    }
                }
            }
        }

        static void ordenar_cartao(int[] cartao1)
        {
            int aux;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (cartao1[j] > cartao1[i])
                    {
                        aux = cartao1[i];
                        cartao1[i] = cartao1[j];
                        cartao1[j] = aux;
                    }
                }
            }
        }
        static void mostrar_cartao(int[] cartao1)
        {
            int i;
            for (i = 0; i < 15; i++)
            {
                
                Console.WriteLine("                          " + cartao1[i]);

            }
        }

        static void ler_sorteio(int[] sorteio)
        {
            Random rnd = new Random();
            for (int i = 0; i < 99; i++)
            {
                sorteio[i] = rnd.Next(1, 99);

                for (int j = 0; j < i; j++)
                {
                    if (sorteio[j] == sorteio[i])
                    {
                        sorteio[i] = rnd.Next(1, 99);
                    }
                }
            }
        }

        static void mostrar_sorteio(int[] sorteio)
        {
            int i;
            for (i = 0; i < 99; i++)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("                                            " + sorteio[i]);

            }
        }



        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(" ");
            Console.WriteLine("                     ##################################################");
            Console.WriteLine("                     #                                                #");
            Console.WriteLine("                     #                     WELCOME                    #");
            Console.WriteLine("                     #                                                #");
            Console.WriteLine("                     #             PROJETO BINGO 2020 (v1.0)          #");
            Console.WriteLine("                     #                                                #");
            Console.WriteLine("                     #              Façam as vossas apostas           #");
            Console.WriteLine("                     #                                                #");
            Console.WriteLine("                     ##################################################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(1000);

            int n;
            Console.WriteLine("           Menu");
            Console.WriteLine("");
            Console.WriteLine(" Press 1 - Configuração");
            Console.WriteLine("");
            Console.WriteLine(" Press 2 - Sorteio");
            Console.WriteLine("");
            Console.WriteLine(" Press 3 - PLAY");
            Console.WriteLine("");
            n = int.Parse(Console.ReadLine());
            

            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Programa em Manutenção, volte mais tarde!!!!");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("                                          SORTEIO:                    ");
                        Console.WriteLine(" ");
                        System.Threading.Thread.Sleep(500);

                        int[] sorteio = new int[99];
                        ler_sorteio(sorteio);
                        mostrar_sorteio(sorteio);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("                     O Seu cartão:                    ");
                        Console.WriteLine(" ");
                        System.Threading.Thread.Sleep(1000);


                        int[] cartao1 = new int[15];
                        ler_cartao(cartao1);
                        ordenar_cartao(cartao1);
                        mostrar_cartao(cartao1);
                        System.Threading.Thread.Sleep(2000);


                        Console.WriteLine("                                          SORTEIO:                    ");
                        Console.WriteLine(" ");
                        System.Threading.Thread.Sleep(500);

                        int[] sorteio = new int[99];
                        ler_sorteio(sorteio);
                        mostrar_sorteio(sorteio);
                    }
                    break;

            }
            

            System.Threading.Thread.Sleep(20000);
        }
    }
}

