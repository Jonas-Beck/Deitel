namespace Ex_1605
{
    internal class Program_1605
    {
        static void Main(string[] args)
        {
            Console.Write("Write English Word Sentence:");
            string answer = Console.ReadLine();
            string PigString = "";

            foreach (var word in answer.Split(" "))
            {
                PigString += GetPigLatin(word) + " ";
            }
            Console.WriteLine("Translated to Pig Lating:");
            Console.WriteLine(PigString);
        }

        public static string GetPigLatin(string EnglishString)
        {
            if (EnglishString.Length == 0) { return EnglishString; }

            string PigString = EnglishString.Substring(1);
            PigString += EnglishString[0] + "ay";
            return PigString;
        }
    }
}