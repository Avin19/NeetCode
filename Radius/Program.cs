Console.WriteLine("Enter the Radius of the Circle ");

Calculaor calculaor = new Calculaor();

float rad = float.Parse(Console.ReadLine());

calculaor.Area((int)rad);
calculaor.Perimeter((int)rad);

