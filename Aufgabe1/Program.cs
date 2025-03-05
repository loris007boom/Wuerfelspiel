int points1 = 0;
int points2 = 0;
int generatedpoints = 0;
int storedpoints = 0;
string risk = "";
Console.Write("Zielpunktzahl: ");
int ziel = Convert.ToInt32(Console.ReadLine());
Console.Write("Spieler 1: ");
string? spieler1 = Console.ReadLine();
Console.Write("Spieler 2: ");
string? spieler2 = Console.ReadLine();
Random random = new Random();
byte start = (byte)random.Next(1, 3);
if(start==1)
{
    Console.WriteLine($"{spieler1} beginnt!");
}else{
    Console.WriteLine($"{spieler2} beginnt!");
}
while(points1<ziel&&points2<ziel)
{
        if(start==1)
        {
            do{
            generatedpoints = GetRandomValue();
            Console.WriteLine($"{spieler1} würfelt {generatedpoints}");
            if(generatedpoints!=1)
            {
                storedpoints+=generatedpoints;
                Console.WriteLine("Willst du stoppen oder weiterwürfeln? Schreib 'weiter' oder 'stop': ");
                risk = Console.ReadLine();
                if(risk=="stop"){
                    points1+=storedpoints;
                    Console.WriteLine($"{spieler1} hat {points1} Punkte erreicht.");
                    if(points1<ziel)
                    {
                        Console.WriteLine("****************");
                        Console.WriteLine($"{spieler2} ist dran!");
                        Console.WriteLine("****************");
                        storedpoints=0;
                        start = 2;
                    }
                }
            }else{
                storedpoints=0;
                start = 2;
                risk="stop";
                Console.WriteLine($"Schade, du hast ein 1 gewürfelt! Du hast {points1} Punkte erreicht.");
                Console.WriteLine("****************");
                Console.WriteLine($"{spieler2} ist dran!");
                Console.WriteLine("****************");
            }
            }while(risk=="weiter");
        }
        if(start==2)
        {
            do{
            generatedpoints = GetRandomValue();
            Console.WriteLine($"{spieler2} würfelt {generatedpoints}");
            if(generatedpoints!=1)
            {
                storedpoints+=generatedpoints;
                Console.WriteLine("Willst du stoppen oder weiterwürfeln? Schreib 'weiter' oder 'stop': ");
                risk = Console.ReadLine();
                if(risk=="stop"){
                    points2+=storedpoints;
                    Console.WriteLine($"{spieler2} hat {points2} Punkte erreicht.");
                    if(points2<ziel)
                    {
                        Console.WriteLine("****************");
                        Console.WriteLine($"{spieler1} ist dran!");
                        Console.WriteLine("****************");
                        storedpoints=0;
                        start = 1;
                    }
                }
            }else{
                storedpoints=0;
                start = 1;
                risk="stop";
                Console.WriteLine($"Schade, du hast ein 1 gewürfelt! Du hast {points2} Punkte erreicht.");
                Console.WriteLine("****************");
                Console.WriteLine($"{spieler1} ist dran!");
                Console.WriteLine("****************");
            }
            }while(risk=="weiter");
        }
}

if(points1>=ziel)
{
    Console.WriteLine($"{spieler1} hat gewonnen!");
}else{
    Console.WriteLine($"{spieler2} hat gewonnen!");
}


int GetRandomValue()
{
    return random.Next(1, 7);
}