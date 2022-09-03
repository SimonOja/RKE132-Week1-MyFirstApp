//This is a comment to my code

//Rakendus küsib kasutajal sisestada tema nime
//Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Sisesta oma nimi:"); //Output
//String - sõne
String Kasutajanimi = Console.ReadLine(); //Input

Console.WriteLine("Tere" + ", " + Kasutajanimi + "!"); //Output

//string interpolation
Console.WriteLine($"Tere, {Kasutajanimi} !"); //Output