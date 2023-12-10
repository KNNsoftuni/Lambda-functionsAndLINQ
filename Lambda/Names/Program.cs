namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            bool isDigit = false;
            bool isValidName = false;
            foreach (char character in name)
            {
                if (char.IsDigit(character))
                {
                    isDigit = true;
                }

                if (name.Length >= 3 && char.IsUpper(name[0]) && !isDigit)
                {
                    isValidName = true;
                }
                else
                {
                    isValidName = false;
                }
            }

            if (isValidName)
            {
                Console.WriteLine($"Hello, {name}!");
                foreach (char character in name)
                {
                    int asciiValue = character + 10;
                    Console.WriteLine($"{asciiValue}");
                }
            } 
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }
    }
}