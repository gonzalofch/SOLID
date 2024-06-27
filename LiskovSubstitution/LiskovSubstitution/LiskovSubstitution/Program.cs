using System.Text;
using LSLibrary;

namespace LiskovSubstitution;

class Program
{
    static void Main(string[] args)
    {
        //Problemas que surgen viendo las clases
        /*
         *EL CEO TIENE UN METODO QUE NO DEBERIA PODER REALIZAR, ESTO SE DEBE A QUE
         * LA PROPIEDAD MANAGER de cada empleado tambien se hereda a CEO, ceo solamente deberia tener las propiedades
         * basicas de todos los empleados base y ademas implementar la funcionalidad de CEO, por medio de algun IManager
         * y de algun IManaged par los que si pueden ser asignados
         * En resumen, el CEO no es un "empleado" del todoo por lo cual no debe heredar directamente de employee
         */

        //SOLUCIONES 
        /*
         * Crear Interfaces que permitan especificar que es cada tipo de empleado y ademas dar funcionalidad especifica
         * IEmployee que tiene (nombre, apellido salario, metodo salario)
         * Employee sera un Empleado base(iemployee) + IManaged
         * Manager sera un Empleado + IManager (Empleado Base + IManaged + IManager)
         * CEO sera un Empleado Base + IManager (de esta manera evitamos funcionalidad que esta solamente para los IManaged)
         */

        IManager accountingVp = new CEO();
        accountingVp.FirstName = "Emma";
        accountingVp.LastName = "Stone";
        accountingVp.CalculatePerHourRate(4);
 
        BaseEmployee emp = new CEO();
        emp.FirstName = "TIm";
        emp.LastName = "Corey";
        // emp.AssignManager(accountingVp);
        emp.CalculatePerHourRate(2);

        Console.WriteLine(new StringBuilder(emp.FirstName)
            .Append("'s salary is $")
            .Append(emp.Salary)
            .Append("/hour.")
            .ToString());
        Console.ReadLine();
    }
}