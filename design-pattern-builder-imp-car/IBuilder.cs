using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder_imp_car
{
    public interface IBuilder
    {
        public void Reset();

        public void SetSeats(int qty);

        public void SetEngine(IEngineCar engineCar);

        public void SetTripComputer(bool hasTripComputer);

        public void SetGPS(bool hasGPS);

        public void SetTypeTransmission(TypeTransmission typeTransmission);


    }
}
