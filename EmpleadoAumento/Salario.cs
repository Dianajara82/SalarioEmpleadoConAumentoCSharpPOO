using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpleadoAumento
{
    public class Salario : Principal
    {
        private double total;
        private double aumento;
        public void calcularSalario()
        {
            if (this.getAntiguedad() == "5 años")
            {
                this.aumento = this.getSalario() * 0.3;
                this.total = this.aumento + this.getSalario();

            }
            else if (this.getAntiguedad() == "7 años")
            {
                this.aumento = this.getSalario() * 0.4;
                this.total = this.aumento + this.getSalario();

            }
            else if (this.getAntiguedad() == "10 años")
            {
                this.aumento = this.getSalario() * 0.45;
                this.total = this.aumento + this.getSalario();

            }
            else
            {
                this.aumento = this.getSalario() * 0.5;
                this.total = this.aumento + this.getSalario();
            }

        }

        public double getTotal()
        {
            return this.total;
        }
        public double getAumento()
        {
            return this.aumento;
        }
    }
}
