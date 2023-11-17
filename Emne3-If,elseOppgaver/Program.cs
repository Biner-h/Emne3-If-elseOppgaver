
    getRanNum();

    void getRanNum()
    {
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
                Console.WriteLine($"Det er riktig. Det tok deg {counter} forsøk!");
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

        
