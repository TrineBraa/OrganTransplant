
//Oppgave: Organ transplant!
//    Det har vært en akutt ulykke og Bernt ligger på sykehuset.

//    Han trenger en ny Nyre!

//Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!

//Hjelp Bernt med å overleve!

//Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.

//    Lag gjerne Console.WriteLine() - statements i koden slik at man ser hva som skjer!

//Bernt et object
//Kåre et object
//Nyrene må være objecter

//Sjekke at Kåre er en match, samme blodtype som Bernt
//Bernt har ingen nyrer, må flytte en av Kåres nyrer til bernt via list kanskje ?

using OrganTransplant;

var bernt = new Bernt();
var kaare = new Kaare();

bool TestBernt = false;
bool TestKaare = false;



MainMenu();


void MainMenu()
{
    bool Active = true;
    while (Active)
    {
        Console.WriteLine("Welcome to Get Hospital!");
        Console.WriteLine();
        Console.WriteLine("Bernt has had a terrible accident, his kidneys are destroyed and he needs a transplant to survive!");
        Console.WriteLine("\t Luckily Kåre has offered to get tested to see if he is a match for transplant!");
        Console.WriteLine();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine();
        Console.WriteLine("1) Testing Facility");
        Console.WriteLine("2) Operating room");
        Console.WriteLine("3) Exit");

        int EntryNum = Console.ReadKey().KeyChar;
            
        switch (EntryNum)
        {
            case '1':
                TestingFacility();
                break;
            case '2':
                if (TestBernt == true && TestKaare == true)
                {
                    OperatingRoom();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nYou need to test the patients before you can operate! We need to know if they are a match!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                break;
            case '3':
                Active=false;
                break;
            default:
                Console.WriteLine("\nplease choose one of the options offered!");
                Thread.Sleep(2000);
                Console.Clear();
                break;
        }
    }
}



void TestingFacility()
{
    bool Testing = true;
    while (Testing)
    {
        var Patient = Console.ReadLine();
        Console.WriteLine("Who should we test first? Kåre or Bernt? exit to leave the facility");
        switch (Patient)
        {
            case "Kåre":
                Console.WriteLine();
                TestKaare = true;
                kaare.ShowKaare();
                Console.WriteLine();
                Console.WriteLine("\t We have Kåre's results!");
                Console.WriteLine();
                break;
            case "Bernt":
                Console.WriteLine();
                TestBernt = true;
                bernt.ShowBernt();
                Console.WriteLine();
                Console.WriteLine("\t We have Bernt's Results!");
                Console.WriteLine();
                break;
            case "exit":
                Testing = false;
                Console.Clear();
                break;
            default:
                Console.WriteLine("Please choose one of the patients to test, it's important!");
                break;
        }
    }

}


void OperatingRoom()
{
    Console.Clear();
    Console.WriteLine("Everything is ready to operate! The patients are a match");
    Console.WriteLine("\texit to leave the operating room.");
    Console.WriteLine();

    bool KidneyBernt = false;
    bool KidneyKaare = false;

    bool Operate = true;
    while (Operate)
    {
        Console.WriteLine("\nLet's begin!");
        Console.WriteLine("Who do we operate on first?");
        var Who = Console.ReadLine();

        switch (Who)
        {
            case "Kåre":
                kaare.OperateKaare();
                KidneyKaare = true;
                Thread.Sleep(2000);
                break;
            case "Bernt":
                if (KidneyKaare== false)
                {
                    Console.WriteLine("You have no donated kidney yet..");
                }
                else
                {
                    bernt.OperateBernt();
                    KidneyBernt = true;
                }

                Thread.Sleep(2000);
                break;
            case "exit":
                if (KidneyBernt == false && KidneyKaare == false)
                {
                    Console.WriteLine("You leave and Bernt dies... :(");
                    Thread.Sleep(2000);
                    Operate = false;
                }
                else
                {
                    Console.WriteLine("You saved Bernt's life!");
                    Thread.Sleep(2000);
                    Operate = false;
                }
                break;
            default:
                Console.WriteLine("Please make a decision!");
                break;
        }

    }
}






