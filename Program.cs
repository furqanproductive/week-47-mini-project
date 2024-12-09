// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string[] productsList = new string[0];
int productsListSize = 0;
string pattern = "[a-z]|-|[0-9]";
Regex rg = new Regex(pattern);
Console.WriteLine("Skriv in produkter. Avsluta med att skriva \'exit\'");

while (true)
{
    Console.ResetColor();
    Console.WriteLine("Ange produkt:");
    string product = Console.ReadLine();

    //stop getting product from the user when they entered exit
    if (product.Trim().ToUpper() == "exit")
    {
        break;
    }

    if (product.Length == 0)
    {

    }
    if (rg.IsMatch(product))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        productsListSize++;
        Array.Resize(ref productsList, productsListSize);
        int index = productsListSize - 1;
        productsList[index] = product;

    }
    else
    {

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