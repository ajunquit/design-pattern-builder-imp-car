// See https://aka.ms/new-console-template for more information
using design_pattern_builder_imp_car;

Console.WriteLine("Hello, World!");

var director = new Director();
var carBuilder = new CarBuilder();
director.Builder = carBuilder;

director.ConstructSportCar();

var car = carBuilder.GetCar();

