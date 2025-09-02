// bool isAlive = true;
// isAlive = 16 < 6;
// isAlive = 16 > 6;
// isAlive = 16 != 6;
// isAlive = 16 == 6;



  string choice = "";

  

  Console.WriteLine("Du står i en vällbekant korridor. Grå väggar, grått golv. Ett alarm genom rymdskäppet. Något är fel med reaktorn!");
  Console.WriteLine("på din högra sida finns en affish: \"KOM IHÅG: RÖTT ÄR SÖTT OCH GRÖNT ÄR OSKÖNT!\"");
  Console.WriteLine("till vänster finns dörren som leder till reaktorrummet.");
  Console.WriteLine("Följer du korridoren rakt framåt så kommer du till hangaren, där libåtarna finns");
  Console.WriteLine("Vart går du? Framåt eller vänster?");
  choice = Console.ReadLine();
  choice = choice.ToLower();

if (choice == "framåt")
{
    Console.WriteLine("Du kommer till hangaren. Det finns en livbåt kvar.");
    Console.WriteLine("Du hoppar in i livbåten och stänger luckan efter dig. ");
    Console.WriteLine("fingrarna dansar över kontrollerna och systemet aktiveras.");
    Console.WriteLine("Livbåten skjuts ut ur skeppet precis i tid - bakom dig sprängs rymdskeppet i en enorm atomexplosion.");
    Console.WriteLine("Du lever, men du vet att företagen kommer hålla dig ansvarig för skeppet - du kommer vara skuldsatt resten av livet. Om inte radioaktoviteten från explosionen gjorde dig steril så hade dina barn och barnbarn fått ärva dina skulder.");

}
else if (choice == "vänster")
{
    Console.WriteLine("Du kommer i reaktorrummet.");
    Console.WriteLine("Röda larmlapor blinkar, och du ser att reaktorn snart kommer explodera.");
    Console.WriteLine("på en skärm blinkar frågan \"RESET REACTOR SYSTEM?\"");
    Console.WriteLine("under skärmen finns det två knappar. En röd, en grön. Det står inget på dem som antyder vilken som är \"ja\" och vilken som är \"nej\". ");
    Console.WriteLine("Trycker du på  röd eller  grön knapp?");

    choice = Console.ReadLine();
    choice = choice.ToLower();


    if (choice == "röd")
    {
        Console.WriteLine("Bra jobbat! Du mindes precis i tid någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej knappar. ");
Console.WriteLine("rymdskäppet är räddat och kan åka vidare med sin last av illegala vapen.");

    }
Console.ReadLine();
}
Console.ReadLine();

