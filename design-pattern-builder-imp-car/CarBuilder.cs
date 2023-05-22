using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder_imp_car
{
    public class CarBuilder: IBuilder
    {
        private Car _car = new Car();

        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._car = new Car();
        }

        public void SetEngine(IEngineCar engineCar)
        {
            this._car.Engine = engineCar;
        }

        public void SetGPS(bool hasGPS)
        {
            this._car.HasGPS = hasGPS;
        }

        public void SetSeats(int qty)
        {
            this._car.QtySeats = qty;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            this._car.HasTripComputer = hasTripComputer;
        }

        public void SetTypeTransmission(TypeTransmission typeTransmission)
        {
            this._car.TypeTransmission = typeTransmission;
        }

        public Car GetCar()
        {
            Car result = this._car;
            this.Reset();
            return result;
        }
    }
}
