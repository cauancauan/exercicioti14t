using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI14T
{
    class controlexercicios
    {
        //ligar as duas classes
        modelexercicios model;
        private int opcao;
        public controlexercicios()
        {
            model = new modelexercicios();//chamando o construtor da model exercícios

        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }

        }
        public void Menu()
        {
            Console.WriteLine("-----Menu-----" +
                              "\n1.Exercício01\n" +
                              "\n2.Exercício02\n" +
                              "\n3.Exercício03\n"+
                              "\n4.Exercício04\n"+
                              "\n4.Exercício05\n"+
                              "\n6.Exercício06\n"+
                              "\n8.Exercício08\n");
            Console.WriteLine("Escolha uma das opções acima");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());



        }//Fim do Menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                default:
                    Console.WriteLine("Código digitado não é válido!");
                    break;
                case 1:

                    Console.WriteLine(model.Exercicio01());
                    break;
                case 2:
                    Console.WriteLine("Informe um número");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num + " é: " +model.Exercicio02(num));
                    break;
                case 3:

                    Console.WriteLine("Informe a base");
                    double ba = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe a altura");
                    double al = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A área é: " + model.Exercicio03(ba, al));
                    break;
                case 4:
                    Console.WriteLine("Informe quantos anos você tem:");
                    int anos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe quantos meses você tem:");
                    int meses = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe quantos dias você tem:");
                    int dias = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sua idade em dias é de: " + model.Exercicio04(anos, meses, dias ));
                        break;
                case 5:
                    Console.WriteLine("Informe o número de eleitores:");
                    double eleitores = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o número de votos brancos:");
                    double vbranco = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o número de votos nulos");
                    double vnulo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o número de votos válidos");
                    double vvalido = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(model.Exercicio05(eleitores, vbranco, vnulo, vvalido));
                    break;
                case 6:
                    Console.WriteLine("Informe o salário mensal");;
                    double sal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o percentual de reajuste");
                    double perc = Convert.ToInt32(Console.ReadLine());                   
                    Console.WriteLine("O novo salário é de: " + model.Exercicio06(sal, perc));
                    break;

                case 8:
                    Console.WriteLine("Informe a primeira nota");
                    double nota1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe a segunda nota");
                    double nota2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe a terceira nota");
                    double nota3 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Sua média final é de: " + model.Exercicio08(nota1, nota2, nota3
                        ));
                    break;




             
            }//fim do switch


        }//fim do executar

    }//Fim class


}
