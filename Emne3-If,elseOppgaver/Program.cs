
    oppgave1();
    oppgave2();
    oppgave3();

    void oppgave1()
    {
        Console.WriteLine("Oppgave 1!\n");
        Random random = new Random();
        bool isEqual = false;
        int counter = 0;

        while (true)
        {
            int number1 = random.Next(1, 5 + 1);
            int number2 = random.Next(1, 6);


            if (number1 == number2)
            {
                isEqual = true;
                Console.WriteLine($"Det er riktig. Det tok deg {counter} forsøk!\n");
                break;
            }
            else
            {
                isEqual = false;
                Console.WriteLine("Tallene er ikke like!");
                counter++;
            }
        }
    }

    void oppgave2()
    {
        Console.WriteLine("Oppgave 2!\n");
        Random rand = new Random();
        bool equal = true;        
        
        int number3 = 4;
        int number4 = 4;

        if (number3 == number4)
        {
            equal = true;
            Console.WriteLine(number3 * number4);
            Console.WriteLine("");
    }
        else
        {
            equal = false;
            Console.WriteLine(number3 + number4);
            Console.WriteLine("");
    }
    }

    void oppgave3()
    {
        Console.WriteLine("Oppgave 3\n");
        Random oppgave3 = new Random();
        int number5 = 10;
        int number6 = 20;
        int number7 = 30;
        bool erSann = true;
        
        if (number5 + number6 == number7) 
        {
            Console.WriteLine(erSann);
        }
        else
        {
            Console.WriteLine(!erSann);
        }
    }

        
