using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.Model
{
    public class Book
    {
        public string _id { get; set; }
        public string titulo { get; set; }
        public string author { get; set; }
        //public string publicación { get; set; }
        //public List<string> generos { get; set; }
        public string imagen { get ; set; }
        public string sinopsis { get; set; }
        public double precio { get; set; }
        public bool disponible { get; set; }
        public DateTime fecha { get; set; }
    }
}
