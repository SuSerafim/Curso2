using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2.Entities
{
    class OutsourcedEmployee : Employee //herda a classe Employee (todas as propriedades e metodos)
    {
        public double AdditionalCharge { get; set; }//atributo

        //Construtor padrão
        public OutsourcedEmployee()
        {

        }

        //Construtor com parametros
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base (name, hours, valuePerHour ) /*reaproveitando os argumentos */
        {
            AdditionalCharge = additionalCharge;
        }


        //Fazendo uma sobreposição do metodo Payment existente
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge; /* reaproveitando a lógica do Payment comum + a despesa adicional*/
        }
    }
}
