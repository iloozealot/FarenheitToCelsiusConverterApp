

Console.Write("Please enter the temperature in degrees Farenheit to convert: ");
double tempF = Convert.ToDouble(Console.ReadLine());

double? tempC = null;

tempC = (tempF - 32) / 1.8; 

Console.WriteLine($"The temperature in degrees Celsius is {Math.Round((decimal)tempC)}.");