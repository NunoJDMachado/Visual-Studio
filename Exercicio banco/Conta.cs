using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_banco
{
    internal class Conta
    {
      
        //Atributos
        
        private int _nconta;
        private string _tconta;       
        public double QuantiaDepInicial;
        private double _saldo;
        public char DepInicialResposta;

        //Construtores

        public Conta()
        {

        }

        public Conta(int Nconta, string Tconta, double Saldo)
        {
            Nconta = _nconta;
            Tconta = _tconta;
            Saldo = _saldo;
        }
        
        //Propriedades
        public int Nconta
        {
            get
            {
                return _nconta;
            }
            set
            {
                _nconta = value;
            }
                 
        }

        public string Tconta
        {
            get
            {
                return _tconta;
            }
            set
            {
                if ()
                {

                }
                _tconta = value;
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
           
        }


       
            
           

       
        //Métodos
        public void AumentarSaldo(double quantiaDep)
        {
            Saldo = Saldo + quantiaDep;
        }

        public void ReduzirSaldo(double quantiaLev)
        {
            Saldo = Saldo - quantiaLev - 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Nconta
                + ", Titular: " + Tconta
                + ", Saldo: " + +Saldo;
        }
    }
}
