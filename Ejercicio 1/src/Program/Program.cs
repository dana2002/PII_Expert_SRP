using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca biblio1 = new Biblioteca("UCU", libro1);
            biblio1.AlmacenarLibro("A","7");
            biblio1.AlmacenarLibro("B","3");

            Console.WriteLine($"Libro {biblio1.NombreLibro} en la biblioteca {biblio1.Nombre}, sector {biblio1.SectorBiblioteca} estante {biblio1.EstanteBiblioteca}");
            /*libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");*/

        }
    }
}
