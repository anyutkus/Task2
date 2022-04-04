using System;

var m1 = new Matrix(1, 2, 3, 4, 5);
var m2 = new Matrix(1, 2, 3, 4, 5);
var m3 = new Matrix(10, -2, 32, 43, 52, 1);

Console.WriteLine(m1.Size);
Console.WriteLine(m1.Track());


Console.WriteLine("Matrices");
Console.WriteLine(m1.ToString());
Console.WriteLine(m2.ToString());
Console.WriteLine(m3.ToString());


Console.WriteLine("Hash Codes");
Console.WriteLine(m1.GetHashCode());
Console.WriteLine(m2.GetHashCode());
Console.WriteLine(m3.GetHashCode());


Console.WriteLine("Sum");
var m4 = new Matrix(m1.Sum(m3));
Console.WriteLine(m4.ToString());