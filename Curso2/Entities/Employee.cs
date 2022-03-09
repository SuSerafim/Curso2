namespace Curso2.Entities
{
    class Employee
    {
        public string Name { get; set; } /*atributo*/
        public int Hours { get; set; }  /*atributo*/
        public double ValuePerHour { get; set; }  /*atributo*/

        //Construtor padrão
        public Employee()
        {

        }

        //Construtor com parametros
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

       
        //Metodo
        public virtual double Payment() /* liberando o metodo para que seja sobrescrito*/
        {
            return Hours * ValuePerHour;
        }

    }
}
