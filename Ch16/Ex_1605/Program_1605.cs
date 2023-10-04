namespace Ex_1605
{
    internal class Program_1605
    {
        static void Main(string[] args)
        {
            Console.Write("Write English Word Sentence:");
            string answer = Console.ReadLine();
            string pigString = "";

            foreach (var word in answer.Split(" "))
            {
                pigString += getPigLatin(word) + " ";
            }
            Console.WriteLine("Translated to Pig Lating:");
            Console.WriteLine(pigString);
        }

        public static string getPigLatin(string englishString)
        {
            if (englishString.Length == 0) { return englishString; }

            string pigString = englishString.Substring(1);
            pigString += englishString[0] + "ay";
            return pigString;
        }
    }
}