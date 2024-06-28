using ISLibrary;
using ISLibrary.Interfaces;
namespace InterfaceSegregation;

class Program
{
    static void Main(string[] args)
    {
        /*PROBLEMAS QUE SURGEN:
         Los libros heredan propiedades que no necesitan
         e implementan metodos que devuelven excepciones.

        Buscamos asignar capacidades de hacer cosas y caracteristicas
        por medio de interfaces a modo de un rompecabezas, por ejemplo
        quiero que esto se pueda rentar (implemento IBorrowable),
        Quiero que tenga las propiedades basicas de un libro (implemento IBook)
        En caso de que exista un nuevo item que tenga las mismas
        propiedades que un librosimplementeimplementariamos IBook
        y adicionariamos lo necesario para ese item especifico
        
        Codigo escalable, sin necesidad de modificaciones libre a seguir extendiendose
        
         SOLUCIONES:
         Crear interfaces que simulen piezas de funcionalidad o propiedades
         Y crear interfaces para los distintos tipos de items que implementen
         estas piezas de caracteristicas segun sea necesario, asi evitamos 
         que las clases se llenen de propiedades innecesarias*/
        
        //estas tres instancias tienen todoo lo que necesitan 
        IBorrowableBook book = new Book();
        IBorrowableAudioBooks audioBook = new AudioBook();
        IBorrowableDVD dvd = new DVD();
        
        //estas instancias serían como las de arriba pero sin la capacidad de ser rentadas
        IBook noBorrowableBook = new Book();
        IAudioBook noBorrowableAudioBook = new AudioBook();
        IDVD noBorrowableDVD = new DVD();
        
        Console.WriteLine("Hello, World!");
    }
}