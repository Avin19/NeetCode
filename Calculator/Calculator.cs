public class Calculator
{
    float num1;
    float num2;
    int oper;

    public Calculator(float _nu1, float _nu2, int _oper)
    {
        num1 = _nu1;
        num2 = _nu2;
        oper = _oper;

    }

    public float ResultShow()
    {
        if (oper == 1)
        {
            Console.WriteLine("Adding Both the Numbers");
            return num1 + num2;
        }
        else if (oper == 2)
        {
            Console.WriteLine("Substract Numbers");
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }
        else if (oper == 3)
        {
            Console.WriteLine("Multipying Both the Number");
            return num1 * num2;
        }
        else if (oper == 4)
        {
            Console.WriteLine(" Dividing Number");
            return num1 / num2;
        }
        else
        {
            Console.WriteLine(" Calculator Doesn't Support this Operation");
            return 0.0f;
        }
    }
}