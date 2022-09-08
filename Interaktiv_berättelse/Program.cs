
//Namn
Console.WriteLine("Hej! vad heter du?");

string name = Console.ReadLine();

Console.WriteLine($"hej {name} välkommen till spelet");

//Karaktärs namn

Console.WriteLine("Var snäll skriv namnet på din karaktär:");

string karaktär = Console.ReadLine();

Console.WriteLine($"{karaktär}, wow vilket bra namn");

Console.ReadLine();

//Start

Console.WriteLine("Berättelsen börjar");

Console.ReadLine();

Console.WriteLine($"{karaktär} sitter ensmam i ett hus, plötsligt hör {karaktär} något från källaren");

Console.ReadLine();

Console.WriteLine($"Vad ska {karaktär} göra?");

Console.WriteLine("a = gå ner mot källaren");
Console.WriteLine("b = gå ut i köket");

string yes = Console.ReadLine();
if ( yes == "a")

{
Console.WriteLine($"{karaktär} går ner för källar trappan och öppnar dörren, {karaktär} kliver in i den mörka källaren");
Console.ReadLine();
Console.WriteLine($"Vad ska {karaktär} göra?");
Console.WriteLine("a = leta efter lamp knappen");
Console.WriteLine("b = fly tillbaka upp för trappan");
string yes2 = Console.ReadLine();
if ( yes2 == "a")
{
Console.WriteLine($"{karaktär} får panick och börjar leta efter lamp knappen, ett morrande hörs bakifrån");
Console.ReadLine();
Console.WriteLine($"{karaktär} har dött");
Console.ReadLine();
}
else if ( yes2 == "b")
{
Console.WriteLine($"{karaktär} blir obekväm och flyr upp för trappan, {karaktär} hör steg bakom sig men hinner ut ur huset precis i tid");
Console.ReadLine();
Console.WriteLine($"{karaktär} har flytt huset och överlevt");
Console.ReadLine();
}
}

//andra valet

if ( yes == "b")

{
Console.WriteLine($"{karaktär} väljer att gå ut i köket där han hittar en kniv");
Console.ReadLine();
Console.WriteLine($"Vad ska {karaktär} göra?");
Console.WriteLine("a = leta efter lamp knappen");
Console.WriteLine("b = fly tillbaka upp för trappan");
string yes2 = Console.ReadLine();
if ( yes2 == "a")
{
Console.WriteLine($"{karaktär} får panick och börjar leta efter lamp knappen, ett morrande hörs bakifrån");
Console.ReadLine();
Console.WriteLine($"{karaktär} har dött");
Console.ReadLine();
}
else if ( yes2 == "b")
{
Console.WriteLine($"{karaktär} blir obekväm och flyr upp för trappan, {karaktär} hör steg bakom sig men hinner ut ur huset precis i tid");
Console.ReadLine();
Console.WriteLine($"{karaktär} har flytt huset och överlevt");
Console.ReadLine();
}
}