using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres.exercicioCinco
{
    class Pecas
    {
        private int _codigoPeca;
        private int _numeroPecas;
        private double _valorUnitario;
        private static int _quantidadePecas;
        private static double _valorAPagar;     

        public int CodigoPeca
        {
            get
            {
                return _codigoPeca;
            }
            set
            {
                _codigoPeca = value;
            }
        }

        public int NumeroPecas
        {
            get
            {
                return _numeroPecas;
            }
            set
            {
                _numeroPecas = value;                
            }
        }

        public double ValorUnitario
        {
            get
            {
                return _valorUnitario;
            }
            set
            {
                _valorUnitario = value;
            }
        }

        public double CalculaValorAPagar()
        {
            _valorAPagar = _numeroPecas * _valorUnitario;            
            return _valorAPagar;
        }

        public double ValorAPagar 
        {
            get
            {
                return CalculaValorAPagar();
            }
        }
    }
}