using geom;

Point p1 = new Point(10, 20);
Point p2 = new Point(-20, 60);
Point p3 = new Point(15, 0);

Console.WriteLine("Punkt1");
Console.WriteLine(p1);
Console.WriteLine();
Console.WriteLine("Punkt2");
Console.WriteLine(p2);
Console.WriteLine();
Console.WriteLine("Vahemaa");
Console.WriteLine(p1.Distance(p2));
Console.WriteLine();
Console.WriteLine(p3);
p3.CentreRotate(Math.PI / 3);
Console.WriteLine("Punkt3, pööratud:");
Console.WriteLine(p3);
p3.Scale(10);
Console.WriteLine(p3);
p3.CentreRotate(Math.PI / 3);
Console.WriteLine("Punkt3, pööratud:");
Console.WriteLine(p3);