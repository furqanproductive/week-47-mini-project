// See https://aka.ms/new-console-template for more information
string[] productsList = new string[0];
int productsListSize = 0;
int index;
bool hasError = false;
Console.WriteLine("Skriv in produkter. Avsluta med att skriva \'exit\'");

while (true)
{
    hasError = false;
    Console.ResetColor();
    Console.WriteLine("Ange produkt:");
    string product = Console.ReadLine();

    //stop getting product from the user when they entered exit
    Console.WriteLine(product.Trim().ToLower());
    if (product.Trim().ToLower() == "exit")
    {
        break;
    }

    Console.ForegroundColor = ConsoleColor.Red;

    if (product.Length == 0)
    {
        Console.WriteLine("Du får inte angetomt värde");
        continue;
    }
    
    if (product.Length < 5)
    {
        Console.WriteLine("Incorrect Entry. Too few characters. Write like AB-400.");
        continue;
    }

    string[] split = product.Split("-");
    if (split.Length < 2)
    {
        Console.WriteLine("Incorrect Entry. One hyphen (-) is required. Write like AB-400.");
        continue;
    }
    else if (split.Length > 2)
    {
        Console.WriteLine("Incorrect Entry. Only one hyphen (-) is allowed. Write like AB-400.");
        continue;
    }

    if (String.IsNullOrEmpty(split[0]) || String.IsNullOrEmpty(split[1]))
    {
        Console.WriteLine("Incorrect Entry. Need data on both sides. Write like AB-400.");
        hasError = true;
    }
    else
    {
        foreach (char c in split[0])
        {
            if (!char.IsLetter(c))
            {
                hasError = true;
            }
        }
        if (hasError)
        {
            Console.WriteLine("Incorrect Entry. Left part is not correct. Write like AB-400.");
        }
    }

    bool isInt = int.TryParse(split[1], out int value);
    if (!isInt)
    {
        Console.WriteLine("Incorrect Entry. Right part is not correct. Write like AB-400.");
        hasError = true;
    }
    else if (value < 201 || value > 499)
    {
        Console.WriteLine("Incorrect Entry. Right part number must be between 200 and 500. Write like AB-400.");
        hasError = true;
    }


    if (!hasError)
    {
        productsListSize++;
        Array.Resize(ref productsList, productsListSize);
        index = productsListSize - 1;
        productsList[index] = product;
        Console.ResetColor();
    }
}

Console.WriteLine("Du angav följande produkter (sorterade):");

Array.Sort(productsList);
// Disply the entered products list
foreach (string product in productsList)
{ 
    Console.WriteLine("* " + product); 
}

Console.WriteLine("Press enter to continue...");

Console.ReadLine();