using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Core
{
    public class Plane:Base
    {
        public string SerialNum { get; set; }
        public int Capacity { get; set; }
        public List<Seat> Seats { get; set; }

        

    }
}
