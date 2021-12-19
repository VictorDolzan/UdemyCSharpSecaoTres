using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres.exercicioCinco
{

    class Funcionario
    {
        private int _idFuncionario;
        private double _horasTrabalhadas;
        private double _salarioPorHora;

        private double _salarioTotal;

        public int IdFuncionario
        {
            get
            {
                return _idFuncionario;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _idFuncionario = value;
            }
        }

        public double HorasTrabalhadas
        {
            get
            {
                return _horasTrabalhadas;
            }
            set
            {
                _horasTrabalhadas = value;
            }
        }

        public double SalarioPorHora
        {
            get
            {
                return _salarioPorHora;
            }
            set
            {
                _salarioPorHora = value;
            }
        }

        public double CalculaSalario()
        {
            _salarioTotal = _salarioPorHora * _horasTrabalhadas;
            
            return _salarioTotal;
        }

    }
}