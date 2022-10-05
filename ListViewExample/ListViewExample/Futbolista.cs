using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Futbolista
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Dorsal { get; set; }

        public string DisplayName { get { return $"{LastName}, {FirstName}, {Dorsal}"; } }
    }
}
