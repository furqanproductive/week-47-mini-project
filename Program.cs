// See https://aka.ms/new-console-template for more information


string[] productsList = new string[0];
int productsListSize = 0;

while (true)
{
    Console.WriteLine("Skriv in produkter. Avsluta med att skriva \'exit\'");
    string product = Console.ReadLine();
    //stop getting product from the user when they entered exit
    if (product.Trim().ToUpper() == "exit")
    {
        break;
    }

    productsListSize++;
    Array.Resize(ref productsList, productsListSize);
    int index = productsListSize - 1;
    productsList[index] = product;
}

Console.WriteLine("Du angav följande produkter:");

// Disply the entered products list
foreach (string product in productsList)
{ 
    Console.WriteLine("* " + product); 
}

Console.WriteLine("Press enter to continue...");

Console.ReadLine();