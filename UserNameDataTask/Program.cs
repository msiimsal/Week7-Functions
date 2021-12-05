using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrit 1 - 3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta numbrit 1 - 3: ");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    userChoiceOne(userName);
                    break;
                case '2':
                    userChoiceTwo(userName);
                    break;
                case '3':
                    userChoiceThree(userName);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
        public static void userChoiceOne(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
                Console.Write($"{userName[i]}");
        }
        public static void userChoiceTwo(string userLetter)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userLetter[0]}.");
        }
        public static void userChoiceThree(string userLength)
        {
            Console.WriteLine($"Sinu eesnime pikkus on {userLength.Length} sümbolit.");
        }
    }
}
