
using System;
using System.Collections.Generic;

namespace SRP{

    public class Sector{
        
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Shelve> listaShelves { get; set; }
        public Sector(String nombre, int id){
            this.nombre = nombre;
            this.id = id;
            listaShelves = new List<Shelve>();
        }

        public void AgregarEstante(Shelve estante){
            this.listaShelves.Add(estante);
        }


    }
}


































