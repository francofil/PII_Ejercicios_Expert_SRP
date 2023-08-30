
using System.Collections.Generic;

namespace SRP{

    public class Shelve{
        
        public string codigo { get; set; }
        public List<Book> listaLibros { get; set; }

        public Shelve(string codigo){
            this.codigo = codigo; 
            listaLibros = new List<Book>();
        }

        public void AgregarLibro(Book libro){
            this.listaLibros.Add(libro);
        }

    }
}