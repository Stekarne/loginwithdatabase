using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNew
{
    class Sal { 
        public Sal() {
        Id = new Random().Next(1, 10000);
    }

        public int Id { get; set; }
        public string salnamn { get; set; }
        public int antalperson { get; set; }
        public bool bokningsläge { get; set; }
    }

  
}
