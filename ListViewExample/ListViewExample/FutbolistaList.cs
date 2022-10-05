using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class FutbolistaList : List<Futbolista>
    {
        public string Heading { get; set; }
        public List<Futbolista> Futbolistas => this;
    }
}
