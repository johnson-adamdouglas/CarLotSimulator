using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        //class properties
        public List<object> CarList { get; set; }

        //object initializer constructor
        public CarLot()
        {
            CarList = new List<object>();
        }
    }
}
