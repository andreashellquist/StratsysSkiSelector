// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, welcome to Stratsys cross country ski selector!");
Console.WriteLine("To be able to choose the best possible skis for you we need you to answer a few questions");
var skierProfile = new SkierProfile();
Console.WriteLine("How old are you?");
var age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How long are you?");
var length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What kind of cross country skiing will you perform, Classic or Freestyle?");
var skiType = Console.ReadLine();
Console.ReadLine(); 