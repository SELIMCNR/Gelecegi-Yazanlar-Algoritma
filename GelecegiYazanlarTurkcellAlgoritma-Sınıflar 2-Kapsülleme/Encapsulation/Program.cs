// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

/*Kapsülleme işlemi */
Musteri m = new Musteri();
m.Id = 1;
m.Name = "Selim";
m.Surname = "Çınar";
m.City = "Kahramanmaraş";

Console.WriteLine(m.Id + "" + m.Name + "" + m.Surname  + "" + m.City);

/*entity framework , ASP net core mvc*/