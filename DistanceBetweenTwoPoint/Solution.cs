public class Solution
{
    Point P1;
    Point P2;

    public void SetPoint1(Point p)
    {
        P1 = p;
    }
    public void SetPoint2(Point p)
    {
        P2 = p;
    }
    public void Calculator()
    {
        float res = ((P1.X - P2.X) * (P1.X - P2.X)) + ((P1.Y - P2.Y) * (P1.Y - P2.Y));
        float result = MathF.Sqrt(res);
        Console.WriteLine(" Distance between Point P1 :" + P1.PrintPoint() + "and P2 :" + P2.PrintPoint() + " Answer is : " + result);
    }
}
public class Point
{
    public float X;
    public float Y;

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    public string PrintPoint()
    {
        return "Point X" + X + "Point Y" + Y;
    }
}