﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<object> CarList { get; set; }

        public CarLot()
        {
            CarList = new List<object>();
        }
    }
}
