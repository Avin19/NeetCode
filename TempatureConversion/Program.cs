Console.WriteLine(" Tempature Conversion Menu");
Console.WriteLine("1. Fahrenheit to Celsius");
Console.WriteLine("2. Celsius to Fahrenheit");
int choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
    System.Console.WriteLine("Now converting F to C ");
    System.Console.WriteLine("Enter tempature in Fahrenheit");
    float temp = float.Parse(Console.ReadLine());
    float reu = (float)(temp - 32f) / 1.8f;
    Console.WriteLine("The tempature is Celsius is : " + reu);
}
else
{
    Console.WriteLine(" Celsius to Fahrenheit");
    Console.WriteLine(" Enter tempature in Celsius");
    float temp = float.Parse(Console.ReadLine());
    float rev = 1.8f * (temp + 32);
    Console.WriteLine(" The Tempature is Fahrenheit" + rev);


}