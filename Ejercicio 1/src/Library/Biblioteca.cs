using System;

namespace SRP
{
    public class Biblioteca
    {  
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        public string Nombre {get; set; }
        public Libro Libro {get; set;}
        
        public string NombreLibro {
          get{
            return Libro.Titulo;
          }
        }

        public Biblioteca(string nombreBiblio, Libro libro){
          this.Nombre = nombreBiblio;
          this.Libro = libro;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}