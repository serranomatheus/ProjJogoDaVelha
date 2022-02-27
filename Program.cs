using System;

namespace ProjJogaDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];

            bool velha = false;
            int jogadas = 0;
            string opc = "a";
            int placar1 = 0, placar2 = 0, empate = 0;
            string jogador1, jogador2;
            Console.WriteLine("Digite o nome do Jogador 1 [X]");
            jogador1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do Jogador 2 [O]");
            jogador2 = Console.ReadLine();

            do
            {
                Console.Clear();               
                Inicio();
                ImprimirJogo();
                Console.WriteLine("Pressione uma tecla para Comecar");
                Console.ReadKey();
                Console.Clear();

                do
                {
                    if (velha == false)
                    {
                        JogadorUm();
                        jogadas++;
                        if (jogadas > 4)
                        {
                            VerificarLinha();
                            VerificarColuna();
                            VerificarDiagonal();
                        }
                    }
                    if (jogadas == 9)
                    {
                        Console.WriteLine("*****Velha*******");
                        empate++;
                        velha = true;
                    }
                    if (velha == false)
                    {
                        JogadorDois();
                        if (jogadas > 4)
                        {
                            VerificarLinha();
                            VerificarColuna();
                            VerificarDiagonal();
                        }
                        jogadas++;
                    }
                   
                } while (velha != true);
                Console.WriteLine("Deseja jogar outra partida ?\n[1]SIM [0]NAO");
                opc = Console.ReadLine();
            } while (opc != "0");

            void VerificarDiagonal()
            {
                int contX0 = 0;
                int contO0 = 0;
                int contO1 = 0;
                int contX1 = 0;
                for (int diagonal = 0; diagonal < matriz.GetLength(1); diagonal++)
                {
                    if (matriz[diagonal, diagonal] == "X")
                    {
                        contX0++;
                        contO0 = 0;

                    }
                    else if (matriz[diagonal, diagonal] == "O")
                    {
                        contO0++;
                        contX0 = 0;
                    }

                }
                for (int diagonal = 0; diagonal < matriz.GetLength(0); diagonal++)
                {
                    if (matriz[diagonal, matriz.GetLength(1) - 1 - diagonal] == "X")
                    {
                        contX1++;
                        contO1 = 0;

                    }
                    else if (matriz[diagonal, matriz.GetLength(1) - 1 - diagonal] == "O")
                    {
                        contO1++;
                        contX1 = 0;
                    }
                }
                if ((contX0 == 3) || (contX1 == 3))
                {
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Jogador 1 [X] VENCEDOR");
                    Console.WriteLine("**********************");
                    ImprimirJogo();
                    Console.ReadKey();
                    placar1++;
                    velha = true;
                }
                if ((contO0 == 3) || (contO1 == 3))
                {
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Jogador 2 [O] VENCEDOR");
                    Console.WriteLine("**********************");
                    ImprimirJogo();
                    Console.ReadKey();
                    placar2++;
                    velha = true;
                }
            }
            void VerificarLinha()
            {
                int contX0 = 0;
                int contO0 = 0;
                int contX1 = 0;
                int contO1 = 0;
                int contX2 = 0;
                int contO2 = 0;

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[0, coluna] == "X")
                    {
                        contX0++;
                        contO0 = 0;

                    }
                    else if (matriz[0, coluna] == "O")
                    {
                        contO0++;
                        contX0 = 0;
                    }


                }
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[1, coluna] == "X")
                    {
                        contX1++;
                        contO1 = 0;

                    }
                    else if (matriz[1, coluna] == "O")
                    {
                        contO1++;
                        contX1 = 0;
                    }


                }
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[2, coluna] == "X")
                    {
                        contX2++;
                        contO2 = 0;

                    }
                    else if (matriz[2, coluna] == "O")
                    {
                        contO2++;
                        contX2 = 0;
                    }


                }


                if ((contX0 == 3) || (contX1 == 3) || (contX2 == 3))
                {
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Jogador 1 [X] VENCEDOR");
                    Console.WriteLine("**********************");
                    ImprimirJogo();
                    Console.ReadKey();
                    placar1++;
                    velha = true;
                }
                if ((contO0 == 3) || (contO1 == 3) || (contO2 == 3))
                {
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Jogador 2 [O] VENCEDOR");
                    Console.WriteLine("**********************");
                    ImprimirJogo();
                    Console.ReadKey();
                    placar2++;
                    velha = true;
                }

            }
            void VerificarColuna()
            {
                int contX0 = 0;
                int contO0 = 0;
                int contX1 = 0;
                int contO1 = 0;
                int contX2 = 0;
                int contO2 = 0;

                for (int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    if (matriz[linha, 0] == "X")
                    {
                        contX0++;
                        contO0 = 0;

                    }
                    else if (matriz[linha, 0] == "O")
                    {
                        contO0++;
                        contX0 = 0;
                    }


                }
                for (int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    if (matriz[linha, 1] == "X")
                    {
                        contX1++;
                        contO1 = 0;

                    }
                    else if (matriz[linha, 1] == "O")
                    {
                        contO1++;
                        contX1 = 0;
                    }
                }

                for (int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    if (matriz[linha, 2] == "X")
                    {
                        contX2++;
                        contO2 = 0;
                    }
                    else if (matriz[linha, 2] == "O")
                    {
                        contO2++;
                        contX2 = 0;
                    }
                }
                if ((contX0 == 3) || (contX1 == 3) || (contX2 == 3))
                {
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Jogador 1 [X] VENCEDOR");
                    Console.WriteLine("**********************");
                    ImprimirJogo();
                    Console.ReadKey();
                    placar1++;
                    velha = true;
                }
                if ((contO0 == 3) || (contO1 == 3) || (contO2 == 3))
                {
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Jogador 2 [O] VENCEDOR");
                    Console.WriteLine("**********************");
                    ImprimirJogo();
                    Console.ReadKey();
                    placar2++;
                    velha = true;
                }

            }
            void Inicio()
            {
                velha = false;
                jogadas = 0;
                int preencher = 1;
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        matriz[linha, coluna] = Convert.ToString(preencher++);
                    }
                }
            }
            void ImprimirJogo()
            {
                Console.WriteLine("************PLACAR*****************");
                Console.WriteLine("Jogador 1[X] {0}\t {1} Vitorias", jogador1, placar1);
                Console.WriteLine("Jogador 2[O] {0}\t {1} Vitorias", jogador2, placar2);
                Console.WriteLine("*********** Empates {0} ************", empate);
                Console.WriteLine("***********************************");               
                Console.WriteLine("--------------------");
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        Console.Write("{0}\t", matriz[linha, coluna]);


                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------");
            }
            void JogadorUm()
            {
                Console.Clear();
                bool verif = false;
                ImprimirJogo();
                Console.WriteLine("Jogador 1 {0}[X]\nEscolha um Numero referente a posicao que deseja jogar", jogador1);                
                string jogada = Console.ReadLine();
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        if (matriz[linha, coluna] == jogada)
                        {
                            matriz[linha, coluna] = "X";
                            verif = true;
                        }

                    }
                }
                if (verif == false)
                {
                    Console.Clear();
                    Console.WriteLine("Posicao nao encontrada ou ja preenchida\nPressione uma tecla para jogar novamente");
                    Console.ReadKey();
                    JogadorUm();
                }

                Console.Clear();
            }
            void JogadorDois()
            {
                Console.Clear();
                bool verif = false;
                ImprimirJogo();
                Console.WriteLine("Jogador 2 {0}[O]\nEscolha um Numero referente a posicao que deseja jogar", jogador2);                
                string jogada = Console.ReadLine();
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        if (matriz[linha, coluna] == jogada)
                        {
                            matriz[linha, coluna] = "O";
                            verif = true;

                        }
                    }
                }
                if (verif == false)
                {
                    Console.Clear();
                    Console.WriteLine("Posicao nao encontrada ou ja preenchida\nPressione uma tecla para jogar novamente");
                    Console.ReadKey();
                    JogadorDois();
                }

                Console.Clear();
            }
        }
    }
}
