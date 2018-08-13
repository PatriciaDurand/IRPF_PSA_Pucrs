using System;
using System.Collections.Generic;
using System.Text;

namespace Irpf.BLL
{
    public class Contribuinte
    {
        private String nome;
        private String cpf;
        private int idade;
        private int nroDep;
        private double contrPrev;
        private double totRend;
        private CalculoIrpf impostoDevido;

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string value)
        {
            this.nome = value;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string value)
        {
            cpf = value;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int value)
        {
            idade = value;
        }

        public int getNroDep()
        {
            return nroDep;
        }

        public void setNroDep(int value)
        {
            nroDep = value;
        }

        public double getContrPrev()
        {
            return contrPrev;
        }

        public void setContrPrev(double value)
        {
            contrPrev = value;
        }

        public double getTotRend()
        {
            return totRend;
        }

        public void setTotRend(double value)
        {
            totRend = value;
        }

        public double getImpostoDevido()
        {
            return (impostoDevido.calculaImposto(this));
        }

        public void setImpostoDevido(CalculoIrpf value)
        {
            impostoDevido = value;
        }

        public Contribuinte(String nome, String cpf, int idade,
                        int nroDep, double contrPrev, double totRend)
        {
            this.contrPrev = contrPrev;
            this.cpf = cpf;
            this.idade = idade;
            this.nome = nome;
            this.nroDep = nroDep;
            this.totRend = totRend;
            this.impostoDevido = new CalculoIrpfSimplificado(); // Assume como default
        }

        public void defineCalculo(CalculoIrpf calc)
        {
            impostoDevido = calc;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nome);
            sb.Append(",");
            sb.Append(cpf);
            sb.Append(",");
            sb.Append(idade);
            sb.Append(",");
            sb.Append(nroDep);
            sb.Append(",");
            sb.Append(contrPrev);
            sb.Append(",");
            sb.Append(totRend);
            return (sb.ToString());
        }
    }
}
