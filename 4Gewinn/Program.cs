int[,] arr = new int[6, 7];

Console.Write("Wie heißt du hund : ");
string P1 = Console.ReadLine();

Console.Write("und du Arschloch : ");
string P2 = Console.ReadLine();


for (int i = 0; i < arr.GetLength(0); i++)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = 0;
    }
}

void printArr(int[,] arr)
{
    Console.WriteLine("--1---2---3---4---5---6---7--");
    Console.WriteLine("_____________________________");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            Console.Write("|");

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($" {arr[i, j]} ");
                Console.Write("|");
            }
            Console.WriteLine("");
        }
    Console.WriteLine("-----------------------------");
    Console.WriteLine("--1---2---3---4---5---6---7--");
}


bool runing = true;
while(runing)
{
    printArr(arr);
    Console.Write($"{P1} Wohin : ");
    int P1input = Convert.ToInt32(Console.ReadLine());

    arr[5, P1input - 1] = 8;

    printArr(arr);
    Console.Write($"{P2} Wohin : ");
    int P2input = Convert.ToInt32(Console.ReadLine());

    arr[5, P2input - 1] = 8;
}

arr[2,1] = 4;