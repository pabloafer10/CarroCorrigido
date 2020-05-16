using System;
using System.Collections.Generic;
using System.Text;

namespace CarroCorrigido
{
    class Carro
    {
        private long id;
        private double valorDeDiaria;
        private double valorDeCusto;
        private string modelo;
        private string cor;
        private int ano;
        private int numDias;
        private double porcentagem;

        public int NumDias { get => numDias; set => numDias = value; }
        public double Porcentagem { get => porcentagem; set => porcentagem = value; }

        public Carro(string modelo, string cor, int ano, double valorDeCusto, double valorDeDiaria)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.valorDeCusto = valorDeCusto;
            this.valorDeDiaria = valorDeDiaria;

        }
        /* public long Id 
        {
            get { return this.id; }
            set { this.id = this.id; }
        }
        public double ValorDeVenda
        {
            get { return this.valorDeVenda; }
            set { this.ValorDeVenda = valorDeCusto * 1.35; }
        }
        public double ValorDeDiaria 
        { 
            get { return this.valorDeDiaria; }
            set { this.ValorDeDiaria = this.ValorDeVenda / 200; }
        }
        public double ValorDeCusto 
        { 
            get { return this.valorDeCusto; } 
            set { this.ValorDeCusto = this.ValorDeCusto; } 
        }*/

        public void setId(long id)
        {
            this.id = id;
        }
        public long getId()
        {
            return this.id;
        }
        /*public double calcValorDeVenda(double lucro)
        {
        return valorDeCusto * lucro;
        }*/
        public void setValorDeDiaria(Double vl)
        {
            vl = this.valorDeDiaria * NumDias;
        }
        public double getValorDeDiaria()
        {
            return this.valorDeDiaria;
        }
        public void setValorDeCusto(double vC)
        {
            vC = this.valorDeCusto * Porcentagem;
        }
        public double getValorDeCusto()
        {
            return this.valorDeCusto;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }
        public int getAno()
        {
            return this.ano;
        }

    }
}
