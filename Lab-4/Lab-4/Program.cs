// See https://aka.ms/new-console-template for more information

using Lab_4;
using Lab_4.Entities;

var square = new Square(4);
var triangle = new Triangle(4, 5, 6, 7);
var rectangle = new Rectangle(10, 20);


var areas = new List<IShape>
{
    square,
    triangle,
    rectangle
};
foreach (var area in areas)
{
    Console.WriteLine($"Area: {area.GetArea()} -- Perimeter: {area.GetPerimeter()}");
}