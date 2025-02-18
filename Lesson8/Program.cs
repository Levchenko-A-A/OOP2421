using Lesson8;

//Complex complex1 = new Complex(5,-8);
//Complex complex2 = new Complex(11, 3);
//Console.WriteLine(complex1);
//Console.WriteLine(complex2);

//Complex z3 = complex1 + complex2;
//Console.WriteLine(z3);
//z3 = complex1 - complex2;
//Console.WriteLine(z3);
//z3 = complex1 * complex2;
//Console.WriteLine(z3);
//z3 = complex1 / complex2;
//Complex z7 = -complex1;
//Console.WriteLine(z7);

Triangle triangle = new Triangle() { A = 5, B = 3, C = 8 };
Console.WriteLine($"S={triangle.getArea():F2} p={triangle.getPerimetr():F2})");
