// See https://aka.ms/new-console-template for more information
string[] favouriteFoodEven =
{
    "pizza", "pasta", "pane", "formaggio", "pesce", "carne", "verdure", "frittura", "dolci", "marmellata"
};


string[] favouriteFoodOdd =
{
    "sottaceti", "frutta secca", "frutta fresca", "selvaggina", "funghi", "latte", "gelatina", "caramelle", "insaccati"
};

// array ad elementi pari

Console.WriteLine($"Array cibi preferiti a numero pari ({favouriteFoodEven.Length} elementi)");

for(var i = 0; i< favouriteFoodEven.Length; i++)
{
    var index = Array.IndexOf(favouriteFoodEven, favouriteFoodEven[i]);
    Console.WriteLine($"posizione: {index} {favouriteFoodEven[i]}"); 
}

Console.WriteLine($"Cibo maggiormente preferito: {favouriteFoodEven[0]}");
Console.WriteLine($"Cibo minormente preferito: {favouriteFoodEven[favouriteFoodEven.Length-1]}");

Console.WriteLine($"Cibo a metà: {favouriteFoodEven[favouriteFoodEven.Length/2]} e {favouriteFoodEven[favouriteFoodEven.Length/2 -1]}");


// array ad elementi dispari

Console.WriteLine($"Array cibi preferiti a numero dispari ({favouriteFoodOdd.Length} elementi)");

for (var i = 0; i < favouriteFoodOdd.Length; i++)
{
    var index = Array.IndexOf(favouriteFoodOdd, favouriteFoodOdd[i]);
    Console.WriteLine($"posizione: {index} {favouriteFoodOdd[i]}");
}

Console.WriteLine($"Cibo maggiormente preferito: {favouriteFoodOdd[0]}");
Console.WriteLine($"Cibo minormente preferito: {favouriteFoodOdd[favouriteFoodOdd.Length - 1]}");

Console.WriteLine($"Cibo a metà: {favouriteFoodOdd[favouriteFoodOdd.Length / 2]}");


