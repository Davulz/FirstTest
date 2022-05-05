// See https://aka.ms/new-console-template for more information

    var You = new Charsheet(); 
    ConsoleKeyInfo cki;
    bool NOTpressed = true;
//public char[] kodeOrd = new char[11];

Console.WriteLine("Hei og velkommen til GET Academy!");
Console.WriteLine();
Console.WriteLine("Du kobler inn på det avtalte møtet med Geir, G'en i GET, og møter en karismatisk og ivrig fyr.");
Console.WriteLine("-Hva var det du het igjen?");
Console.Write("Jeg heter: ");
You.Name = Console.ReadLine();
Console.WriteLine("-Hei på deg " + You.Name);
Console.WriteLine("Etter en lang og trivelig prat får du tilsendt en link til opptaksprøven");
Console.WriteLine("Alt som står mellom deg og drømmen om å bli utvikler er denne tre-på-rad oppgaven:");
Console.ReadKey();
Console.Clear();

//Opptaksprøven
Console.WriteLine(" ___ ");
Console.WriteLine("|xox| ");
Console.WriteLine("|oox|");
Console.WriteLine("| x0|");
Console.WriteLine(" --- ");
Console.Write("Du sitter i timesvis uten å skjønne noe. Du er nesten ferdig når ett problem oppstår.\nHadde du bare kunne logget verdien av den ene variabelen hadde du sikkert fått det til. \nDu prøver å skrive:\n");
Console.WriteLine("1. CoNsOlE.LoG(var)");
Console.WriteLine("2. konsoll.log(var)");
Console.WriteLine("3. console.log(var)");
Console.WriteLine("4. consoleLog(var)");
do
{
    
    cki = Console.ReadKey();
    if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.D4) { NOTpressed = false; };

}
while (NOTpressed);

Console.WriteLine();

NOTpressed = true;

if (cki.Key == ConsoleKey.D3)
{
    Console.Write(" Veldig bra! Du får logget variablen, funnet feilen, og levert komplett oppgave til Terje (+1 til koding)" +
        "");
    You.Kode++;
    Console.WriteLine();
    Console.Write("Dine ferdigheter:\nKoding: " + You.Kode + "\nTrygghet: " + You.Trygg + "\nNøkkelkompetanser: " + You.NK +"\n Gratulerer! du er videre til MODUL1!!");
}
else {
    Console.WriteLine("Du knoter lenge, men finner ikke ut av feilen. Du sender inn det du har uten store forhåpninger.");
    Console.ReadKey();
    Console.WriteLine("Gratulerer du er fortsatt videre til MODUL1 på tross av problemene som oppsto i opptaket!");


}

Console.ReadKey();
Console.Clear();
Console.WriteLine();
Console.WriteLine("  ~~~~~~~~~~~~~~~~~");
Console.WriteLine("  MODUl1 er i gang.");
Console.WriteLine("  ~~~~~~~~~~~~~~~~~");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Du er plassert i Team 3 sammen med Ola og Kari.\nDen første uka er det mye fokus på trygghet i gruppa, men all kodinga virker veldig overveldende.\nDu skjønner fort at her må du ha en god plan og gode rutiner for å få en god start.\nHvilken linje legger du deg på?");
Console.WriteLine();
Console.WriteLine("1. Du tenker at her har du ikke tid til prat og fjas, du setter deg i deaf/mute og koder for deg selv(+2Kode)");
Console.WriteLine();
Console.WriteLine("2. Du deltar aktivt i praten, men prøver å holde gruppa i skinnet så det ikke blir for mye memes og fjas (+1Trygghet +1Nøkkelkompetanser)");
Console.WriteLine();
Console.WriteLine("3. Kodinga skjønner du sikkert mer av senere, akkurat nå er det mer interessant å prate litt om alle kattene til Kari(+2 Tryggeht)");
Console.WriteLine();
do
{

    cki = Console.ReadKey();
    if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.D3) { NOTpressed = false; };

}
while (NOTpressed);

Console.WriteLine();

NOTpressed = true;

switch (cki.Key)
{
    case ConsoleKey.D1:
        {
            You.Kode++;
            You.Kode++;
            Console.WriteLine("Uten forstyrrelser gjør du store fremskritt i kodinga!");
            break;
        }
    case ConsoleKey.D2:
        {
            You.Kode++;
            You.Trygg++;
            You.NK++;
            //You.kodeOrd[0] = 'G';
            Console.WriteLine("Balansen er god, dere blir godt kjente med hverandre i gruppa, samtidig som dere gjør fremskritt i kodinga.");
            break;
        }
    case ConsoleKey.D3:
        {
            You.Trygg++;
            You.Trygg++;
            //You.kodeOrd = "y".ToArray();
            Console.WriteLine("Du er med på å skape tryggehet i Teamet.");
            break;

        }
}


Console.Write("Dine ferdigheter:\nKoding: " + You.Kode + "\nTrygghet: " + You.Trygg + "\nNøkkelkompetanser: " + You.NK);
Console.ReadKey();
Console.Clear();
Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("  Første Team Oppgave");
Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~");

Console.WriteLine("Tiden går, og det er på tide med første teamoppgave.\nDere i teamet er trygge på hverandre og samarbeider godt.");
Console.Write("Dere skal lage ett fungerende inventory der man kan legge til gjenstander.\nOla skriver denne funksjonen:\n");
Console.WriteLine();
Console.WriteLine("function showOutput(){");
Console.WriteLine(" var skjult = utputt.style.display;");
Console.WriteLine(" if (skjult == 'none') {");
Console.WriteLine("    utputt.style.display = 'grid';");
Console.WriteLine("    knapp.innerHTML = 'Hide tha box!'"); 
Console.WriteLine(" }");
Console.WriteLine(" else {");
Console.WriteLine("    utputt.style.display = 'none';");
Console.WriteLine("    knapp.innerHTML = 'Whats in the Box?';");
Console.WriteLine(" }");
Console.WriteLine("}");
Console.WriteLine();
Console.WriteLine("Hva gjør den?");
Console.WriteLine();
Console.WriteLine("1. Den fjerner boksen for alltid ");
Console.WriteLine("2. Den endrer css stylingen på et element for å enten vise det eller skjule det");
Console.WriteLine("3. Den tar det som er inni en div og putter det utenfor");
Console.WriteLine("4. Du satt og leste om Konami koden på wikipedia og fikk ikke med deg spørsmålet. 12,5!!");
Console.WriteLine();

if (You.Trygg == 2)
{
    Console.WriteLine("*Trygghet*");
    Console.WriteLine("Før du rekker å svare forklarer den ellers så blyge Ola at den endrer css stylingen på et element for å enten vise det eller skjule det");
    Console.WriteLine("Du lærer noe nytt! (Koding +1)");
    You.Kode++;
    Console.Write("Trykk 2 for å svare riktig:");
}
if(You.Kode == 3)
{
    Console.WriteLine("*Koding*");
    Console.Write("Du har vært borti lignende kode før ,og ser umiddelbart at svaret er 2");
}


do
{

    cki = Console.ReadKey();
    if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.D4) { NOTpressed = false; };

}
while (NOTpressed);

Console.WriteLine();

NOTpressed = true;

if (cki.Key == ConsoleKey.D2)
{
    You.Kode++;
    You.Trygg++;
    Console.WriteLine("Du svarer riktig og får en selvtillitsboost! (Koding +1, Trygghet +1)");
}
else
{
    Console.WriteLine("Dette skjønner du lite av. Du sjekker heller om det har skjedd noe nytt på VG. (Koding -1)");
    You.Kode--;
}

Console.ReadKey();
Console.Clear();

Console.WriteLine("  ~~~~~");
Console.WriteLine("  M V C");
Console.WriteLine("  ~~~~~");



Console.WriteLine("Dere begynner å lære ")






public class Charsheet
{
    public string Name = "";
    public int Kode = 0;
    public int Trygg = 0;
    public int NK = 0;
    public string kodeOrdTrff = "GET Academy";
}