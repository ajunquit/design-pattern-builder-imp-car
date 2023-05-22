using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder_imp_car
{
    public class Car
    {
        public bool HasGPS { get; set; }
        public bool HasTripComputer { get; set; }
        public int QtySeats { get; set; }
        public IEngineCar Engine { get; set; }

        public TypeTransmission TypeTransmission { get; set; }
    }
}
