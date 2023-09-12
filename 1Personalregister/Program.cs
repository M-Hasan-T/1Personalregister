namespace _1Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 1 :Vilka klasser bör ingå i programmet?
            // Deklareras genom att använda klassen Program; static klass, Console klass osv.

            //Uppgift 2 :Vilka attribut och metoder bör ingå i dessa klasser?
            // Main-metoden är ingångspunkten; 
            //Jag använde inte en användardefinierad metod, men jag använde inbyggda metoder som WriteLine, ReadLine, toLower, Char.IsDigit, Char.IsLetter osv.

            //Uppgift 3 :Skriv programmet

            var list = new List<KeyValuePair<string, string>>();
            string printOutput = "ja";

            while (printOutput == "ja")
            {
                Console.WriteLine("Ange namnet:");
                string firstName = Console.ReadLine();
                if (firstName != "" && firstName.All(Char.IsLetter))
                {
                    Console.WriteLine("Ange lön:");
                    string salary = Console.ReadLine();
                    if (salary != "" && salary.All(Char.IsDigit))
                    {
                        list.Add(new KeyValuePair<string, string>(firstName, salary));
                    }
                    else
                    {
                        Console.WriteLine("Ange endast siffror!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ange endast bokstäver!");
                    continue;
                }
                Console.WriteLine("Vill du fortsätta ange information? Typ \"ja\"\nOm inte, tryck på en annan knapp!");
                printOutput = Console.ReadLine().ToLower();
                Console.Clear();
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}s lön: {item.Value} kronor");
            }

        }
    }
}