using DILibrary;

namespace DependencyInversion;

class Program
{
    static void Main(string[] args)
    {
        /*PROBLEMAS QUE SURGEN:
         -Los modulos de alto nivel como este Main, depende directamente de los modulos de bajo nivel
         clase person y demas, por lo cual hacer un cambio sería romper el programa, ademas dificulta
         su evolucion.
         - Dificil realizacion de pruebas unitarias (demasiadas dependencias para probar una funcionalidad
         especifica)
         -No se puede reutilizar el codigo, en diferentes contextos y demas

        Inversion de dependencias:
         Mayor escabilidad y flexibilidad
         Mejora la capacidad de hacer testing unitarias, es mas facil usar mocks
         El codigo se puede reutilizar
         Mejor mantenimiento, cambios en una implementacion no afecta a otros modulos

         voy a crear interfaces que implementen funcionalidad y se crearan propiedades privadas que se
         inicializaran con interfaces y utilizaran los metodos de cada clase.

         */
        IPerson owner = Factory.CreatePerson();
        owner.FirstName = "Tim";
        owner.LastName = "Corey";
        owner.EmailAddress = "tim@iamtimcorey.com";
        owner.PhoneNumber = "555-1212";

        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Take out the trash";
        chore.Owner = owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}