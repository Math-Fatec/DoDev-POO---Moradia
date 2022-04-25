//Exercicios POO (Moradia)

//using
using System.ComponentModel;
using Internal;
using System;

    namespace {POO}
    {

        public static void Main (string[] args) {

            Console.WriteLine("POO");
        }

        public class Moradores
        {
            String Nome;
            String CPF;
            Timestamp DataNascimento;
        }

        public class Moradia
        {
            public string Endereço {get; set;}
            public int CEP {get; set;}
            public double TamanhoEmMetros {get; set;}
            public int QuantidadeDeBanheiros {get; set;}
            public int QuantidadeDeQuartos {get; set;}
            
            Moradores();
            List<int> Moradores = new List<Morador>();

            CalcularValorAluguel();

            AdicionarMorador();

            RemoverMorador();
        }

        protected class CalcularValorAluguel (Double TamanhoEmMetros)
        {
            Kitnet() = (TamanhoEmMetros * 30);

            Casas() = (TamanhoEmMetros * 35) + (QuantidadeDeQuartos * 10)
+ (QuantidadeDeBanheiros * 5) + // 10% do Valor if ComQuinatl boolean true;

            Apartamentos() = (TamanhoEmMetros * 40) +
(QuantidadeDeQuartos * 10) + (QuantidadeDeBanheiros * 5) + ValorCondominio;

        }

        protected class AdicionarMorador (Morador morador)
        {
            Console.WriteLine("Qual morador você gostaria de adicionar" + Morador);

            Morador = Console.ReadLine();

            List<Morador> adicionarMorador = Lista;

            adicionarMorador.AddRange(Morador); //MaisUm

        }

        protected class RemoverMorador (String CPF)
        {
            Console.WriteLine("Qual morador você gostaria de remover" + CPF);

            CPF = Console.ReadLine();

            List<Morador> removerMorador = Lista;

            removerMorador.Remove(CPF);
        }

        public class Casas
        {
            Boolean ComQuintal;

            CalcularValorAluguel();
        }

        public class Apartamentos
        {
            INT Andar;
            Double ValorCondominio;

            CalcularValorAluguel();
        }

        public class Kitnet
        {
            CalcularValorAluguel();
        }
    }
