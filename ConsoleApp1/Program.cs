using System;
namespace ConsoleApp1;

internal class Program
{
     static string GetString ()
     {
         Console.WriteLine("Введите предложение:");
         string inputText = Console.ReadLine();
         return inputText;
     }

     static string[] SplitText(string inputText)
     {

         string[] textArray = inputText.Split(' ');
         foreach (var words in textArray)
         {
             Console.WriteLine($" {words} ");
         }

         return textArray;
     }

     static void Main()
     {
         SplitText(GetString());
     }
}
