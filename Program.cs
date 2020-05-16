using System;

namespace CarroCorrigido
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro("Renault Kwid Life", "Vermelho", 2018, 16000, 80);
            Carro car2 = new Carro("Hyundai HB20 Sense", "Branco", 2019, 17000, 100);
            Carro car3 = new Carro("Ford Ka S", "Preto", 2017, 15000, 50);
            Carro car4 = new Carro("Volkswagen Gol", "Prata", 2018, 20000, 80);
            Carro car5 = new Carro("Chevrolet Joy", "Amarelo", 2020, 23000, 130);

            string menu;
            int op;
            double valor;
            double porcentagem;
            double vV;
            int qtdeDias;
            double vL;

            menu = "*******************************************************\nLOCAVENDAS VEICULOS\n*******************************************************\n1.Listar Carros.\n2.Vendas.\n3.Locação.\n0.Sair.\n*******************************************************";
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                Console.Write("\n Opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("********************************************************\nListar Carros\n********************************************************");
                        Console.Write("\nCARROS                  COR       ANO    CUSTO   DIÁRIA\n********************************************************");
                        Console.Write("\n1." + car1.getModelo() + "   " + car1.getCor() + "    " + car1.getAno() + "   " + car1.getValorDeCusto() + "     " + car1.getValorDeDiaria() + "" +
                                      "\n2." + car2.getModelo() + "   " + car2.getCor() + "     " + car2.getAno() + "   " + car2.getValorDeCusto() + "    " + car2.getValorDeDiaria() + "" +
                                      "\n3." + car3.getModelo() + "             " + car3.getCor() + "     " + car3.getAno() + "   " + car3.getValorDeCusto() + "     " + car3.getValorDeDiaria() + "" +
                                      "\n4." + car4.getModelo() + "        " + car4.getCor() + "     " + car4.getAno() + "   " + car4.getValorDeCusto() + "     " + car4.getValorDeDiaria() + "" +
                                      "\n5." + car5.getModelo() + "        " + car5.getCor() + "    " + car5.getAno() + "   " + car5.getValorDeCusto() + "    " + car5.getValorDeDiaria() + "");
                        break;

                    case 2:
                        Console.Write("********************************************************\nVender\n********************************************************");
                        Console.Write("\nVenda de Carros\n********************************************************");
                        Console.WriteLine("\nDigite o id do carro: ");// COMO PODERIA FAZER PARA CHAMAR O NOME DO CARRO SEM NECESSIDADE DE DIGITAR O NOME
                        Console.Write("\nOpção: ");
                        op = Convert.ToInt32(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("1 - {0} Custo{1} " , car1.getModelo(), car1.getValorDeCusto());
                                valor = car1.getValorDeCusto();
                                Console.Write("\nDigite o percentual de lucro : ");
                                porcentagem = Convert.ToDouble(Console.ReadLine());
                                vV = valor * porcentagem;
                                Console.WriteLine("\nO valor da venda é R$: " + vV + "% .2f");
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("C2 - {0} Custo{1} " , car2.getModelo(), car2.getValorDeCusto());
                                valor = car2.getValorDeCusto();
                                Console.Write("\nDigite o percentual de lucro : ");
                                porcentagem = Convert.ToDouble(Console.ReadLine());
                                vV = valor * porcentagem;
                                Console.WriteLine("\nO valor da venda é R$: " + vV + "% .2f");
                                Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("3 - {0} Custo{1} " , car3.getModelo(), car3.getValorDeCusto());
                                valor = car3.getValorDeCusto();
                                Console.Write("\nDigite o percentual de lucro : ");
                                porcentagem = Convert.ToDouble(Console.ReadLine());
                                vV = valor * porcentagem;
                                Console.WriteLine("\nO valor da venda é R$: " + vV + "% .2f");
                                Console.ReadLine();
                                break;

                            case 4:
                                Console.WriteLine("4 - {0} Custo{1} " , car4.getModelo(), car4.getValorDeCusto());
                                valor = car4.getValorDeCusto();
                                Console.Write("\nDigite o percentual de lucro : ");
                                porcentagem = Convert.ToDouble(Console.ReadLine());
                                vV = valor * porcentagem;
                                Console.WriteLine("\nO valor da venda é R$: " + vV + "% .2f");
                                Console.ReadLine();
                                break;


                            case 5:
                                Console.WriteLine("5 - {0} Custo{1} " , car5.getModelo(), car5.getValorDeCusto());
                                valor = car5.getValorDeCusto();
                                Console.Write("\nDigite o percentual de lucro : ");
                                porcentagem = Convert.ToDouble(Console.ReadLine());
                                vV = valor * porcentagem;
                                Console.WriteLine("\nO valor da venda é R$: " + vV + "% .2f");
                                Console.ReadLine();
                                break;

                        }
                        break;

                    case 3:
                        Console.Write("********************************************************\nLocar\n********************************************************");
                        Console.Write("\nLocar Carros\n********************************************************");
                        Console.WriteLine("\nDigite o id do carro: ");// COMO PODERIA FAZER PARA CHAMAR O NOME DO CARRO SEM NECESSIDADE DE DIGITAR O NOME
                        Console.Write("\nOpção: ");
                        op = Convert.ToInt32(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("1 - {0} Custo{1} " , car1.getModelo(), car1.getValorDeDiaria());
                                valor = car1.getValorDeDiaria();
                                Console.Write("\nDigite a quantidade de dias: ");
                                qtdeDias = Convert.ToInt32(Console.ReadLine());
                                vL = valor * qtdeDias;
                                Console.WriteLine("\nO valor da locação é R$: " + vL);
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("2 - {0} Custo{1} " , car2.getModelo(), car2.getValorDeDiaria());
                                valor = car2.getValorDeDiaria();
                                Console.Write("\nDigite a quantidade de dias: ");
                                qtdeDias = Convert.ToInt32(Console.ReadLine());
                                vL = valor * qtdeDias;
                                Console.WriteLine("\nO valor da locação é R$: " + vL);
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("3 - {0} Custo{1} " , car3.getModelo(), car3.getValorDeDiaria());
                                valor = car3.getValorDeDiaria();
                                Console.Write("\nDigite a quantidade de dias: ");
                                qtdeDias = Convert.ToInt32(Console.ReadLine());
                                vL = valor * qtdeDias;
                                Console.WriteLine("\nO valor da locação é R$: " + vL);
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("4 - {0} Custo{1} " , car4.getModelo(), car4.getValorDeDiaria());
                                valor = car4.getValorDeDiaria();
                                Console.Write("\nDigite a quantidade de dias: ");
                                qtdeDias = Convert.ToInt32(Console.ReadLine());
                                vL = valor * qtdeDias;
                                Console.WriteLine("\nO valor da locação é R$: " + vL);
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("5 - {0} Custo{1} " , car5.getModelo(), car5.getValorDeDiaria());
                                valor = car5.getValorDeDiaria();
                                Console.Write("\nDigite a quantidade de dias: ");
                                qtdeDias = Convert.ToInt32(Console.ReadLine());
                                vL = valor * qtdeDias;
                                Console.WriteLine("\nO valor da locação é R$: " + vL);
                                Console.ReadLine();
                                break;
                        }
                            break;
                            case 0:
                        Console.Write("\nAté Breve!");
                        break;
                    default:
                        Console.Write("\n Opção inválida, digite novamente! ");
                        break;
                }
                Console.ReadKey();
            } while (op != 0);

        }
    }
}
