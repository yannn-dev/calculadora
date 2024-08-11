
Console.WriteLine("Calculator in C# language\n");
Console.WriteLine("________________________\n");
//User input for the firt number
Console.WriteLine("Please insert the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
//User input for a second number
Console.WriteLine("Insert the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
//User choose the operation to be realized
Console.WriteLine("Choose one option from the list below:\n");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
//Switch to do the math
switch(Console.ReadLine()) {
    case "a":
        Console.WriteLine($"The result from {n1} + {n2} is: " + (n1 + n2));
        break;
    case "s": 
        Console.WriteLine($"The result from {n1} - {n2} is: " + (n1 - n2));
        break;
    case "m":
        Console.WriteLine($"The result from {n1} * {n2} is: " + (n1 * n2));
        break;
    case "d":
        Console.WriteLine($"The result from {n1} / {n2} is: " + (n1 / n2));
        break;
}

Console.WriteLine("Press any key to close the console app...");
Console.ReadKey();