// See https://aka.ms/new-console-template for more information

using APBD3;

Console.WriteLine("Hello, World!");
var liquidContainer = new LiquidContainer();
Console.WriteLine(liquidContainer.SerialNumber);
var liquidContainer2 = new LiquidContainer();
Console.WriteLine(liquidContainer2.SerialNumber);
var gasContainer = new GasContainer();
Console.WriteLine(gasContainer.SerialNumber);
var freezer = new FreezerContainer();
Console.WriteLine(freezer.SerialNumber);