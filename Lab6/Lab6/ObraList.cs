using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab6
{
    public class ObraList : ObservableCollection<Obra>
    {
        public string Heading { get; set; }
        public ObraList(string headin): base()
        {
            Heading = headin;
        }

        public ObraList(string heading, IEnumerable<Obra> source) : base(source)
        {
            Heading = heading;
        }
    }
}
