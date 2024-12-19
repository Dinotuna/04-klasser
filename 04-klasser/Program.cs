
// Book b1 = new Book("Bok om böcker",10); 
// Book b2 = new Book("Bok om sidan",1); 
// Book b3 = new Book("Bok om kapitel",100); 





// b1.TurnPage();
// b1.GetCurrentPage();

// Console.WriteLine("Hur många stenar vill du skapa");

// static int GetNumber()
// {
//     int result;


//     while(true) 
//     {
//         string tal = Console.ReadLine();

//         if(int.TryParse(tal, out result) && result > 0)
//         {
//             Console.WriteLine("");
//             // Console.WriteLine($"{result} stenar har skapats");
//             return result;
//         }

//         else 
//         {
//             Console.WriteLine("Skriv ett tal som är större än nol");
//         }

//     }

// }

// int r = GetNumber();

// List<Rock> rocks = new();

// for (int i = 0; i < r; i++)
// {
//     rocks.Add(new Rock(i));
// }

// Worker w1 = new Worker();
// WhiteCollar w2 = new WhiteCollar();
// BlueCollar w3 = new BlueCollar();



// w1.SetWage(100);
// w1.GetWage();
// w1.GetName();
// w1.GetAge();






static void CreateHardware()
{
    int result;
    List<Hardware> hardwares = new();

    Console.WriteLine("Du ska skapa en hårdvara");
    Console.WriteLine("Skriv 1 för Hårddisk, 2 för proccesor, 3 för grafikkort");

    while(true) 
    {
        string val = Console.ReadLine();

        if(int.TryParse(val, out result) && result == 1)
        { 
            Console.WriteLine("Du har valt hårddisk");

            Console.WriteLine("Vad ska den heta?");
            string n = Console.ReadLine();

            Console.WriteLine("Vad ska den kosta?");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket utrymme ska hårdisken ha");
            int s = int.Parse(Console.ReadLine());
            hardwares.Add(new HardDrive(n, p, s));
        }

        else if(int.TryParse(val, out result) && result == 2)
        {
            Console.WriteLine("Du har valt proccesor");

            Console.WriteLine("Vad ska den heta?");
            string n = Console.ReadLine();

            Console.WriteLine("Vad ska den kosta?");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket utrymme ska proccesorn ha");
            int c = int.Parse(Console.ReadLine());
            hardwares.Add(new CPU(n, p, c));

        }

        else if(int.TryParse(val, out result) && result == 3)
        {
            Console.WriteLine("Du har valt grafikkortet");

            Console.WriteLine("Vad ska den heta?");
            string n = Console.ReadLine();

            Console.WriteLine("Vad ska den kosta?");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket utrymme ska grafikkortet ha");
            int m = int.Parse(Console.ReadLine());
            hardwares.Add(new GPU(n, p, m));
        }

        else 
        {
            Console.WriteLine("Skriv ett tal som är mellan 1-3");
        }

    }

}

CreateHardware();



Console.ReadLine();

