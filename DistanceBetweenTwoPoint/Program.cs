// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Enter the X coodinate of the Point 1 ");
float x1 = float.Parse(Console.ReadLine());
Console.WriteLine(" Enter the Y coodinates of the Point 1");
float y1 = float.Parse(Console.ReadLine());
Point point1 = new Point(x1, y1);
Console.WriteLine("Enter the X2 coodinate of the Point 2");
float x2 = float.Parse(Console.ReadLine());
Console.WriteLine(" Enter the Y coodinates of the Point 2");
float y2 = float.Parse(Console.ReadLine());
Point point2 = new Point(x2, y2);

Solution sol = new Solution();
sol.SetPoint1(point1);
sol.SetPoint2(point2);

sol.Calculator();