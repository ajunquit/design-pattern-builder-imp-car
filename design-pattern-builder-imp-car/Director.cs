using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder_imp_car
{
    public class Director
    {
        public IBuilder _builder;

        public IBuilder Builder { set => _builder = value; }

        public void ConstructSportCar() {
            _builder.Reset();
            _builder.SetSeats(2);
            _builder.SetGPS(true);
            _builder.SetTripComputer(true);
            _builder.SetEngine(new SportEngine());
            _builder.SetTypeTransmission(TypeTransmission.Automatic);
        }
        public void ConstructSUVCar() {
            _builder.Reset();
            _builder.SetSeats(5);
            _builder.SetGPS(true);
            _builder.SetTripComputer(true);
            _builder.SetEngine(new SUVEngine());
            _builder.SetTypeTransmission(TypeTransmission.Manual);
        }
        public void ConstructSedanCar() {
            _builder.Reset();
            _builder.SetSeats(4);
            _builder.SetGPS(false);
            _builder.SetTripComputer(false);
            _builder.SetEngine(new SedanEngine());
            _builder.SetTypeTransmission(TypeTransmission.CVT);
        }
    }
}
