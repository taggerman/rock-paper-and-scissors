Console.WriteLine("                 velkommen til");
Console.WriteLine(" Xx-_-0003 Rock, paper and scissors 3000-_-xX ");

int player = 0;
int npc = 0;

int runds = 11;
int rundCount = 1;

int rock = 1, paper = 2, scissors = 3;

while (rundCount<= runds)
{

    bool rundWon = false;
    while (rundWon==false)
    {
    roundStart:
        Console.WriteLine("rund: "+rundCount);
        Console.WriteLine(" ");
        Console.WriteLine("score: ");
        Console.WriteLine("----------------------");
        Console.WriteLine("|player: {0} - NPC: {1}  |", player, npc);
        Console.WriteLine("----------------------");
        Console.WriteLine(" ");
        Console.WriteLine("Player turn:");
        Console.WriteLine("type: 1-Rock 2-paper 3-scissor");

        Console.WriteLine(" ");

        string choice = Console.ReadKey(true).KeyChar.ToString();

        switch (choice)
        {
            case "1":
                Console.WriteLine("player choice rock");
                break;
            case "2":
                Console.WriteLine("player choice paper");
                break;
            case "3":
                Console.WriteLine("player choice scissor");
                break;
            default:
                Console.Clear();
                goto roundStart;

        }

        int npcChoice = new Random().Next(1, 4);

        Console.WriteLine("rund " + rundCount + " !FIGHT!");
        Console.WriteLine(" ");

        int playerChoice = int.Parse(choice);

        //hvis spillers valg er rock (1) og og npc valg er scissor (3) 
        if (playerChoice == 1 && npcChoice == 3)
        {
            player++;
            rundCount++;
            rundWon =true;
            Console.WriteLine("player won");
        }
        //hvis spiller valg er rock og npc valg er paper så winner npc
        if (playerChoice == 1 && npcChoice ==2)
        {
            npc++;
            rundCount++;
            rundWon = true;
            Console.WriteLine("npc won");

        }
        //hvis spiller valg er rock og hvis npc valg er rock bliver det tie
        if (playerChoice == 1 && npcChoice == 1)
        {
            Console.WriteLine("tie");
        }
        //hvis spiller valg paper og npc valg scissor så vinder npc
        if (playerChoice == 2 && npcChoice == 3)
        {
            npc++;
            rundCount++;
            rundWon=true;
            Console.WriteLine("npc won");
        }
        //spiller valg paper npc valg rock: spiller won
        if (playerChoice == 2 && npcChoice == 1)
        {
            player++;
            rundCount++;
            rundWon=true;
            Console.WriteLine("player won");
        }
        //spiller valg paper npc valg paper = tie
        if (playerChoice == 2 && npcChoice == 2)
        {
            Console.WriteLine("tie");
        }
        //spiller valg scissor npc valg paper: spiller won
        if (playerChoice == 3 && npcChoice == 2)
        {
            player++;
            rundCount++;
            rundWon=true;
            Console.WriteLine("player won");
        }
        //spiller valg scissor npc valg rock: npc won
        if (playerChoice == 3 && npcChoice == 1)
        {
            npc++;
            rundCount++;
            rundWon=true;
            Console.WriteLine("npc won");
        }
        //spiller valg scissor npc valg scissor = tie
        if (playerChoice == 3 && npcChoice == 3)
        {
            Console.WriteLine("tie");
        }
        Thread.Sleep(1500);
        Console.Clear();
    }
}

Console.Clear();

string winner = string.Empty;

if (player>npc)
{
    winner = "player";
}

else if (npc>player)
{
    winner = "npc";
}

else
{
    winner = "tie";
}

Thread.Sleep(1000);
Console.WriteLine("------------------------------");
Console.WriteLine("WINNER IS " + winner);
Console.WriteLine("------------------------------");