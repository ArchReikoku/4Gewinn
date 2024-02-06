Console.Write("wie viel Zeilen :");
int zeile = Convert.ToInt32(Console.ReadLine());
Console.Write("wie viel Spalten :");
int spalte = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[zeile, spalte];

Random rand = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rand.Next(0, 9);
    }
}



void PrintArraySimple(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("------------------");
}


void PrintArrayColorful(int[,] arr)
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(0); j++)
        {
            switch (arr[i, j])
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            //Console.Write(arr[i,j] != 0 ? arr[i,j] : " ");
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine("");
    }


    Console.ForegroundColor = defaultColor;
    Console.WriteLine("------------------");
}

PrintArraySimple(arr);
//PrintArrayColorful(arr);