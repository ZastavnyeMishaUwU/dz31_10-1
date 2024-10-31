namespace dz31_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть речення: ");
            string input = Console.ReadLine();
            string abbreviation = "";
            string[] words = input.Split(' ');
            foreach (string word in words)
            {

                if (!string.IsNullOrEmpty(word))
                {

                    abbreviation += char.ToUpper(word[0]);
                }
            }


            Console.WriteLine("Скорочення: " + abbreviation);
        }
    }
}
