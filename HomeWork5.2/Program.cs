namespace HomeWork5._2
{
    internal class Program
    {


        static string[] SplitSentence()
        {
            Console.WriteLine("Введите предложение: ");
            string sentence = Console.ReadLine();
            string[] splitText = sentence.Split(' ');
            foreach (var words in splitText)
            {
                Console.WriteLine($" {words} ");
            }

            return splitText;
        }
        static string[] ReverseSentence(string[] splitText)
        {
            Array.Reverse(splitText);
            Console.WriteLine(" \n ");
            foreach (var word in splitText)
            {
                Console.WriteLine($" {word} ");
            }
            return splitText;
        }

        static void Main()
        {
            ReverseSentence(SplitSentence());


        }
    }
}