namespace Emne3_If_elseOppgaver
{
    internal class Program
    {
        public static void getRanNum()
        {
            Random random = new Random();
            int number1 = random.Next(1, 5 + 1);
            int number2 = random.Next(1, 6);
            bool isEqual = false;

            if (number1 == number2)
            {
                isEqual = true;
                Console.WriteLine("Det er riktig");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("Tallene er ikke like!");
            }           
        }
        static void Main()
        {
            getRanNum();
        }
    }
}
